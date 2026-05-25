using System;
using AutoMapper;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mappers;

public class DefaultProfile : Profile
{
    public DefaultProfile()
    {
        CreateMap<Course, CourseDto>().ReverseMap();
        CreateMap<CourseCategory, CourseCategoryDto>().ReverseMap();
        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
    }
}
