/* Write your T-SQL query statement below https://leetcode.com/problems/big-countries/ */
SELECT NAME, POPULATION, AREA
FROM WORLD
WHERE AREA > 3000000 OR POPULATION > 25000000