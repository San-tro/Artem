using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Users
    {
        public Users()
        {
            CompanyComment = new HashSet<CompanyComment>();
            Resume = new HashSet<Resume>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<CompanyComment> CompanyComment { get; set; }
        public virtual ICollection<Resume> Resume { get; set; }
    }
}
