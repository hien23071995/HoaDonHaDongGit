﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HoaDonHaDongEntities : DbContext
    {
        public HoaDonHaDongEntities()
            : base("name=HoaDonHaDongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Apgia> Apgias { get; set; }
        public DbSet<Captuyen> Captuyens { get; set; }
        public DbSet<Chinhanh> Chinhanhs { get; set; }
        public DbSet<Chisonuoctheotuyen> Chisonuoctheotuyens { get; set; }
        public DbSet<Chitietchisonuoctheotuyen> Chitietchisonuoctheotuyens { get; set; }
        public DbSet<Chitietcongno> Chitietcongnoes { get; set; }
        public DbSet<Chitiethoadonnuoc> Chitiethoadonnuocs { get; set; }
        public DbSet<Chucnangchuongtrinh> Chucnangchuongtrinhs { get; set; }
        public DbSet<Chucvu> Chucvus { get; set; }
        public DbSet<Congno> Congnoes { get; set; }
        public DbSet<Cumdancu> Cumdancus { get; set; }
        public DbSet<Dangnhap> Dangnhaps { get; set; }
        public DbSet<Donghotong> Donghotongs { get; set; }
        public DbSet<Hangsanxuat> Hangsanxuats { get; set; }
        public DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }
        public DbSet<Hoadonnuoc> Hoadonnuocs { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Kiemdinh> Kiemdinhs { get; set; }
        public DbSet<Lichsusudungct> Lichsusudungcts { get; set; }
        public DbSet<Loaiapgia> Loaiapgias { get; set; }
        public DbSet<Loaidongho> Loaidonghoes { get; set; }
        public DbSet<LoaiKH> LoaiKHs { get; set; }
        public DbSet<Loaikiemdinh> Loaikiemdinhs { get; set; }
        public DbSet<Nguoidung> Nguoidungs { get; set; }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Nhomchucnang> Nhomchucnangs { get; set; }
        public DbSet<Phongban> Phongbans { get; set; }
        public DbSet<Phuongxa> Phuongxas { get; set; }
        public DbSet<Quanhuyen> Quanhuyens { get; set; }
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<To> Toes { get; set; }
        public DbSet<Tuyenkhachhang> Tuyenkhachhangs { get; set; }
        public DbSet<Tuyenong> Tuyenongs { get; set; }
        public DbSet<Tuyenongkythuat> Tuyenongkythuats { get; set; }
        public DbSet<Quyencuanguoidung> Quyencuanguoidungs { get; set; }
    }
}