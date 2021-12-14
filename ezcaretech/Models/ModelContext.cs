using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ezcaretech.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<CommonCode> CommonCodes { get; set; }
        public virtual DbSet<MediProcedure> MediProcedures { get; set; }
        public virtual DbSet<MediStaff> MediStaffs { get; set; }
        public virtual DbSet<MediStaffLogin> MediStaffLogins { get; set; }
        public virtual DbSet<NameOfDisease> NameOfDiseases { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PushAlarm> PushAlarms { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<Waiting> Waitings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=admin;Password=c4iloonshot!;Data Source=database-1.cgpw1y90uonr.ap-northeast-2.rds.amazonaws.com:1521/ORCL;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ADMIN");

            modelBuilder.Entity<CommonCode>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("SYS_C005169");

                entity.ToTable("COMMON_CODE");

                entity.Property(e => e.Identifier)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDENTIFIER");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.DeleteOrNot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_OR_NOT")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.RegisDate)
                    .HasPrecision(6)
                    .HasColumnName("REGIS_DATE");
            });

            modelBuilder.Entity<MediProcedure>(entity =>
            {
                entity.ToTable("MEDI_PROCEDURE");

                entity.Property(e => e.MediProcedureId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MEDI_PROCEDURE_ID");

                entity.Property(e => e.CreatetionDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATETION_DATE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteOrNot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_OR_NOT")
                    .IsFixedLength(true);

                entity.Property(e => e.RevisedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISED_DATE");

                entity.Property(e => e.TreatmentAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TREATMENT_AMOUNT");
            });

            modelBuilder.Entity<MediStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("SYS_C005177");

                entity.ToTable("MEDI_STAFF");

                entity.Property(e => e.StaffId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STAFF_ID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.MediSubject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MEDI_SUBJECT");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUM");

                entity.Property(e => e.Position)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POSITION")
                    .IsFixedLength(true);

                entity.Property(e => e.StaffEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_EMAIL");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_NAME");
            });

            modelBuilder.Entity<MediStaffLogin>(entity =>
            {
                entity.HasKey(e => e.StaffLoginId)
                    .HasName("SYS_C005180");

                entity.ToTable("MEDI_STAFF_LOGIN");

                entity.Property(e => e.StaffLoginId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_LOGIN_ID");

                entity.Property(e => e.StaffId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STAFF_ID");

                entity.Property(e => e.StaffLoginPw)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_LOGIN_PW");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.MediStaffLogins)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005214");
            });

            modelBuilder.Entity<NameOfDisease>(entity =>
            {
                entity.HasKey(e => e.DiseaseId)
                    .HasName("SYS_C005185");

                entity.ToTable("NAME_OF_DISEASE");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISEASE_ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteOrNot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_OR_NOT")
                    .IsFixedLength(true);

                entity.Property(e => e.DiseaseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DISEASE_NAME");

                entity.Property(e => e.MediProcedureId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MEDI_PROCEDURE_ID");

                entity.Property(e => e.RevisedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISED_DATE");

                entity.HasOne(d => d.MediProcedure)
                    .WithMany(p => p.NameOfDiseases)
                    .HasForeignKey(d => d.MediProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005213");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("PATIENT");

                entity.Property(e => e.PatientId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.AgreeOfAlarm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AGREE_OF_ALARM")
                    .IsFixedLength(true);

                entity.Property(e => e.Dob)
                    .HasColumnType("DATE")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PATIENT_NAME");

                entity.Property(e => e.PatientStatusVal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PATIENT_STATUS_VAL")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNum)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUM");

                entity.Property(e => e.RegistDate)
                    .HasPrecision(6)
                    .HasColumnName("REGIST_DATE");

                entity.Property(e => e.ResidentRegistNum)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENT_REGIST_NUM");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("PAYMENT");

                entity.Property(e => e.PaymentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAYMENT_ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteOrNot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_OR_NOT")
                    .IsFixedLength(true);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISCOUNT_AMOUNT");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISEASE_ID");

                entity.Property(e => e.FinPaymentAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIN_PAYMENT_AMOUNT");

                entity.Property(e => e.OriginAmount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORIGIN_AMOUNT");

                entity.Property(e => e.PatientId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.PaymentDate)
                    .HasPrecision(6)
                    .HasColumnName("PAYMENT_DATE");

                entity.Property(e => e.RevisedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISED_DATE");

                entity.Property(e => e.TreatId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TREAT_ID");

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.DiseaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005216");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005218");

                entity.HasOne(d => d.Treat)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.TreatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005221");
            });

            modelBuilder.Entity<PushAlarm>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("SYS_C005201");

                entity.ToTable("PUSH_ALARM");

                entity.Property(e => e.AlarmId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALARM_ID");

                entity.Property(e => e.AlaramContent)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ALARAM_CONTENT");

                entity.Property(e => e.AlarmClassification)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALARM_CLASSIFICATION")
                    .IsFixedLength(true);

                entity.Property(e => e.TransmissionDate)
                    .HasPrecision(6)
                    .HasColumnName("TRANSMISSION_DATE");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.HasKey(e => e.TreatId)
                    .HasName("SYS_C005208");

                entity.ToTable("TREATMENT");

                entity.Property(e => e.TreatId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TREAT_ID");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISEASE_ID");

                entity.Property(e => e.PatientId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.Prescription)
                    .HasColumnType("CLOB")
                    .HasColumnName("PRESCRIPTION");

                entity.Property(e => e.StaffId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STAFF_ID");

                entity.Property(e => e.TreatDate)
                    .HasPrecision(6)
                    .HasColumnName("TREAT_DATE");

                entity.Property(e => e.TreatDetails)
                    .IsRequired()
                    .HasColumnType("CLOB")
                    .HasColumnName("TREAT_DETAILS");

                entity.Property(e => e.TreatStatusVal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TREAT_STATUS__VAL")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.DiseaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005217");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005219");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005215");
            });

            modelBuilder.Entity<Waiting>(entity =>
            {
                entity.HasKey(e => e.WatingId)
                    .HasName("SYS_C005212");

                entity.ToTable("WAITING");

                entity.Property(e => e.WatingId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WATING_ID");

                entity.Property(e => e.PatientId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.RequestToWait)
                    .HasPrecision(6)
                    .HasColumnName("REQUEST_TO_WAIT");

                entity.Property(e => e.Requirements)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REQUIREMENTS");

                entity.Property(e => e.ReserveStatusVal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RESERVE_STATUS_VAL")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Waitings)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C005220");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
