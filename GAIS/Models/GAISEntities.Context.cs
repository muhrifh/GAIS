﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAIS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GAISEntities : DbContext
    {
        public GAISEntities()
            : base("name=GAISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BarangPerusahaan> BarangPerusahaans { get; set; }
        public virtual DbSet<BarangVendor> BarangVendors { get; set; }
        public virtual DbSet<DetailPeminjaman> DetailPeminjamen { get; set; }
        public virtual DbSet<DetailPengajuan> DetailPengajuans { get; set; }
        public virtual DbSet<JenisBank> JenisBanks { get; set; }
        public virtual DbSet<JenisBarang> JenisBarangs { get; set; }
        public virtual DbSet<Karyawan> Karyawans { get; set; }
        public virtual DbSet<Keranjang> Keranjangs { get; set; }
        public virtual DbSet<KeranjangPengajuan> KeranjangPengajuans { get; set; }
        public virtual DbSet<Peminjaman> Peminjamen { get; set; }
        public virtual DbSet<Pengajuan> Pengajuans { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<View_StatusPengajuan> View_StatusPengajuan { get; set; }
    }
}
