using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
