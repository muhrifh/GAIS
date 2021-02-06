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
    
    public partial class BarangPerusahaan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BarangPerusahaan()
        {
            this.DetailPeminjamen = new HashSet<DetailPeminjaman>();
            this.Keranjangs = new HashSet<Keranjang>();
        }
    
        public int ID { get; set; }
        public string NamaBarang { get; set; }
        public string Keterangan { get; set; }
        public Nullable<int> ID_JenisBarang { get; set; }
        public Nullable<int> ID_Seksi { get; set; }
        public Nullable<int> ID_Vendor { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<int> Harga { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> RowStatus { get; set; }
    
        public virtual JenisBarang JenisBarang { get; set; }
        public virtual Section Section { get; set; }
        public virtual Vendor Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPeminjaman> DetailPeminjamen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Keranjang> Keranjangs { get; set; }
    }
}
