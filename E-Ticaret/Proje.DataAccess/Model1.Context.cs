﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eTicaretEntities : DbContext
    {
        public eTicaretEntities()
            : base("name=eTicaretEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AltKategori> AltKategori { get; set; }
        public virtual DbSet<AnaKategori> AnaKategori { get; set; }
        public virtual DbSet<Favoriler> Favoriler { get; set; }
        public virtual DbSet<GirisYapan> GirisYapan { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
    }
}