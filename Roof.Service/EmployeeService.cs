using Roof.Core.Context;
using Roof.Core.Models.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Roof.Service
{
    public class EmployeeService
    {
        public Employee GetEmployee(Guid guid)
        {
#if DEBUG
            return new Employee { Name = "seçkin", LastName = "çelik", EmployeeId = Guid.NewGuid() };            
#endif
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Employee.Where(x => x.EmployeeId == guid).SingleOrDefault();
            }
        }
    }
}
