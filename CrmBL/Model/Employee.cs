using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public Employee()
        {
            Tasks = new List<Task>();
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
