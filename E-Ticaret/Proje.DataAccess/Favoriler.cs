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
    
    public partial class Favoriler
    {
        public int id { get; set; }
        public int LogidFK { get; set; }
        public int ürünFK { get; set; }
        public Nullable<int> Fav { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual GirisYapan GirisYapan { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
