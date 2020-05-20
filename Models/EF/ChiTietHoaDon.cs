namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaMon { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
