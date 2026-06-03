 using AutoMapper;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mappers;

public class DefaultProfile : Profile
{
    public DefaultProfile()
    {

        CreateMap<BaseCourseCategoryDto, CourseCategory>().ReverseMap();
        CreateMap<CourseCategoryDto, CourseCategory>().ReverseMap();


        CreateMap<BaseCourseDto, Course>().ReverseMap();
        CreateMap<CourseDto, Course>().ReverseMap();
        CreateMap<CourseWithStudentsDto, Course>().ReverseMap();

        CreateMap<BaseStudentDto, Student>().ReverseMap();
        CreateMap<StudentDto, Student>().ReverseMap();

        CreateMap<BaseAdministratorDto, Administrator>().ReverseMap();
        CreateMap<AdministratorDto, Administrator>().ReverseMap();

        CreateMap<BaseApplicationUserDto, ApplicationUser>().ReverseMap();
        CreateMap<ApplicationUserDto, ApplicationUser>().ReverseMap();
    }
}
