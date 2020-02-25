using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EF_Customerdemo
{
    class Customer
    {
       [Key]
       public int cid { get; set; }
        public string cname { get; set; }
        public Product clist { get; set; }
       
    }
}
