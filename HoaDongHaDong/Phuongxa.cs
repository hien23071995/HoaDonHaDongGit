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
    
    public partial class Phuongxa
    {
        public Phuongxa()
        {
            this.Cumdancus = new HashSet<Cumdancu>();
            this.Khachhangs = new HashSet<Khachhang>();
            this.Toes = new HashSet<To>();
        }
    
        public int PhuongxaID { get; set; }
        public Nullable<int> QuanhuyenID { get; set; }
        public string Ten { get; set; }
    
        public virtual ICollection<Cumdancu> Cumdancus { get; set; }
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
        public virtual Quanhuyen Quanhuyen { get; set; }
        public virtual ICollection<To> Toes { get; set; }
    }
}
