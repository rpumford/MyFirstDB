using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDB.Models
{
    public class Beer
    {
        [Key]
        public string name { get; set; }
        public string style { get; set; }
        public List<Hops> hops { get; set; }
        public decimal rating { get; set; }
    }

    public class Hops
    {
        [Key]
        public string name { get; set; }
        public string flavor { get; set; }
    }
}
