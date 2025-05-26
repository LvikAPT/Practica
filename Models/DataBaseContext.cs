using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practica.Models;

public partial class DataBaseContext : DbContext
{
    public DataBaseContext()
    {
    }

    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<Diagnostic> Diagnostics { get; set; }

    public virtual DbSet<HistoryOrderDetail> HistoryOrderDetails { get; set; }

    public virtual DbSet<MaintenancePlan> MaintenancePlans { get; set; }

    public DbSet<RepairHistory> RepairHistories { get; set; }

    public virtual DbSet<RepairWorkDetail> RepairWorkDetails { get; set; }

    public virtual DbSet<RepairWorkType> RepairWorkTypes { get; set; }

    public DbSet<Technic> Technics { get; set; }

    public virtual DbSet<UsedPart> UsedParts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=DataBase; Username=postgres; Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("details_pkey");

            entity.ToTable("details");

            entity.HasIndex(e => e.ArticleNumber, "details_article_number_key").IsUnique();

            entity.Property(e => e.DetailId).HasColumnName("detail_id");
            entity.Property(e => e.ArticleNumber)
                .HasMaxLength(100)
                .HasColumnName("article_number");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.QuantityInStock)
                .HasDefaultValue(0)
                .HasColumnName("quantity_in_stock");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(10, 2)
                .HasColumnName("unit_price");
        });

        modelBuilder.Entity<Diagnostic>(entity =>
        {
            entity.HasKey(e => e.DiagnosticId).HasName("diagnostics_pkey");

            entity.ToTable("diagnostics");

            entity.Property(e => e.DiagnosticId).HasColumnName("diagnostic_id");
            entity.Property(e => e.DiagnosticDate).HasColumnName("diagnostic_date");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.TechnicId).HasColumnName("technic_id");
            entity.Property(e => e.Technician)
                .HasMaxLength(255)
                .HasColumnName("technician");

            entity.HasOne(d => d.Technic).WithMany(p => p.Diagnostics)
                .HasForeignKey(d => d.TechnicId)
                .HasConstraintName("diagnostics_technic_id_fkey");
        });

        modelBuilder.Entity<HistoryOrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("history_order_details_pkey");

            entity.ToTable("history_order_details");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.DetailId).HasColumnName("detail_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.QuantityOrdered).HasColumnName("quantity_ordered");
            entity.Property(e => e.Supplier)
                .HasMaxLength(255)
                .HasColumnName("supplier");
            entity.Property(e => e.TotalPrice)
                .HasPrecision(10, 2)
                .HasColumnName("total_price");

            entity.HasOne(d => d.Detail).WithMany(p => p.HistoryOrderDetails)
                .HasForeignKey(d => d.DetailId)
                .HasConstraintName("history_order_details_detail_id_fkey");
        });

        modelBuilder.Entity<MaintenancePlan>(entity =>
        {
            entity.HasKey(e => e.PlanId).HasName("maintenance_plans_pkey");

            entity.ToTable("maintenance_plans");

            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.Completed)
                .HasDefaultValue(false)
                .HasColumnName("completed");
            entity.Property(e => e.MaintenanceType)
                .HasMaxLength(255)
                .HasColumnName("maintenance_type");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PlannedDate).HasColumnName("planned_date");
            entity.Property(e => e.TechnicId).HasColumnName("technic_id");

            entity.HasOne(d => d.Technic).WithMany(p => p.MaintenancePlans)
                .HasForeignKey(d => d.TechnicId)
                .HasConstraintName("maintenance_plans_technic_id_fkey");
        });

        modelBuilder.Entity<RepairHistory>(entity =>
        {
            entity.HasKey(e => e.RepairId).HasName("repair_history_pkey");

            entity.ToTable("repair_history");

            entity.Property(e => e.RepairId).HasColumnName("repair_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RepairDate).HasColumnName("repair_date");
            entity.Property(e => e.TechnicId).HasColumnName("technic_id");

            entity.HasOne(d => d.Technic).WithMany(p => p.RepairHistories)
                .HasForeignKey(d => d.TechnicId)
                .HasConstraintName("repair_history_technic_id_fkey");
        });

        modelBuilder.Entity<RepairWorkDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_work_details_pkey");

            entity.ToTable("repair_work_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RepairId).HasColumnName("repair_id");
            entity.Property(e => e.RepairWorkTypeId).HasColumnName("repair_work_type_id");

            entity.HasOne(d => d.Repair).WithMany(p => p.RepairWorkDetails)
                .HasForeignKey(d => d.RepairId)
                .HasConstraintName("repair_work_details_repair_id_fkey");

            entity.HasOne(d => d.RepairWorkType).WithMany(p => p.RepairWorkDetails)
                .HasForeignKey(d => d.RepairWorkTypeId)
                .HasConstraintName("repair_work_details_repair_work_type_id_fkey");
        });

        modelBuilder.Entity<RepairWorkType>(entity =>
        {
            entity.HasKey(e => e.RepairWorkTypeId).HasName("repair_work_types_pkey");

            entity.ToTable("repair_work_types");

            entity.HasIndex(e => e.Name, "repair_work_types_name_key").IsUnique();

            entity.Property(e => e.RepairWorkTypeId).HasColumnName("repair_work_type_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Technic>(entity =>
        {
            entity.HasKey(e => e.TechnicId).HasName("technic_pkey");

            entity.ToTable("technic");

            entity.HasIndex(e => e.SerialNumber, "technic_serial_number_key").IsUnique();

            entity.Property(e => e.TechnicId).HasColumnName("technic_id");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .HasColumnName("serial_number");
        });

        modelBuilder.Entity<UsedPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("used_parts_pkey");

            entity.ToTable("used_parts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DetailId).HasColumnName("detail_id");
            entity.Property(e => e.QuantityUsed).HasColumnName("quantity_used");
            entity.Property(e => e.RepairId).HasColumnName("repair_id");

            entity.HasOne(d => d.Detail).WithMany(p => p.UsedParts)
                .HasForeignKey(d => d.DetailId)
                .HasConstraintName("used_parts_detail_id_fkey");

            entity.HasOne(d => d.Repair).WithMany(p => p.UsedParts)
                .HasForeignKey(d => d.RepairId)
                .HasConstraintName("used_parts_repair_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
