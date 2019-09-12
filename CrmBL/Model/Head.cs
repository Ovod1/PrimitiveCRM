using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Head
    {
        public int HeadId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
