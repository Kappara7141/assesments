//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DBApproach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int pid { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public Nullable<int> cid { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
