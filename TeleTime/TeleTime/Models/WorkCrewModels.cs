using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTime.Models
{
    public class WorkCrewModels
    {
        // Bemanning
        public int WorkcCrewId { get; set; }  // Annat sätt?
        public string Role { get; set; }
        public int Amount { get; set; }
        
        // Lista kopplat till användare i databasen?
    }
}