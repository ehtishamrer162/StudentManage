using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentManage.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classtbl> Classtbls { get; set; }

    public virtual DbSet<Enrolled> Enrolleds { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=Dbcontext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classtbl>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__Class__D830D477FB6836A8");

            entity.ToTable("Classtbl");

            entity.Property(e => e.CId).HasColumnName("cId");
            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.RoomNumber).HasColumnName("room_number");
        });

        modelBuilder.Entity<Enrolled>(entity =>
        {
            entity.HasKey(e => e.EId).HasName("PK__Enrolled__D830D477EA230CF5");

            entity.ToTable("Enrolled");

            entity.Property(e => e.EId).HasColumnName("eId");
            entity.Property(e => e.CId).HasColumnName("cId");
            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.Sid).HasColumnName("sid");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Fid).HasName("PK__Faculty__D9908D6426591294");

            entity.ToTable("Faculty");

            entity.Property(e => e.Fid).HasColumnName("fid");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Fname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fname");
            entity.Property(e => e.Standing)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("standing");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Students__DDDFDD36608208B2");

            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Smajor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("smajor");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
            entity.Property(e => e.Sstanding)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sstanding");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
