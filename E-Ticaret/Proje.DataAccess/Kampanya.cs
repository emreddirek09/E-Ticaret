//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Kampanya
    {
        public int id { get; set; }
        public string ürünAdi { get; set; }
        public Nullable<int> fiyat { get; set; }
        public string beden { get; set; }
        public Nullable<int> adet { get; set; }
        public string ürünaciklama { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string Resim1 { get; set; }
        public Nullable<int> KampanyaKatFK { get; set; }
    
        public virtual KampanyaKategori KampanyaKategori1 { get; set; }
    }
}
