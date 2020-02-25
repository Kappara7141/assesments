using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EF_CodefirstDemo
{
    class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
