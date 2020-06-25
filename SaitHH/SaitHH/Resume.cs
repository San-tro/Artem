using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string City { get; set; }
        public DateTime? Birth { get; set; }
        public string Gender { get; set; }
        public bool? Experience { get; set; }
        public string Nationality { get; set; }
        public string Knowledge { get; set; }
        public string Institution { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public DateTime? EndYear { get; set; }
        public string CareerObj { get; set; }
        public int? Salary { get; set; }
        public string Spec { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
