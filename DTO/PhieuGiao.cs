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
    
    public partial class PhieuGiao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuGiao()
        {
            this.PhieuGiaoChiTiets = new HashSet<PhieuGiaoChiTiet>();
        }
    
        public int MaPhieuGiao { get; set; }
        public Nullable<int> MaNv { get; set; }
        public Nullable<int> MaKh { get; set; }
        public Nullable<int> MaPhieuHd { get; set; }
        public string DiaChiGiao { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
    
        public virtual Kh Kh { get; set; }
        public virtual Nv Nv { get; set; }
        public virtual PhieuHd PhieuHd { get; set; }
        public virtual PhieuHd PhieuHd1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGiaoChiTiet> PhieuGiaoChiTiets { get; set; }
    }
}
