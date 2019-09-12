using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } // тоже переопределить??
        public virtual ICollection<Project> Projects { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
