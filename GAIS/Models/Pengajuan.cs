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
    
    public partial class Pengajuan
    {
        public string ID_Pengajuan { get; set; }
        public string ID_GA { get; set; }
        public Nullable<System.DateTime> Tgl_Pengajuan { get; set; }
        public Nullable<int> TotalHarga { get; set; }
        public Nullable<int> StatusPengajuan { get; set; }
        public Nullable<int> SudahDibayar { get; set; }
        public string StatusFinal { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
        public string ModifiedBy { get; set; }
    }
}
