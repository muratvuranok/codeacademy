using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class Personeller
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Status { get; set; }
    }
}
