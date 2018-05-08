using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public class WorkShiftModels
    {
        // Arbetspass
        public int WorkShiftId { get; set; }
        public string WorkShiftType { get; set; }

        public List<ShiftModels> ShiftList { get; set; } //ShitList?
        
    }
}