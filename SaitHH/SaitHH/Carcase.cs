using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Carcase
    {
        public Carcase()
        {
            Service = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string CarcaseType { get; set; }

        public virtual ICollection<Service> Service { get; set; }
    }
}
