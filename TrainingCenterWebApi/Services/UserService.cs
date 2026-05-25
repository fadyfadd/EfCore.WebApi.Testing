using System;
using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using DataAccessLayer.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace TrainingCenterWebApi.Services;

public class UserService
{

    private readonly UserManager<ApplicationUser> userManager;
    private readonly IMapper mapper;
    private readonly MainDataBaseContext dbContext;

    public UserService(MainDataBaseContext dataContext, UserManager<ApplicationUser> userManager, IMapper mapper)
    {
        this.userManager = userManager;
        this.mapper = mapper;
        this.dbContext = dataContext;
    }

    public async Task<ApplicationUserDto> RegisterUser(ApplicationUserDto applicationUserDto)
    {

        using var transaction = await dbContext.Database.BeginTransactionAsync();

        var applicationUser = mapper.Map<ApplicationUser>(applicationUserDto);
        applicationUser.EmailConfirmed = true;
        var student = mapper.Map<Student>(applicationUserDto.Student);

        var result = await userManager.CreateAsync(applicationUser, password: applicationUserDto.PlainPassword);

        if (!result.Succeeded)
        {
            await transaction.RollbackAsync();
            var errors = result.Errors
            .GroupBy(e => e.Code)
            .ToDictionary(
                g => g.Key,
                g => g.Select(e => e.Description).ToArray()
);
            throw new BusinessException("4455ebd1", "User registration failed.", null, errors);
        }

        student.UserId = applicationUser.Id;
        dbContext.Students.Add(student);
        dbContext.SaveChanges();

        var res = mapper.Map<ApplicationUserDto>(applicationUser);
        var studentDto = mapper.Map<StudentDto>(student);
        res.Student = studentDto;

        await transaction.CommitAsync();
        return res;

    }

}
