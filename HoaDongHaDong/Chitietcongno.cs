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
    
    public partial class Chitietcongno
    {
        public int ChitietcongnoID { get; set; }
        public Nullable<int> CongnoID { get; set; }
        public Nullable<int> HoadonnuocID { get; set; }
    
        public virtual Congno Congno { get; set; }
        public virtual Hoadonnuoc Hoadonnuoc { get; set; }
    }
}
