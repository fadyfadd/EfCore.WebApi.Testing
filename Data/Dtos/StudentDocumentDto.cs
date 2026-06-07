using System;
using Data.Dtos;
using Microsoft.AspNetCore.Http;

namespace Data;

public class StudentDocumentDto : BaseStudentDocumentDto
{
    public StudentDto? Student {set; get;}

    public IFormFile File { get; set; } 


}
