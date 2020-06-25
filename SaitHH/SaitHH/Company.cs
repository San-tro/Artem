using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Company
    {
        public Company()
        {
            CompanyComment = new HashSet<CompanyComment>();
        }

        public string City { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Type { get; set; }
        public string Www { get; set; }
        public string Info { get; set; }

        public virtual Vacancy Vacancy { get; set; }
        public virtual ICollection<CompanyComment> CompanyComment { get; set; }
    }
}
