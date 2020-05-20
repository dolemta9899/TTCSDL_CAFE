namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMon")]
    public partial class LoaiMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiMon()
        {
            Mons = new HashSet<Mon>();
        }

        [Key]
        [StringLength(50)]
        public string MaLoaiMon { get; set; }

        [Required]
        [StringLength(250)]
        public string TenLoaiMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mon> Mons { get; set; }
    }
}
