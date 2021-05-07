using FacultyBoLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyDaLayer
{
    public class FacultyContext : DbContext
    {
       
        public DbSet<Faculty> Faculties { get; set; }
    }
}
