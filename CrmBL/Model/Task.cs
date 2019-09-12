using System;
using System.Collections.Generic;
namespace CrmBL.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime ControlTime { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Task()
        {
            Employees = new List<Employee>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
