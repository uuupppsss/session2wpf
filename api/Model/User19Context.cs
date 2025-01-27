using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api.Model;

public partial class User19Context : DbContext
{
    public User19Context()
    {
    }

    public User19Context(DbContextOptions<User19Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<JobTitle> JobTitles { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<ResponciblePerson> ResponciblePersons { get; set; }

    public virtual DbSet<Subdivision> Subdivisions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=192.168.200.35; user=user19; password=70144; database=user19; trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.ToTable("calendar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Calendars)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_calendar_Employee");

            entity.HasOne(d => d.Event).WithMany(p => p.Calendars)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_calendar_Event");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ect)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.HelperId).HasColumnName("helper_id");
            entity.Property(e => e.Initials).HasMaxLength(255);
            entity.Property(e => e.JobTitleId).HasColumnName("jobTitle_id");
            entity.Property(e => e.MobilePhone).HasMaxLength(20);
            entity.Property(e => e.Office).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.SubdivisionId).HasColumnName("subdivision_id");
            entity.Property(e => e.SupervisorId).HasColumnName("supervisor_id");

            entity.HasOne(d => d.Helper).WithMany(p => p.InverseHelper)
                .HasForeignKey(d => d.HelperId)
                .HasConstraintName("FK_Employee_Employee");

            entity.HasOne(d => d.JobTitle).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobTitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_JobTitle");

            entity.HasOne(d => d.Subdivision).WithMany(p => p.Employees)
                .HasForeignKey(d => d.SubdivisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Subdivision");

            entity.HasOne(d => d.Supervisor).WithMany(p => p.InverseSupervisor)
                .HasForeignKey(d => d.SupervisorId)
                .HasConstraintName("FK_Employee_Employee1");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Type).WithMany(p => p.Events)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_Event_EventType");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.ToTable("EventType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobTitle>(entity =>
        {
            entity.ToTable("JobTitle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("Material");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.DateAccept).HasColumnName("Date_Accept");
            entity.Property(e => e.DateChange).HasColumnName("Date_Change");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Author).WithMany(p => p.Materials)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_Material_Employee");
        });

        modelBuilder.Entity<ResponciblePerson>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.ResponciblePeople)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_ResponciblePersons_Employee");

            entity.HasOne(d => d.Event).WithMany(p => p.ResponciblePeople)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_ResponciblePersons_Event");
        });

        modelBuilder.Entity<Subdivision>(entity =>
        {
            entity.ToTable("Subdivision");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SupervisorId).HasColumnName("supervisor_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
