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
    
    public partial class LoaiKH
    {
        public LoaiKH()
        {
            this.Khachhangs = new HashSet<Khachhang>();
        }
    
        public int LoaiKHID { get; set; }
        public string Ten { get; set; }
        public Nullable<int> Phibaovemoitruong { get; set; }
    
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}