-- INSERT

-- Add Disneyland to the park table. (It was established on 7/17/1955, has an area of 2.1 square kilometers and does not offer camping.)
INSERT INTO park (park_name, date_established, area, has_camping)
VALUES ('Disneyland', '7/17/1955', 2.1, 0);
--if successful itll say 1 row affected

SELECT * 
FROM park
WHERE park_name = 'Disneyland';
--the table will make a park_id for you if it has an auto-incrementing identity
--natural keys ex. state abbrev, zip code, country code

--INSERT INTO tablename (column1, column2, column3) 
--VALUES (value1, value2, value3)

-- Add Hawkins, IN (with a population of 30,000 and an area of 38.1 square kilometers) and Cicely, AK (with a popuation of 839 and an area of 11.4 square kilometers) to the city table.
INSERT INTO city (city_name, state_abbreviation, population, area)
VALUES ('Hawkins', 'IN', 30000, 38.1) , ('Cicely', 'AK', 839, 11.4);
--use commas to seperate values
--2 rows affected

SELECT * FROM city WHERE city_name IN ('Hawkins', 'Cicely');
-- Since Disneyland is in California (CA), add a record representing that to the park_state table.
INSERT INTO park_state (park_id, state_abbreviation)
--VALUES (64, 'CA'); sure this works but thats no fun
VALUES ((SELECT park_id FROM park WHERE park_name = 'Disneyland'), 'CA');
--can also write as SELECT park_id, 'CA' FROM park WHERE park_name = 'Disneyland';

SELECT * FROM park_state WHERE park_id = 64;
-- UPDATE

-- Change the state nickname of California to "The Happiest Place on Earth."
UPDATE state SET state_nickname = 'The Happiest Place on Earth.'
WHERE state_name = 'California';

--SELECT * FROM state
--WHERE state_nickname = 'The Happiest Place on Earth.';

--UPDATE table_name SET column_name = value 
--WHERE some condition
-- Increase the population of California by 1,000,000.
UPDATE state SET population += 1000000
WHERE state_name = 'California';

-- Change the capital of California to Anaheim.
UPDATE state SET capital = (SELECT city_id FROM city WHERE city_name = 'Anaheim' AND state_abbreviation = 'CA')
WHERE state_name = 'California';

--set capital id to match the city id for anaheim commiefornia
--dont forget the second where statement, outside of all parenthesis

-- Change California's nickname back to "The Golden State", reduce the population by 1,000,000, and change the capital back to Sacramento.
UPDATE state SET state_nickname = 'The Golden State', population -= 1000000, capital = (SELECT city_id FROM city WHERE city_name = 'Sacramento' AND state_abbreviation = 'CA')
WHERE state_name = 'California';

SELECT * FROM state WHERE state_name = 'California';
-- DELETE

-- Delete Hawkins, IN from the city table.
DELETE FROM city 
WHERE city_name = 'Hawkins' AND state_abbreviation = 'IN';
--be more specific rather than less to ensure you are updating/deleting the right item
--DELETE FROM table_name
--WHERE condition;
--do not delete data very often, usually have an archived column

-- Delete all cities with a population of less than 1,000 people from the city table.

SELECT * FROM city WHERE population < 1000;

DELETE FROM city
WHERE population < 1000;


-- REFERENTIAL INTEGRITY

-- Try adding a city to the city table with "XX" as the state abbreviation.
INSERT INTO city (state_abbreviation)
VALUES ('XX');
--null error
INSERT INTO city (city_name, state_abbreviation, population, area)
VALUES ('Kevanheim', 'XX', 1, 0.1);
--foreing key constraint error

-- Try deleting California from the state table.
DELETE FROM state
WHERE state_name = 'California';
--reference constraint as FK
--'CA' is a primary key on state and a foreign on other tables, that relationship would be deestroyed if we deleted cali from here

-- Try deleting Disneyland from the park table. Try again after deleting its record from the park_state table.
DELETE FROM park
WHERE park_name = 'Disneyland';
--reference constraint

DELETE FROM park_state
WHERE park_id = (SELECT park_id FROM park WHERE park_name = 'Disneyland');

SELECT * FROM park 
WHERE park_name = 'Disneyland';

-- CONSTRAINTS

-- NOT NULL constraint
-- Try adding Smallville, KS to the city table without specifying its population or area.
INSERT INTO city (city_name, state_abbreviation)
VALUES ('Smallville', 'KS');
--null value error

-- DEFAULT constraint
-- Try adding Smallville, KS again, specifying an area but not a population.
INSERT INTO city (city_name, state_abbreviation, area)
VALUES ('Smallville', 'KS', 10);
--you can add this without adding pop



-- Retrieve the new record to confirm it has been given a default, non-null value for population.
SELECT * FROM city
WHERE city_name = 'Smallville';
--pop's default value is 0

-- UNIQUE constraint
-- Try changing California's nickname to "Vacationland" (which is already the nickname of Maine).
UPDATE state SET state_nickname = 'Vacationland'
WHERE state_name = 'California';
--unique constraint error
SELECT * FROM state 
WHERE state_name = 'California';

-- CHECK constraint
-- Try changing the census region of Florida (FL) to "Southeast" (which is not a valid census region).
UPDATE state SET census_region = 'Southeast'
WHERE state_name = 'Florida';
--check constraint error since se is not a valid census region

-- TRANSACTIONS

-- Delete the record for Smallville, KS within a transaction.
BEGIN TRANSACTION; --note the semi colon
DELETE FROM city
WHERE city_name = 'Smallville' AND state_abbreviation = 'KS'; --this is a complete sql clause
COMMIT; --committing a transaction makes the changes permanently applied to the database

SELECT * FROM city 
WHERE city_name = 'Smallville';
-- Delete all of the records from the park_state table, but then "undo" the deletion by rolling back the transaction.
BEGIN TRANSACTION;
DELETE FROM park_state;
SELECT COUNT(*) from park_state;
ROLLBACK; --rollback the transaction, get rid of the changes instead of committing them
SELECT COUNT(*) from park_state;

-- Update all of the cities to be in the state of Texas (TX), but then roll back the transaction.
BEGIN TRANSACTION;
UPDATE city SET state_abbreviation = 'TX'; --no WHER, set all states
SELECT TOP 10 city_name, state_abbreviation FROM city;
ROLLBACK;
SELECT top 10 city_name, state_abbreviation FROM city;

-- Demonstrate two different SQL connections trying to access the same table where one is inside of a transaction but hasn't committed yet.
--demonstrates the principle of isolation
--SELECT * FROM city WITH(NOLOCK) WHERE city_name = 'Schrodinger''s City';
--this will break the isolation issue 