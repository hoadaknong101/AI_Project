namespace AI_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MON")]
    public partial class MON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MON()
        {
            CONGTHUCMONs = new HashSet<CONGTHUCMON>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        public int? TongNguyenLieu { get; set; }

        public double? Calo { get; set; }

        public int? NhomMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGTHUCMON> CONGTHUCMONs { get; set; }

        public virtual NHOMMON NHOMMON1 { get; set; }
    }
}
