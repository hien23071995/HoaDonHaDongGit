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
    
    public partial class Hoadonnuoc
    {
        public Hoadonnuoc()
        {
            this.Chitietcongnoes = new HashSet<Chitietcongno>();
            this.Chitiethoadonnuocs = new HashSet<Chitiethoadonnuoc>();
        }
    
        public int HoadonnuocID { get; set; }
        public Nullable<System.DateTime> Ngayhoadown { get; set; }
        public Nullable<int> KhachhangID { get; set; }
        public Nullable<int> NhanvienID { get; set; }
        public Nullable<int> Sohoadon { get; set; }
        public string Kyhieu { get; set; }
        public Nullable<int> Tongsotieuthu { get; set; }
        public Nullable<bool> Trangthaithu { get; set; }
        public Nullable<bool> Trangthaiin { get; set; }
    
        public virtual ICollection<Chitietcongno> Chitietcongnoes { get; set; }
        public virtual ICollection<Chitiethoadonnuoc> Chitiethoadonnuocs { get; set; }
        public virtual Khachhang Khachhang { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}
