using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HitssDB.Classes;

namespace HitssDB
{
    public class Context : DbContext
    {
        public DbSet<Cat_Role> cat_Roles { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<EmployeeProject> employeeProjects { get; set; }
        public DbSet<Project> projects { get; set; }
    }
}
