//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PhieuHd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuHd()
        {
            this.PhieuGiaos = new HashSet<PhieuGiao>();
            this.PhieuGiaos1 = new HashSet<PhieuGiao>();
            this.PhieuHdChiTiets = new HashSet<PhieuHdChiTiet>();
        }
    
        public int MaPhieuHd { get; set; }
        public Nullable<int> MaKh { get; set; }
        public Nullable<int> MaNv { get; set; }
        public Nullable<System.DateTime> NgayTaoHd { get; set; }
    
        public virtual Kh Kh { get; set; }
        public virtual Nv Nv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGiao> PhieuGiaos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGiao> PhieuGiaos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuHdChiTiet> PhieuHdChiTiets { get; set; }
    }
}
