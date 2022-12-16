using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace New_Project_Form_PRN211.Models
{
    public partial class FapContext : DbContext
    {
        public FapContext()
        {
        }

        public FapContext(DbContextOptions<FapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campus> Campuses { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseTimetable> CourseTimetables { get; set; } = null!;
        public virtual DbSet<ExamSchedule> ExamSchedules { get; set; } = null!;
        public virtual DbSet<Term> Terms { get; set; } = null!;
        public virtual DbSet<TuitionFeePerCourse> TuitionFeePerCourses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("ConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campus>(entity =>
            {
                entity.ToTable("Campus");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CampusName).HasMaxLength(50);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .HasColumnName("TermID");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Class_Term");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.SubjectCode);

                entity.ToTable("Course");

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectName).HasMaxLength(200);

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .HasColumnName("TermID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Course_Class");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Course_Term");
            });

            modelBuilder.Entity<CourseTimetable>(entity =>
            {
                entity.ToTable("CourseTimetable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttendanceStatus).HasMaxLength(50);

                entity.Property(e => e.Course).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.LectureComment).HasMaxLength(50);

                entity.Property(e => e.Lecturer).HasMaxLength(50);

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.CourseTimetables)
                    .HasForeignKey(d => d.Course)
                    .HasConstraintName("FK_AttendanceReport_Course");
            });

            modelBuilder.Entity<ExamSchedule>(entity =>
            {
                entity.ToTable("ExamSchedule");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateOfPublication).HasColumnType("datetime");

                entity.Property(e => e.Exam).HasMaxLength(50);

                entity.Property(e => e.ExamForm).HasMaxLength(100);

                entity.Property(e => e.RoomNo).HasMaxLength(50);

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.SubjectName).HasMaxLength(500);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.HasOne(d => d.SubjectCodeNavigation)
                    .WithMany(p => p.ExamSchedules)
                    .HasForeignKey(d => d.SubjectCode)
                    .HasConstraintName("FK_ExamSchedule_Course");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.ToTable("Term");

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .HasColumnName("TermID");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.Terms)
                    .HasForeignKey(d => d.CampusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Term_Campus");
            });

            modelBuilder.Entity<TuitionFeePerCourse>(entity =>
            {
                entity.HasKey(e => e.SubjectCode)
                    .HasName("PK_TuitionFeePerCourse_1");

                entity.ToTable("TuitionFeePerCourse");

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.Fee).HasColumnType("money");

                entity.Property(e => e.FeeInternational).HasColumnType("money");

                entity.Property(e => e.SubjectName).HasMaxLength(500);

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .HasColumnName("TermID");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.TuitionFeePerCourses)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_TuitionFeePerCourse_Term");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
