using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Dtos;

public class ApplicationUserDto : BaseApplicationUserDto
{
    public StudentDto? Student { get; set; }
}
