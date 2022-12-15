-- Part one: ORDER BY
SELECT topping_name FROM topping ORDER BY topping_name DESC;


-- Part two: TOP
SELECT TOP 5 sale_id, total FROM sale ORDER BY total DESC;


-- Part three: Aggregate functions
SELECT SUM(total) AS total_sales FROM sale WHERE customer_id = 37;
SELECT COUNT(*) AS times_used FROM pizza_topping WHERE topping_name = 'Pineapple';
SELECT MIN(total) AS min_sales, MAX(total) AS max_sales, round(AVG(total), 2) AS avg_sales FROM sale;
--round(AVG(total), 2) rounds to two decimal places
-- Part four: GROUP BY
SELECT topping_name, COUNT(*) AS times_used FROM pizza_topping GROUP BY topping_name ORDER BY times_used DESC;


-- Part five: String concatenation
SELECT first_name + ' ' + last_name FROM customer ORDER BY last_name;

