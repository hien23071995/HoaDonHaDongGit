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
    
    public partial class Chinhanh
    {
        public Chinhanh()
        {
            this.Phongbans = new HashSet<Phongban>();
            this.Toes = new HashSet<To>();
        }
    
        public int ChinhanhID { get; set; }
        public Nullable<int> QuanhuyenID { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
    
        public virtual Quanhuyen Quanhuyen { get; set; }
        public virtual ICollection<Phongban> Phongbans { get; set; }
        public virtual ICollection<To> Toes { get; set; }
    }
}
