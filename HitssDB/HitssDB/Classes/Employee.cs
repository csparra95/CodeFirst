using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HitssDB.Classes
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mail { get; set; }
        public string birthdate { get; set; }
        public string startdate { get; set; }
        public virtual Company Company { get; set; }
        public int estado { get; set; }
    }
}
