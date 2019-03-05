using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.Database.Models
{
    public class RecordPresentation : EntityBase<int>
    {
        public string PathToDirectory { get; set; }
        public string CurrentDate { get; set; }
        public string CurrentTime { get; set; }
        
    }
}
