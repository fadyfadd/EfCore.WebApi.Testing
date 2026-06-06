using System;

namespace Data.Dtos;

public class BaseStudentDocumentDto
{
    public int? Id { get; set; }
    public string? DocumentName { get; set; }
    public string? DocumentUrl { get; set; }
    public DateTime? UploadedAt { get; set; }
    public int? StudentId { set; get; }
}
