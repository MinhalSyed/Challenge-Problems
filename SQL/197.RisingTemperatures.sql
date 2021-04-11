/* Write your T-SQL query statement below */


SELECT W2.ID
FROM WEATHER W
JOIN WEATHER W2 
ON DATEDIFF(day, W.RECORDDATE, W2.RECORDDATE)  = 1
WHERE W2.TEMPERATURE > W.TEMPERATURE -- SLOWER 


/* Write your T-SQL query statement below */


SELECT W2.ID
FROM WEATHER W
JOIN WEATHER W2 
ON DATEDIFF(day, W.RECORDDATE, W2.RECORDDATE)  = 1 
AND W2.TEMPERATURE > W.TEMPERATURE -- FASTER!
