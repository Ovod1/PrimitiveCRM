using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int HeadId { get; set; }
        public virtual Head Head { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
