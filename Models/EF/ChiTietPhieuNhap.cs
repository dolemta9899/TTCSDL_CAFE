namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        public double? DonGia { get; set; }

        public int? SoLuong { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaNL { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
