using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class CompanyComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime? Data { get; set; }
        public string Rating { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Users User { get; set; }
    }
}
