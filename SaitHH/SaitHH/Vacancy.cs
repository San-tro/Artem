using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Vacancy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Money { get; set; }
        public string Addres { get; set; }
        public bool? Experience { get; set; }
        public string Employment { get; set; }
        public string Responsibility { get; set; }
        public string Conditions { get; set; }
        public DateTime? Date { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Comment { get; set; }
        public string Demand { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company IdNavigation { get; set; }
    }
}
