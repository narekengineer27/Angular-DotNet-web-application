using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTodoList.Data.Migrations.EmployeeTodoListDataFiller
{
    public partial class Initial_Data_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[Employees] ([Name]) VALUES ('Employee 1');
            INSERT INTO [dbo].[Employees] ([Name]) VALUES('Employee 2');
            INSERT INTO [dbo].[Employees] ([Name]) VALUES('Employee 3'); ");

            migrationBuilder.Sql(@"
INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 1', 'Task 1 Description', 0, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 2', 'Task 2 Description', 1, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 3', 'Task 3 Description', 2, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 4', 'Task 4 Description', 0, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 5', 'Task 5 Description', 0, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 6', 'Task 6 Description', 0, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 7', 'Task 7 Description', 1, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 8', 'Task 8 Description', 1, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 9', 'Task 9 Description', 1, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 1';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 1', 'Task 1 Description', 0, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 2', 'Task 2 Description', 1, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 3', 'Task 3 Description', 2, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 4', 'Task 4 Description', 0, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 5', 'Task 5 Description', 0, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 6', 'Task 6 Description', 0, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 7', 'Task 7 Description', 1, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 8', 'Task 8 Description', 1, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 9', 'Task 9 Description', 1, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 2';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 1', 'Task 1 Description', 0, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 2', 'Task 2 Description', 1, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 3', 'Task 3 Description', 2, 0, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 4', 'Task 4 Description', 0, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 5', 'Task 5 Description', 0, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 6', 'Task 6 Description', 0, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 7', 'Task 7 Description', 1, 1, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 8', 'Task 8 Description', 1, 2, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

INSERT INTO [dbo].[ToDoTasks] ([Title], [Description], [PriorityLevel], [State], [Estimate], [EmployeeId])
SELECT 'Task 9', 'Task 9 Description', 1, 3, 1, [dbo].[Employees].[EmployeeId]
FROM [dbo].[Employees]
WHERE [Name] like 'Employee 3';

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
