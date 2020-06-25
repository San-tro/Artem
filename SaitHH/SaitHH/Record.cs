using System;
using System.Collections.Generic;

namespace SaitHH
{
    public partial class Record
    {
        public Record()
        {
            RecordService = new HashSet<RecordService>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public string CarNuber { get; set; }
        public int? FinalCost { get; set; }
        public DateTime? Date { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<RecordService> RecordService { get; set; }
    }
}
