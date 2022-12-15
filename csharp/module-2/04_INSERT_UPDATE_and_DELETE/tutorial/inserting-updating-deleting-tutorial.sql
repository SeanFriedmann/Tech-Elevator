-- Part one: Query for orders
SELECT customer.last_name, customer.first_name, customer.street_address, sale.sale_id, pizza.pizza_id, pizza.size_id,pizza.crust, pizza.sauce, pizza_topping.topping_name
FROM customer 
JOIN sale ON customer.customer_id = sale.customer_id
JOIN pizza ON sale.sale_id = pizza.sale_id
LEFT JOIN pizza_topping ON pizza.pizza_id = pizza_topping.pizza_id
WHERE customer.last_name = 'Mamwell' AND customer.first_name = 'Elenore'
ORDER BY customer.last_name, customer.first_name, sale.sale_id, pizza.pizza_id;

-- Part two: Add additional pizza
INSERT INTO pizza (sale_id, size_id, crust, sauce, price)
OUTPUT INSERTED.pizza_id
VALUES (50, (SELECT size_id FROM size WHERE size_description = 'Large'), 'Thin', 'Normal', 17.24);

INSERT INTO pizza_topping (pizza_id, topping_name)
VALUES
(96, 'Sausage'),
(96, 'Onions'),
(96, 'Mushrooms');

-- Part three: Change existing pizza
UPDATE pizza set size_id = (SELECT size_id FROM size WHERE size_description = 'Large'),
price = price + 2
WHERE pizza_id = 67;


-- Part four: Remove additional pizza
DELETE FROM pizza_topping
WHERE pizza_id = 96;

DELETE FROM pizza
WHERE pizza_id = 96;