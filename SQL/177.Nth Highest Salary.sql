CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        
                SELECT DISTINCT SALARY
                FROM Employee
                ORDER BY SALARY DESC
                OFFSET @N - 1 ROWS FETCH NEXT (1) ROWS ONLY
            
    );
END