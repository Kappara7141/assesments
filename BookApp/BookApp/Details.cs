﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Details
    {
        [Key]
        public int bid { get; set; }
        public int aid { get; set; }
        public virtual Book book { get; set; }
        public virtual Author author { get; set; }
    }
}
