//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_ExaminationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentTable()
        {
            this.ExamTables = new HashSet<ExamTable>();
        }
    
        public int Stdrollno { get; set; }
        public string stdname { get; set; }
        public string schlname { get; set; }
        public int schlId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTable> ExamTables { get; set; }
        public virtual SubjectTable SubjectTable { get; set; }
    }
}