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
    
    public partial class Cumdancu
    {
        public Cumdancu()
        {
            this.Khachhangs = new HashSet<Khachhang>();
            this.Tuyenkhachhangs = new HashSet<Tuyenkhachhang>();
        }
    
        public int CumdancuID { get; set; }
        public Nullable<int> PhuongxaID { get; set; }
        public string Ten { get; set; }
    
        public virtual Phuongxa Phuongxa { get; set; }
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
        public virtual ICollection<Tuyenkhachhang> Tuyenkhachhangs { get; set; }
    }
}
