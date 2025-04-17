# HRPayrollSystem

A comprehensive ASP.NET Core Razor Pages application designed to manage employee records, payrolls, departments, attendance, and leave requests for a company. This system simplifies HR and payroll operations with structured models, entity relationships, and seeded demo data.

## 🚀 Features

- **Employee Management**: Add, update, and track employee details including salary, department, and position.
- **Department & Position**: Categorize employees under defined departments and roles.
- **Payroll Processing**: Track salary, deductions, allowances, tax, and generate net salary reports.
- **Attendance Tracking**: Monitor daily check-ins/outs, late marks, and present status.
- **Leave Management**: Employees can apply for different types of leave; admin can track and approve.
- **Seed Data**: Application comes with seeded demo data for quick testing and demonstration.

## 🛠 Technologies Used

- ASP.NET Core Razor Pages
- Entity Framework Core
- SQL Server
- C#
- Bootstrap (Frontend UI)

  🗃️ Database Overview
Employee: Core model with links to Department and Position.

Department & Position: Categorization of employee structure.

Attendance: Daily record including late and present flags.

Leave: Tracks type, reason, status, and dates.

Payroll: Handles salary structure, payments, deductions, and remarks.

