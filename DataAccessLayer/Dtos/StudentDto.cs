using System;

namespace DataAccessLayer.Dtos;

public class StudentDto : BaseStudentDto
{
    public DateTime? EnrolledAt { get; set; }
   

}