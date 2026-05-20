using System;
using AutoMapper;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mappers;

public class DefaultProfile : Profile
{
    public DefaultProfile()
    {
        CreateMap<Course, CourseDto>().ForMember(dest=>dest.Students, opt=>opt.Ignore()).ReverseMap();
        CreateMap<CourseCategory, CourseCategoryDto>().ForMember(dest=>dest.Courses, opt=>opt.Ignore()).ReverseMap();
        CreateMap<Student, StudentDto>().ForMember(dest=>dest.Courses, opt=>opt.Ignore()).ReverseMap();
    }
}
