﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBH_WinDBContext : DbContext
    {
        public QLBH_WinDBContext()
            : base("name=QLBH_WinDBContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<Kh> Khs { get; set; }
        public virtual DbSet<Ncc> Nccs { get; set; }
        public virtual DbSet<Nv> Nvs { get; set; }
        public virtual DbSet<PhieuGiao> PhieuGiaos { get; set; }
        public virtual DbSet<PhieuGiaoChiTiet> PhieuGiaoChiTiets { get; set; }
        public virtual DbSet<PhieuHd> PhieuHds { get; set; }
        public virtual DbSet<PhieuHdChiTiet> PhieuHdChiTiets { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public virtual DbSet<Sp> Sps { get; set; }
        public virtual DbSet<SpLoai> SpLoais { get; set; }
        public virtual DbSet<SpNhom> SpNhoms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
