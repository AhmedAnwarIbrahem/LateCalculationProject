﻿// <auto-generated />
using System;
using HrTasks.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrTasks.Model.Migrations
{
    [DbContext(typeof(HrTasksContext))]
    [Migration("20200831155346_New_Database")]
    partial class New_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrTasks.Model.Entites.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeNameAr");

                    b.Property<string>("EmployeeNameEn");

                    b.Property<DateTime>("JoinDate");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HrTasks.Model.Entites.EmployeeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DayDate");

                    b.Property<string>("Description");

                    b.Property<int>("EmployeeId");

                    b.Property<TimeSpan?>("LogIn");

                    b.Property<TimeSpan?>("LogOut");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLogs");
                });

            modelBuilder.Entity("HrTasks.Model.Entites.EmployeeLog", b =>
                {
                    b.HasOne("HrTasks.Model.Entites.Employee", "Employees")
                        .WithMany("EmployeeLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}