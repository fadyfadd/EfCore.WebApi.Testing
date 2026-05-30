using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Dtos
{
    public class BaseAdministratorDto
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? EnrolledAt { get; set; }

    }
}
