using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AI_Project
{
    public partial class AIDB : DbContext
    {
        public AIDB()
            : base("name=AIDB")
        {
        }

        public virtual DbSet<CONGTHUCMON> CONGTHUCMONs { get; set; }
        public virtual DbSet<MON> MONs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHOMMON> NHOMMONs { get; set; }
        public virtual DbSet<NHOMNGUYENLIEU> NHOMNGUYENLIEUx { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONGTHUCMON>()
                .Property(e => e.TenMon)
                .IsFixedLength();

            modelBuilder.Entity<MON>()
                .Property(e => e.TenMon)
                .IsFixedLength();

            modelBuilder.Entity<MON>()
                .HasMany(e => e.CONGTHUCMONs)
                .WithRequired(e => e.MON)
                .HasForeignKey(e => e.IDMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUYENLIEU>()
                .Property(e => e.TenNL)
                .IsFixedLength();

            modelBuilder.Entity<NGUYENLIEU>()
                .HasMany(e => e.CONGTHUCMONs)
                .WithRequired(e => e.NGUYENLIEU)
                .HasForeignKey(e => e.IDNL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHOMMON>()
                .Property(e => e.TenNhom)
                .IsFixedLength();

            modelBuilder.Entity<NHOMMON>()
                .HasMany(e => e.MONs)
                .WithOptional(e => e.NHOMMON1)
                .HasForeignKey(e => e.NhomMon);

            modelBuilder.Entity<NHOMNGUYENLIEU>()
                .Property(e => e.TenNhom)
                .IsFixedLength();

            modelBuilder.Entity<NHOMNGUYENLIEU>()
                .HasMany(e => e.NGUYENLIEUx)
                .WithOptional(e => e.NHOMNGUYENLIEU)
                .HasForeignKey(e => e.NhomNL);
        }
    }
}
