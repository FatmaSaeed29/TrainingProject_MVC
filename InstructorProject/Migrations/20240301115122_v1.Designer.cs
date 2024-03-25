﻿// <auto-generated />
using System;
using InstructorProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InstructorProject.Migrations
{
    [DbContext(typeof(itiContext))]
    [Migration("20240301115122_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InstructorProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.Property<int>("minDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("dept_id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MVC",
                            degree = 100,
                            dept_id = 1,
                            minDegree = 60
                        },
                        new
                        {
                            Id = 2,
                            Name = "JavaScript",
                            degree = 100,
                            dept_id = 1,
                            minDegree = 60
                        },
                        new
                        {
                            Id = 3,
                            Name = "XML",
                            degree = 100,
                            dept_id = 2,
                            minDegree = 60
                        },
                        new
                        {
                            Id = 4,
                            Name = "Linq",
                            degree = 100,
                            dept_id = 2,
                            minDegree = 60
                        },
                        new
                        {
                            Id = 5,
                            Name = "Entity Framework",
                            degree = 100,
                            dept_id = 3,
                            minDegree = 60
                        });
                });

            modelBuilder.Entity("InstructorProject.Models.CrsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Degree")
                        .HasColumnType("int");

                    b.Property<int?>("crs_id")
                        .HasColumnType("int");

                    b.Property<int?>("trainee_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("crs_id");

                    b.HasIndex("trainee_id");

                    b.ToTable("CrsResult");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Degree = 87,
                            crs_id = 1,
                            trainee_id = 1
                        },
                        new
                        {
                            Id = 2,
                            Degree = 57,
                            crs_id = 2,
                            trainee_id = 2
                        },
                        new
                        {
                            Id = 3,
                            Degree = 50,
                            crs_id = 3,
                            trainee_id = 3
                        },
                        new
                        {
                            Id = 4,
                            Degree = 98,
                            crs_id = 4,
                            trainee_id = 4
                        },
                        new
                        {
                            Id = 5,
                            Degree = 45,
                            crs_id = 5,
                            trainee_id = 5
                        },
                        new
                        {
                            Id = 6,
                            Degree = 66,
                            crs_id = 3,
                            trainee_id = 2
                        });
                });

            modelBuilder.Entity("InstructorProject.Models.Department", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Manager = "Adam Mohammed",
                            Name = "PD"
                        },
                        new
                        {
                            Id = 2,
                            Manager = "Osama Saeed",
                            Name = "OS"
                        },
                        new
                        {
                            Id = 3,
                            Manager = "Tasneem Ahmed",
                            Name = "SD"
                        });
                });

            modelBuilder.Entity("InstructorProject.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("crs_id")
                        .HasColumnType("int");

                    b.Property<int?>("dept_id")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("crs_id");

                    b.HasIndex("dept_id");

                    b.ToTable("Instructor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "Cairo",
                            crs_id = 1,
                            dept_id = 1,
                            imageUrl = "female.png",
                            name = "Rahaf Mohammed",
                            salary = 25000
                        },
                        new
                        {
                            Id = 2,
                            address = "Alexx",
                            crs_id = 2,
                            dept_id = 2,
                            imageUrl = "female.png",
                            name = "Fatma Saeed",
                            salary = 25000
                        },
                        new
                        {
                            Id = 3,
                            address = "Menofia",
                            crs_id = 3,
                            dept_id = 3,
                            imageUrl = "male.png",
                            name = "Mousa Ahmed",
                            salary = 25000
                        },
                        new
                        {
                            Id = 4,
                            address = "Shebin ElKom",
                            crs_id = 1,
                            dept_id = 1,
                            imageUrl = "male.png",
                            name = "Belal Saeed",
                            salary = 25000
                        },
                        new
                        {
                            Id = 5,
                            address = "Cairo",
                            crs_id = 2,
                            dept_id = 2,
                            imageUrl = "female.png",
                            name = "Habiba Ashraf",
                            salary = 25000
                        },
                        new
                        {
                            Id = 6,
                            address = "Menia",
                            crs_id = 3,
                            dept_id = 2,
                            imageUrl = "female.png",
                            name = "Eman Fawzy",
                            salary = 25000
                        },
                        new
                        {
                            Id = 7,
                            address = "Cairo",
                            crs_id = 1,
                            dept_id = 2,
                            imageUrl = "female.png",
                            name = "Asmaa Mohammed",
                            salary = 25000
                        },
                        new
                        {
                            Id = 8,
                            address = "Cairo",
                            crs_id = 2,
                            dept_id = 1,
                            imageUrl = "male.png",
                            name = "Amr Ali",
                            salary = 25000
                        });
                });

            modelBuilder.Entity("InstructorProject.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dept_id")
                        .HasColumnType("int");

                    b.Property<int?>("grade")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("dept_id");

                    b.ToTable("Trainee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cairo",
                            Name = "Fatma Koura",
                            dept_id = 1,
                            grade = 98,
                            imageUrl = "female.ong"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cairo",
                            Name = "Ali Mohammed",
                            dept_id = 2,
                            grade = 98,
                            imageUrl = "male.ong"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cairo",
                            Name = "Doaa Bassam",
                            dept_id = 3,
                            grade = 98,
                            imageUrl = "female.ong"
                        });
                });

            modelBuilder.Entity("InstructorProject.Models.Course", b =>
                {
                    b.HasOne("InstructorProject.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstructorProject.Models.CrsResult", b =>
                {
                    b.HasOne("InstructorProject.Models.Course", "Course")
                        .WithMany("crsResults")
                        .HasForeignKey("crs_id");

                    b.HasOne("InstructorProject.Models.Trainee", "Trainee")
                        .WithMany("crsResults")
                        .HasForeignKey("trainee_id");

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("InstructorProject.Models.Instructor", b =>
                {
                    b.HasOne("InstructorProject.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("crs_id");

                    b.HasOne("InstructorProject.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("dept_id");

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstructorProject.Models.Trainee", b =>
                {
                    b.HasOne("InstructorProject.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("dept_id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstructorProject.Models.Course", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("crsResults");
                });

            modelBuilder.Entity("InstructorProject.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("InstructorProject.Models.Trainee", b =>
                {
                    b.Navigation("crsResults");
                });
#pragma warning restore 612, 618
        }
    }
}
