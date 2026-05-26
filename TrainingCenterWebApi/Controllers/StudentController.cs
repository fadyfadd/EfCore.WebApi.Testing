using System;
using TrainingCenterWebApi.Services;

namespace TrainingCenterWebApi.Controllers;

public class StudentController
{
    private readonly StudentService studentService;

    public StudentController(StudentService studentService)
    {
        this.studentService = studentService;
    }
}
