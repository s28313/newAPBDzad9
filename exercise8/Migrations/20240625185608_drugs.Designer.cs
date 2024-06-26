﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kol2APBD.Contexts;

#nullable disable

namespace kol2APBD.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240625185608_drugs")]
    partial class drugs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kol2APBD.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDoctor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<string>("DoctorEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("DoctorFirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("DoctorLastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorEmail = "jp2@gmail.com",
                            DoctorFirstName = "Papaj",
                            DoctorLastName = "Pawlikowski"
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorEmail = "jan.kowalski@onet.pl",
                            DoctorFirstName = "Jan",
                            DoctorLastName = "Kowalski"
                        });
                });

            modelBuilder.Entity("kol2APBD.Models.Medicament", b =>
                {
                    b.Property<int>("MedicamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMedicament");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicamentId"));

                    b.Property<string>("MedicamentDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Description");

                    b.Property<string>("MedicamentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("MedicamentType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Type");

                    b.HasKey("MedicamentId");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            MedicamentId = 1,
                            MedicamentDescription = "Na wszystko",
                            MedicamentName = "Amol",
                            MedicamentType = "Nie zaszkodzi a może pomoże"
                        },
                        new
                        {
                            MedicamentId = 2,
                            MedicamentDescription = "Narkotyczny sen wywołuje",
                            MedicamentName = "Fentanyl",
                            MedicamentType = "Silny opioid"
                        });
                });

            modelBuilder.Entity("kol2APBD.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPatient");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<DateTime>("PatientBirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("PatientFirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("PatientLastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            PatientBirthDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientFirstName = "Marek",
                            PatientLastName = "Nowak"
                        },
                        new
                        {
                            PatientId = 2,
                            PatientBirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientFirstName = "Teodor",
                            PatientLastName = "Szeroki"
                        });
                });

            modelBuilder.Entity("kol2APBD.Models.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPrescription");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("IdDoctor");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("IdPatient");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<DateTime>("PrescriptionDueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DueDate");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            PrescriptionId = 1,
                            DoctorId = 2,
                            PatientId = 1,
                            PrescriptionDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrescriptionDueDate = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PrescriptionId = 2,
                            DoctorId = 2,
                            PatientId = 1,
                            PrescriptionDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrescriptionDueDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("kol2APBD.Models.Prescription", b =>
                {
                    b.HasOne("kol2APBD.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kol2APBD.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("kol2APBD.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("kol2APBD.Models.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
