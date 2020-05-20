namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mon")]
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(250)]
        public string TenMon { get; set; }

        public double? DonGia { get; set; }

        public string HinhAnh { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(20)]
        public string Size { get; set; }

        [StringLength(50)]
        public string MaLoaiMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiMon LoaiMon { get; set; }
    }
}
