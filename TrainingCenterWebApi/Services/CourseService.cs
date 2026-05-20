using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Dtos;
using Microsoft.EntityFrameworkCore;

namespace TrainingCenterWebApi.Services
{
    public class CourseService
    {
        MainDataBaseContext dataContext;
        IMapper mapper;

        public CourseService(MainDataBaseContext dataContext , IMapper mapper) { 
            this.dataContext = dataContext;
            this.mapper = mapper; 
        }

        public async Task<List<CourseDto>> GetAllCourses() {
            var courses = await dataContext.Courses.Include(a=>a.CourseCategory) .ToListAsync();
            var res = mapper.Map<List<CourseDto>>(courses);
            return res; 
        }
    }
}
