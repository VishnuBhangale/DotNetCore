# DotNetCore
Action Result
https://www.shivatutorials.com/2026/03/type-of-actionresult-in-aspnet-core-mvc.html

Dependancy Injection
https://www.shivatutorials.com/2026/03/create-addition-program-using-service.html

https://www.shivatutorials.com/2025/06

======Highest paid employee in each department=======

var highestSalaryByDept = employees
    .GroupBy(e => e.Department)
    .Select(g => g.OrderByDescending(e => e.Salary).First());

foreach (var emp in highestSalaryByDept)
{
    Console.WriteLine($"{emp.Department} - {emp.Name} - {emp.Salary}");
}

Second Highest Salary
var secondMaxSalary = employees
.Select(e => e.Salary)
.Distinct()
.OrderByDescending(s => s)
.Skip(1)
.FirstOrDefault();

Method            If 1 match            If multiple matches        If no match
--------------------------------------------------------------------------------
First             ✅ returns first       ✅ returns first            ❌ Exception (InvalidOperationException)
FirstOrDefault    ✅ returns first       ✅ returns first            ✅ null/default
Single            ✅ returns element     ❌ Exception                ❌ Exception
SingleOrDefault   ✅ returns element     ❌ Exception                ✅ null/default


https://www.shivatutorials.com/2025/03/top-50-net-core-mvc-interview-question.html

https://www.shivatutorials.com/2025/05/code-first-approach-in-net-core-mvc.html
