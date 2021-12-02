using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeForm.Models
{
    public class Employee
    {
        public int EmployeeId { get; set;  }
        public string EmployeeName { get; set;  }
        public string Gender { get; set;  }
        public string Department { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOdJoining { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string PhotoFileName { get; set; }
    }
}
