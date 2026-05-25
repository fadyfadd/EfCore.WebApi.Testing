using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Dtos;

public class ApplicationUserDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = "";
    [EmailAddress]
    public String Email { set; get; } = "";
    public String PlainPassword { get; set; } = "";
    public StudentDto? Student { get; set; }
}
