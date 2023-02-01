using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class SMTITeacherCourseManagementDBContext : DbContext
    {
        public SMTITeacherCourseManagementDBContext()
        {
        }

        public SMTITeacherCourseManagementDBContext(DbContextOptions<SMTITeacherCourseManagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CourseAssignments> CourseAssignments { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ERASTE-THE-BREA\\SQLEXPRESS;Initial Catalog=SMTI Teacher-Course ManagementDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseAssignments>(entity =>
            {
                entity.HasKey(e => e.AssignId)
                    .HasName("PK_AssignCourses");

                entity.ToTable("CourseAssignments ");

                entity.Property(e => e.CourseNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.CourseNumberNavigation)
                    .WithMany(p => p.CourseAssignments)
                    .HasForeignKey(d => d.CourseNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignCourses_Courses");

                entity.HasOne(d => d.EmployeeNumberNavigation)
                    .WithMany(p => p.CourseAssignments)
                    .HasForeignKey(d => d.EmployeeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignCourses_AssignCourses");

                entity.HasOne(d => d.GroupNumberNavigation)
                    .WithMany(p => p.CourseAssignments)
                    .HasForeignKey(d => d.GroupNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignCourses_Groups");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseNumber);

                entity.Property(e => e.CourseNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CourseTitle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupNumber);

                entity.Property(e => e.GroupNumber).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Users)
                    .HasForeignKey<Users>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Employees");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
