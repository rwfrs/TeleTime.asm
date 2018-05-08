using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public class DayModels
    {
        // Dag
        public string Date { get; set; }  //ID?
        public bool Workday { get; set; }

        List<WorkShiftModels> WorkShiftList { get; set; }
    }
}