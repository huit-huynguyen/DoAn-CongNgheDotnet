//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangXeMay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.DsDonHang = new HashSet<DonHang>();
            this.DsPhieuSua = new HashSet<PhieuSua>();
        }
    
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DiaChiEmail { get; set; }
        public string SoDienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DsDonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuSua> DsPhieuSua { get; set; }
    }
}