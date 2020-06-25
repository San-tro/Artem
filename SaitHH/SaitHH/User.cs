using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class User
    {
        public User()
        {
            Record = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Record> Record { get; set; }
    }
}
