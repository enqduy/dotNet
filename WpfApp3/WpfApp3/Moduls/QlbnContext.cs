using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp3.Moduls;

public partial class QlbnContext : DbContext
{
    public QlbnContext()
    {
    }

    public QlbnContext(DbContextOptions<QlbnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BenhNhan> BenhNhans { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PILS0OR\\SQLEXPRESS;Initial Catalog=QLBN;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BenhNhan>(entity =>
        {
            entity.HasKey(e => e.MaBn).HasName("PK__BenhNhan__272475AD84C369BF");

            entity.ToTable("BenhNhan");

            entity.Property(e => e.MaBn)
                .ValueGeneratedNever()
                .HasColumnName("MaBN");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoTen)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.BenhNhans)
                .HasForeignKey(d => d.MaKhoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BenhNhan__MaKhoa__412EB0B6");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__Khoa__653904051034B50C");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKhoa).ValueGeneratedNever();
            entity.Property(e => e.TenKhoa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
