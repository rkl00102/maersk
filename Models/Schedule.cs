using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime DepartTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DepartLocation { get; set; }
        public string ArriveLocation { get; set; }
        public int VesselID { get; set; }
        public virtual Vessel Vessel { get; set; }

        public string Description
        {

            get => $"{DepartTime}: {DepartLocation} -> {ArriveLocation}";
        }
    }
}
