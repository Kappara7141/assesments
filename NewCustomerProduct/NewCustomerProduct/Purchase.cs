using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewCustomerProduct
{
    class Purchase
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime orderDate { get; set; }
        public int Cid { get; set; }
        public int Pid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
