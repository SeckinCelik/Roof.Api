using System;
using System.Collections.Generic;
using System.Text;

namespace Roof.Core.Models.Entity
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }        
    }
}
