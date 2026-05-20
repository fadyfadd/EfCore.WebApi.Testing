using System;

namespace DataAccessLayer.Dtos;

    public class CourseDto
    
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseCategoryId { get; set; }
        public CourseCategoryDto CourseCategory { get; set; }
        public ICollection<StudentDto> Students { get; set; } = new HashSet<StudentDto>();

    }
