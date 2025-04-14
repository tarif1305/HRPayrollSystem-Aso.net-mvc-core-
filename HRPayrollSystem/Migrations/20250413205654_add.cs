using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRPayrollSystem.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckIn = table.Column<TimeSpan>(type: "time", nullable: false),
                    CheckOut = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    IsLate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    PayrollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.PayrollId);
                    table.ForeignKey(
                        name: "FK_Payrolls_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Handles all HR activities", "Human Resources" },
                    { 2, "Manages all IT infrastructure", "Information Technology" },
                    { 3, "Handles accounting and financial operations", "Finance" },
                    { 4, "Handles marketing and promotions", "Marketing" },
                    { 5, "Manages daily business operations", "Operations" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "BaseSalary", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 80000m, "Manages HR department", "HR Manager" },
                    { 2, 95000m, "Senior software developer", "Senior Developer" },
                    { 3, 65000m, "Handles financial accounts", "Accountant" },
                    { 4, 60000m, "Marketing campaigns specialist", "Marketing Specialist" },
                    { 5, 75000m, "Manages daily operations", "Operations Manager" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BasicSalary", "DateOfBirth", "DepartmentId", "Email", "HireDate", "Name", "Phone", "PositionId" },
                values: new object[,]
                {
                    { 1, 80000m, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "john.smith@company.com", new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Smith", "555-0101", 1 },
                    { 2, 95000m, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "sarah.j@company.com", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Johnson", "555-0102", 2 },
                    { 3, 65000m, new DateTime(1978, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "michael.b@company.com", new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Brown", "555-0103", 3 },
                    { 4, 60000m, new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "emily.d@company.com", new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", "555-0104", 4 },
                    { 5, 75000m, new DateTime(1982, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "robert.w@company.com", new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Wilson", "555-0105", 5 }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "AttendanceId", "CheckIn", "CheckOut", "Date", "EmployeeId", "IsLate", "IsPresent" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 8, 30, 0, 0), new TimeSpan(0, 17, 0, 0, 0), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true },
                    { 2, new TimeSpan(0, 9, 15, 0, 0), new TimeSpan(0, 17, 45, 0, 0), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true },
                    { 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 16, 30, 0, 0), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true },
                    { 4, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 17, 30, 0, 0), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true },
                    { 5, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveId", "EmployeeId", "EndDate", "LeaveType", "Reason", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual", "Family vacation", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 2, 2, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick", "Flu", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 3, 3, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casual", "Personal work", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 4, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual", "Wedding ceremony", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 5, 5, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick", "Doctor appointment", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "Payrolls",
                columns: new[] { "PayrollId", "Allowances", "BasicSalary", "Deductions", "EmployeeId", "NetSalary", "PayPeriodEnd", "PayPeriodStart", "PaymentDate", "Remarks", "Tax" },
                values: new object[,]
                {
                    { 1, 16000m, 80000m, 5000m, 1, 99600m, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid", 10000m },
                    { 2, 19000m, 95000m, 5000m, 2, 113400m, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid", 10000m },
                    { 3, 13000m, 65000m, 5000m, 3, 77000m, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid", 10000m },
                    { 4, 12000m, 60000m, 5000m, 4, 69500m, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid", 10000m },
                    { 5, 15000m, 75000m, 5000m, 5, 88500m, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid", 10000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_EmployeeId",
                table: "Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_EmployeeId",
                table: "Payrolls",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
