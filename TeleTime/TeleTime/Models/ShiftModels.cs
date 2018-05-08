using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public class ShiftModels
    {
        // Pass
        public int ShiftId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public List<WorkCrewModels> WorkCrewList { get; set; }

    }
}