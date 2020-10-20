using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace EFCodeFirst
{
    class CodeFirstContext:DbContext

    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
