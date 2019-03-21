﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HitssDB.Classes
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get;  set; }
        public virtual Client Client { get; set; }
        public int estado { get; set; }

    }
}
