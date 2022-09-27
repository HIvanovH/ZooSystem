using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class EventsType
    {
        [Key]
        public int IdType { get; set; }
        public string Type { get; set; }

    }
}
