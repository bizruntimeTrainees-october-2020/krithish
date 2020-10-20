using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirst
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Dep { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
