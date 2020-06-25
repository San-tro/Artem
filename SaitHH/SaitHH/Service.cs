using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Service
    {
        public Service()
        {
            RecordService = new HashSet<RecordService>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CarcaseId { get; set; }
        public DateTimeOffset? Time { get; set; }
        public int? Cost { get; set; }

        public virtual Carcase Carcase { get; set; }
        public virtual ICollection<RecordService> RecordService { get; set; }
    }
}
