namespace AI_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGTHUCMON")]
    public partial class CONGTHUCMON
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNL { get; set; }

        public int LieuLuong { get; set; }

        public virtual MON MON { get; set; }

        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
    }
}
