//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoaDongHaDong
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chucvu
    {
        public Chucvu()
        {
            this.Nhanviens = new HashSet<Nhanvien>();
        }
    
        public int ChucvuID { get; set; }
        public string Ten { get; set; }
    
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}