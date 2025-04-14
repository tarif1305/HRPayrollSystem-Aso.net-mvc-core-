﻿// <auto-generated />
using System;
using HRPayrollSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRPayrollSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250413205654_add")]
    partial class add
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRPayrollSystem.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<TimeSpan>("CheckIn")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("CheckOut")
                        .HasColumnType("time");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLate")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.HasKey("AttendanceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            AttendanceId = 1,
                            CheckIn = new TimeSpan(0, 8, 30, 0, 0),
                            CheckOut = new TimeSpan(0, 17, 0, 0, 0),
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            IsLate = false,
                            IsPresent = true
                        },
                        new
                        {
                            AttendanceId = 2,
                            CheckIn = new TimeSpan(0, 9, 15, 0, 0),
                            CheckOut = new TimeSpan(0, 17, 45, 0, 0),
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            IsLate = true,
                            IsPresent = true
                        },
                        new
                        {
                            AttendanceId = 3,
                            CheckIn = new TimeSpan(0, 8, 45, 0, 0),
                            CheckOut = new TimeSpan(0, 16, 30, 0, 0),
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3,
                            IsLate = false,
                            IsPresent = true
                        },
                        new
                        {
                            AttendanceId = 4,
                            CheckIn = new TimeSpan(0, 8, 0, 0, 0),
                            CheckOut = new TimeSpan(0, 17, 30, 0, 0),
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 4,
                            IsLate = false,
                            IsPresent = true
                        },
                        new
                        {
                            AttendanceId = 5,
                            CheckIn = new TimeSpan(0, 10, 0, 0, 0),
                            CheckOut = new TimeSpan(0, 18, 0, 0, 0),
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 5,
                            IsLate = true,
                            IsPresent = true
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Description = "Handles all HR activities",
                            Name = "Human Resources"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Description = "Manages all IT infrastructure",
                            Name = "Information Technology"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Description = "Handles accounting and financial operations",
                            Name = "Finance"
                        },
                        new
                        {
                            DepartmentId = 4,
                            Description = "Handles marketing and promotions",
                            Name = "Marketing"
                        },
                        new
                        {
                            DepartmentId = 5,
                            Description = "Manages daily business operations",
                            Name = "Operations"
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BasicSalary = 80000m,
                            DateOfBirth = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "john.smith@company.com",
                            HireDate = new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Smith",
                            Phone = "555-0101",
                            PositionId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            BasicSalary = 95000m,
                            DateOfBirth = new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "sarah.j@company.com",
                            HireDate = new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sarah Johnson",
                            Phone = "555-0102",
                            PositionId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            BasicSalary = 65000m,
                            DateOfBirth = new DateTime(1978, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "michael.b@company.com",
                            HireDate = new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Michael Brown",
                            Phone = "555-0103",
                            PositionId = 3
                        },
                        new
                        {
                            EmployeeId = 4,
                            BasicSalary = 60000m,
                            DateOfBirth = new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 4,
                            Email = "emily.d@company.com",
                            HireDate = new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Emily Davis",
                            Phone = "555-0104",
                            PositionId = 4
                        },
                        new
                        {
                            EmployeeId = 5,
                            BasicSalary = 75000m,
                            DateOfBirth = new DateTime(1982, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 5,
                            Email = "robert.w@company.com",
                            HireDate = new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Robert Wilson",
                            Phone = "555-0105",
                            PositionId = 5
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Leave", b =>
                {
                    b.Property<int>("LeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeaveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leaves");

                    b.HasData(
                        new
                        {
                            LeaveId = 1,
                            EmployeeId = 1,
                            EndDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = "Annual",
                            Reason = "Family vacation",
                            StartDate = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Approved"
                        },
                        new
                        {
                            LeaveId = 2,
                            EmployeeId = 2,
                            EndDate = new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = "Sick",
                            Reason = "Flu",
                            StartDate = new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Approved"
                        },
                        new
                        {
                            LeaveId = 3,
                            EmployeeId = 3,
                            EndDate = new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = "Casual",
                            Reason = "Personal work",
                            StartDate = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending"
                        },
                        new
                        {
                            LeaveId = 4,
                            EmployeeId = 4,
                            EndDate = new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = "Annual",
                            Reason = "Wedding ceremony",
                            StartDate = new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Approved"
                        },
                        new
                        {
                            LeaveId = 5,
                            EmployeeId = 5,
                            EndDate = new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = "Sick",
                            Reason = "Doctor appointment",
                            StartDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Approved"
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Payroll", b =>
                {
                    b.Property<int>("PayrollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PayrollId"));

                    b.Property<decimal>("Allowances")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Deductions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("NetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PayPeriodEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PayPeriodStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PayrollId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Payrolls");

                    b.HasData(
                        new
                        {
                            PayrollId = 1,
                            Allowances = 16000m,
                            BasicSalary = 80000m,
                            Deductions = 5000m,
                            EmployeeId = 1,
                            NetSalary = 99600m,
                            PayPeriodEnd = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PayPeriodStart = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Remarks = "Paid",
                            Tax = 10000m
                        },
                        new
                        {
                            PayrollId = 2,
                            Allowances = 19000m,
                            BasicSalary = 95000m,
                            Deductions = 5000m,
                            EmployeeId = 2,
                            NetSalary = 113400m,
                            PayPeriodEnd = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PayPeriodStart = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Remarks = "Paid",
                            Tax = 10000m
                        },
                        new
                        {
                            PayrollId = 3,
                            Allowances = 13000m,
                            BasicSalary = 65000m,
                            Deductions = 5000m,
                            EmployeeId = 3,
                            NetSalary = 77000m,
                            PayPeriodEnd = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PayPeriodStart = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Remarks = "Paid",
                            Tax = 10000m
                        },
                        new
                        {
                            PayrollId = 4,
                            Allowances = 12000m,
                            BasicSalary = 60000m,
                            Deductions = 5000m,
                            EmployeeId = 4,
                            NetSalary = 69500m,
                            PayPeriodEnd = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PayPeriodStart = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Remarks = "Paid",
                            Tax = 10000m
                        },
                        new
                        {
                            PayrollId = 5,
                            Allowances = 15000m,
                            BasicSalary = 75000m,
                            Deductions = 5000m,
                            EmployeeId = 5,
                            NetSalary = 88500m,
                            PayPeriodEnd = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PayPeriodStart = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Remarks = "Paid",
                            Tax = 10000m
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<decimal>("BaseSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            BaseSalary = 80000m,
                            Description = "Manages HR department",
                            Title = "HR Manager"
                        },
                        new
                        {
                            PositionId = 2,
                            BaseSalary = 95000m,
                            Description = "Senior software developer",
                            Title = "Senior Developer"
                        },
                        new
                        {
                            PositionId = 3,
                            BaseSalary = 65000m,
                            Description = "Handles financial accounts",
                            Title = "Accountant"
                        },
                        new
                        {
                            PositionId = 4,
                            BaseSalary = 60000m,
                            Description = "Marketing campaigns specialist",
                            Title = "Marketing Specialist"
                        },
                        new
                        {
                            PositionId = 5,
                            BaseSalary = 75000m,
                            Description = "Manages daily operations",
                            Title = "Operations Manager"
                        });
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Attendance", b =>
                {
                    b.HasOne("HRPayrollSystem.Models.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Employee", b =>
                {
                    b.HasOne("HRPayrollSystem.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HRPayrollSystem.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Leave", b =>
                {
                    b.HasOne("HRPayrollSystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Payroll", b =>
                {
                    b.HasOne("HRPayrollSystem.Models.Employee", "Employee")
                        .WithMany("Payrolls")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Employee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Payrolls");
                });

            modelBuilder.Entity("HRPayrollSystem.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
