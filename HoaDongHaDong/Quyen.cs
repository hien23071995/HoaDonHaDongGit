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
    
    public partial class Quyen
    {
        public Quyen()
        {
            this.Quyencuanguoidungs = new HashSet<Quyencuanguoidung>();
        }
    
        public int QuyenID { get; set; }
        public Nullable<int> ChucnangID { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> Quyenxem { get; set; }
        public Nullable<bool> Quyenthem { get; set; }
        public Nullable<bool> Quyensua { get; set; }
        public Nullable<bool> Quyenxoa { get; set; }
    
        public virtual Chucnangchuongtrinh Chucnangchuongtrinh { get; set; }
        public virtual ICollection<Quyencuanguoidung> Quyencuanguoidungs { get; set; }
    }
}