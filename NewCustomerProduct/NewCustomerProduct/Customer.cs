﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewCustomerProduct
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        public string Cname { get; set; }
        [MaxLength(250)]
        public string Cadress { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

