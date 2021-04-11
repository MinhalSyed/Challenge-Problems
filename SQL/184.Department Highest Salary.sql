/* Write your T-SQL query statement below */

SELECT d2.Name as Department, e3.Name as Employee, e3.Salary as Salary FROM
Department d2
JOIN Employee e3 ON e3.DepartmentId = d2.Id
JOIN 
(
    SELECT MAX(Salary) as MaxSalary, e.DepartmentId as DepartmentId
    FROM Employee e 
    GROUP BY e.DepartmentId
) f 

ON d2.id = f.DepartmentId AND f.MaxSalary = e3.Salary
