using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class RecordService
    {
        public int Id { get; set; }
        public int? RecordId { get; set; }
        public int? ServiceId { get; set; }

        public virtual Record Record { get; set; }
        public virtual Service Service { get; set; }
    }
}
