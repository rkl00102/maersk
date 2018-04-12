using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int CargoSize { get; set; }
        public int Container { get; set; }
        public string Customer { get; set; }
        public int ScheduleID { get; set; }
        public virtual Schedule Schedule { get; set; }

    }
}
