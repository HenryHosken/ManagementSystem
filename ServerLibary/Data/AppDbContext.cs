using BaseLibary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibary.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> employees {  get; set; }
        public DbSet<GeneralDepartment> generalDepartments { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Town> towns { get; set; }  
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<SystemRole> systemRoles { get; set; }
        public DbSet<UserRole> userRoles { get; set; }

    }
}
