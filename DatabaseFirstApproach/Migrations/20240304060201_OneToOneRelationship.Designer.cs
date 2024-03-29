﻿// <auto-generated />
using DatabaseFirstApproach.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseFirstApproach.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240304060201_OneToOneRelationship")]
    partial class OneToOneRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DatabaseFirstApproach.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("EmpFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmpLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DatabaseFirstApproach.Models.EmployeeDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("DatabaseFirstApproach.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ManagerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("DatabaseFirstApproach.Models.EmployeeDetails", b =>
                {
                    b.HasOne("DatabaseFirstApproach.Models.Employee", "Employee")
                        .WithOne("EmployeeDetails")
                        .HasForeignKey("DatabaseFirstApproach.Models.EmployeeDetails", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseFirstApproach.Models.Employee", b =>
                {
                    b.Navigation("EmployeeDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
