using EmployeeBoLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDaLayer
{
    public class EmployeeDbContext:DbContext
    {
        public DbSet<Employee> EmployeeInfo { get; set; }
    }

}
