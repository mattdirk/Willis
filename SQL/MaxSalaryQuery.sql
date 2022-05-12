SELECT d.name as Department, groupedEmployee.name as Employee, groupedEmployee.MaxSalary as Salary
FROM Department d
INNER JOIN
    (SELECT departmentId, name, MAX(salary) AS MaxSalary
    FROM Employee
    GROUP BY departmentId) groupedEmployee
ON d.departmentId = groupedEmployee.departmentId 