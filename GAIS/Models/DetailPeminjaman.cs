//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DetailPeminjaman
    {
        public string ID_Peminjaman { get; set; }
        public int ID_Barang { get; set; }
        public Nullable<int> Kuantitas { get; set; }
        public Nullable<int> HargaBarang { get; set; }
        public Nullable<int> Kondisi_Rusak { get; set; }
        public string Keterangan { get; set; }
    
        public virtual BarangPerusahaan BarangPerusahaan { get; set; }
        public virtual Peminjaman Peminjaman { get; set; }
    }
}
