using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NgoThiLe_2410900046.Models;

public partial class NgothilestudentContext : DbContext
{
    public NgothilestudentContext()
    {
    }

    public NgothilestudentContext(DbContextOptions<NgothilestudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ngothilestudent> Ngothilestudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CR3U39K\\SQLEXPRESS;Database=NGOTHILEStudent;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ngothilestudent>(entity =>
        {
            entity.ToTable("NGOTHILEStudent");

            entity.Property(e => e.NgothileBirthday).HasColumnType("datetime");
            entity.Property(e => e.NgothileEmail)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.NgothileGender)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.NgothileName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.NgothilePhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
