-- 14. The name and date established of the top 10 oldest national parks.
-- Order the results with the oldest park first.
-- (10 rows)
SELECT TOP 10 date_established, park_name FROM park ORDER BY date_established;