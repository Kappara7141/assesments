﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_Customerdemo
{
    class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        
    }
}
