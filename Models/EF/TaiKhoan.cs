namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string MaTK { get; set; }

        [Required]
        [StringLength(250)]
        public string UsernameTK { get; set; }

        [Required]
        [StringLength(250)]
        public string PasswordTK { get; set; }
    }
}
