using HRPayrollSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HRPayrollSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships

            // Employee-Department (Many-to-One)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee-Position (Many-to-One)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee-Payroll (One-to-Many)
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee-Attendance (One-to-Many)
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);


            // Seed initial data if needed
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "Human Resources", Description = "Handles all HR activities" },
                new Department { DepartmentId = 2, Name = "Information Technology", Description = "Manages all IT infrastructure" },
                new Department { DepartmentId = 3, Name = "Finance", Description = "Handles accounting and financial operations" },
                new Department { DepartmentId = 4, Name = "Marketing", Description = "Handles marketing and promotions" },
                new Department { DepartmentId = 5, Name = "Operations", Description = "Manages daily business operations" }
            );

            // Seed Positions
            modelBuilder.Entity<Position>().HasData(
                new Position { PositionId = 1, Title = "HR Manager", BaseSalary = 80000, Description = "Manages HR department" },
                new Position { PositionId = 2, Title = "Senior Developer", BaseSalary = 95000, Description = "Senior software developer" },
                new Position { PositionId = 3, Title = "Accountant", BaseSalary = 65000, Description = "Handles financial accounts" },
                new Position { PositionId = 4, Title = "Marketing Specialist", BaseSalary = 60000, Description = "Marketing campaigns specialist" },
                new Position { PositionId = 5, Title = "Operations Manager", BaseSalary = 75000, Description = "Manages daily operations" }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "John Smith",
                    Email = "john.smith@company.com",
                    Phone = "555-0101",
                    DateOfBirth = new DateTime(1980, 5, 15),
                    HireDate = new DateTime(2015, 3, 10),
                    DepartmentId = 1,
                    PositionId = 1,
                    BasicSalary = 80000
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Sarah Johnson",
                    Email = "sarah.j@company.com",
                    Phone = "555-0102",
                    DateOfBirth = new DateTime(1985, 8, 22),
                    HireDate = new DateTime(2018, 6, 15),
                    DepartmentId = 2,
                    PositionId = 2,
                    BasicSalary = 95000
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Michael Brown",
                    Email = "michael.b@company.com",
                    Phone = "555-0103",
                    DateOfBirth = new DateTime(1978, 11, 5),
                    HireDate = new DateTime(2016, 2, 20),
                    DepartmentId = 3,
                    PositionId = 3,
                    BasicSalary = 65000
                },
                new Employee
                {
                    EmployeeId = 4,
                    Name = "Emily Davis",
                    Email = "emily.d@company.com",
                    Phone = "555-0104",
                    DateOfBirth = new DateTime(1990, 3, 30),
                    HireDate = new DateTime(2019, 9, 5),
                    DepartmentId = 4,
                    PositionId = 4,
                    BasicSalary = 60000
                },
                new Employee
                {
                    EmployeeId = 5,
                    Name = "Robert Wilson",
                    Email = "robert.w@company.com",
                    Phone = "555-0105",
                    DateOfBirth = new DateTime(1982, 7, 12),
                    HireDate = new DateTime(2017, 4, 18),
                    DepartmentId = 5,
                    PositionId = 5,
                    BasicSalary = 75000
                }
            );

            // Seed Attendances
            modelBuilder.Entity<Attendance>().HasData(
                new Attendance
                {
                    AttendanceId = 1,
                    EmployeeId = 1,
                    Date = new DateTime(2023, 6, 1),
                    CheckIn = new TimeSpan(8, 30, 0),
                    CheckOut = new TimeSpan(17, 0, 0),
                    IsPresent = true,
                    IsLate = false
                },
                new Attendance
                {
                    AttendanceId = 2,
                    EmployeeId = 2,
                    Date = new DateTime(2023, 6, 1),
                    CheckIn = new TimeSpan(9, 15, 0),
                    CheckOut = new TimeSpan(17, 45, 0),
                    IsPresent = true,
                    IsLate = true
                },
                new Attendance
                {
                    AttendanceId = 3,
                    EmployeeId = 3,
                    Date = new DateTime(2023, 6, 1),
                    CheckIn = new TimeSpan(8, 45, 0),
                    CheckOut = new TimeSpan(16, 30, 0),
                    IsPresent = true,
                    IsLate = false
                },
                new Attendance
                {
                    AttendanceId = 4,
                    EmployeeId = 4,
                    Date = new DateTime(2023, 6, 1),
                    CheckIn = new TimeSpan(8, 0, 0),
                    CheckOut = new TimeSpan(17, 30, 0),
                    IsPresent = true,
                    IsLate = false
                },
                new Attendance
                {
                    AttendanceId = 5,
                    EmployeeId = 5,
                    Date = new DateTime(2023, 6, 1),
                    CheckIn = new TimeSpan(10, 0, 0),
                    CheckOut = new TimeSpan(18, 0, 0),
                    IsPresent = true,
                    IsLate = true
                }
            );

            // Seed Payrolls
            modelBuilder.Entity<Payroll>().HasData(
                new Payroll
                {
                    PayrollId = 1,
                    EmployeeId = 1,
                    PayPeriodStart = new DateTime(2023, 6, 1),
                    PayPeriodEnd = new DateTime(2023, 6, 30),
                    PaymentDate = new DateTime(2023, 7, 5),
                    BasicSalary = 80000,
                    Allowances = 16000,
                    Deductions = 5000,
                    Tax = 10000,              
                    NetSalary = 99600,
                    Remarks = "Paid"
                },
                new Payroll
                {
                    PayrollId = 2,
                    EmployeeId = 2,
                    PayPeriodStart = new DateTime(2023, 6, 1),
                    PayPeriodEnd = new DateTime(2023, 6, 30),
                    PaymentDate = new DateTime(2023, 7, 5),
                    BasicSalary = 95000,
                    Allowances = 19000,
                    Deductions = 5000,
                    Tax = 10000,
                    NetSalary = 113400,
                    Remarks = "Paid"
                },
                new Payroll
                {
                    PayrollId = 3,
                    EmployeeId = 3,
                    PayPeriodStart = new DateTime(2023, 6, 1),
                    PayPeriodEnd = new DateTime(2023, 6, 30),
                    PaymentDate = new DateTime(2023, 7, 5),
                    BasicSalary = 65000,
                    Allowances = 13000,
                    Deductions = 5000,
                    Tax = 10000,
             
                    NetSalary = 77000,
                    Remarks = "Paid"
                },
                new Payroll
                {
                    PayrollId = 4,
                    EmployeeId = 4,
                    PayPeriodStart = new DateTime(2023, 6, 1),
                    PayPeriodEnd = new DateTime(2023, 6, 30),
                    PaymentDate = new DateTime(2023, 7, 5),
                    BasicSalary = 60000,
                    Allowances = 12000,
                    Deductions = 5000,
                    Tax = 10000,
                    NetSalary = 69500,
                    Remarks = "Paid"
                },
                new Payroll
                {
                    PayrollId = 5,
                    EmployeeId = 5,
                    PayPeriodStart = new DateTime(2023, 6, 1),
                    PayPeriodEnd = new DateTime(2023, 6, 30),
                    PaymentDate = new DateTime(2023, 7, 5),
                    BasicSalary = 75000,
                    Allowances = 15000,
                    Deductions = 5000,
                    Tax = 10000,        
                    NetSalary = 88500,
                    Remarks = "Paid"
                }
            );

            // Seed Leaves
            modelBuilder.Entity<Leave>().HasData(
                new Leave
                {
                    LeaveId = 1,
                    EmployeeId = 1,
                    StartDate = new DateTime(2023, 6, 10),
                    EndDate = new DateTime(2023, 6, 12),
                    LeaveType = "Annual",
                    Status = "Approved",
                    Reason = "Family vacation"
                },
                new Leave
                {
                    LeaveId = 2,
                    EmployeeId = 2,
                    StartDate = new DateTime(2023, 6, 5),
                    EndDate = new DateTime(2023, 6, 7),
                    LeaveType = "Sick",
                    Status = "Approved",
                    Reason = "Flu"
                },
                new Leave
                {
                    LeaveId = 3,
                    EmployeeId = 3,
                    StartDate = new DateTime(2023, 6, 15),
                    EndDate = new DateTime(2023, 6, 16),
                    LeaveType = "Casual",
                    Status = "Pending",
                    Reason = "Personal work"
                },
                new Leave
                {
                    LeaveId = 4,
                    EmployeeId = 4,
                    StartDate = new DateTime(2023, 6, 20),
                    EndDate = new DateTime(2023, 6, 23),
                    LeaveType = "Annual",
                    Status = "Approved",
                    Reason = "Wedding ceremony"
                },
                new Leave
                {
                    LeaveId = 5,
                    EmployeeId = 5,
                    StartDate = new DateTime(2023, 6, 25),
                    EndDate = new DateTime(2023, 6, 26),
                    LeaveType = "Sick",
                    Status = "Approved",
                    Reason = "Doctor appointment"
                }
            );
        }
    }
}
