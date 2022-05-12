SELECT email, COUNT(email)
FROM Employee
GROUP BY email
HAVING COUNT(email) > 1