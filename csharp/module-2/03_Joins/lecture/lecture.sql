-- INNER JOIN

-- Write a query to retrieve the name and state abbreviation for the 2 cities named "Columbus" in the database
SELECT city_name, state_abbreviation FROM city WHERE city_name = 'Columbus';

-- Modify the previous query to retrieve the names of the states (rather than their abbreviations).
SELECT city_name, state_name
FROM city
JOIN state ON city.state_abbreviation = state.state_abbreviation
WHERE city_name = 'Columbus';

--query to retrieve the name of capital cities in each state, can choose different PK and FK depending on the data youre looking for 
SELECT city_name, state_name
FROM city
--JOIN state ON state.capital = city.city_id;
JOIN state on city.city_id = state.capital;

-- Write a query to retrieve the names of all the national parks with their state abbreviations.
-- (Some parks will appear more than once in the results, because they cross state boundaries.)
SELECT park_name , park_state.state_abbreviation
FROM park
JOIN park_state ON park.park_id = park_state.park_id;

-- The park_state table is an associative table that can be used to connect the park and state tables.
-- Modify the previous query to retrieve the names of the states rather than their abbreviations.
SELECT park_name , state_name
FROM park
JOIN park_state ON park.park_id = park_state.park_id
JOIN state ON state.state_abbreviation = park_state.state_abbreviation;

-- Modify the previous query to include the name of the state's capital city.
SELECT park_name , state_name, city_name AS capital_city
FROM park
JOIN park_state ON park.park_id = park_state.park_id
JOIN state ON state.state_abbreviation = park_state.state_abbreviation
JOIN city ON state.capital = city.city_id;


-- Modify the previous query to include the area of each park.
SELECT park_name , state_name, city_name, park.area
FROM park
JOIN park_state ON park.park_id = park_state.park_id
JOIN state ON state.state_abbreviation = park_state.state_abbreviation
JOIN city ON state.capital = city.city_id;

-- Write a query to retrieve the names and populations of all the cities in the Midwest census region.
SELECT city_name, city.population
FROM city
JOIN state ON city.state_abbreviation = state.state_abbreviation
WHERE census_region = 'Midwest';

-- Write a query to retrieve the number of cities in the city table for each state in the Midwest census region.
SELECT state_name, COUNT(city_id) AS city_count_midwest 
FROM city
JOIN state ON city.state_abbreviation = state.state_abbreviation
WHERE census_region = 'Midwest'
GROUP BY state_name;

-- Modify the previous query to sort the results by the number of cities in descending order.
SELECT state_name, COUNT(city_id) AS city_count_midwest 
FROM city
JOIN state ON city.state_abbreviation = state.state_abbreviation
WHERE census_region = 'Midwest'
GROUP BY state_name
ORDER BY city_count_midwest DESC;


-- LEFT JOIN

-- Write a query to retrieve the state name and the earliest date a park was established in that state (or territory) for every record in the state table that has park records associated with it.
--since you want all states you will put the state table on the left of join statement
--for every record in a table usually means left join
--dont forget you can do math within SQL statements
SELECT state_name, MIN(date_established) AS earliest_date
FROM state
JOIN park_state ON state.state_abbreviation = park_state.state_abbreviation
JOIN park ON park.park_id = park_state.park_id
GROUP BY state_name;

-- Modify the previous query so the results include entries for all the records in the state table, even if they have no park records associated with them.
SELECT state_name, MIN(date_established) AS earliest_date
FROM state
LEFT JOIN park_state ON state.state_abbreviation = park_state.state_abbreviation
LEFT JOIN park ON park.park_id = park_state.park_id
GROUP BY state_name;


-- UNION

-- Write a query to retrieve all the place names in the city and state tables that begin with "W" sorted alphabetically. (Washington is the name of a city and a state--how many times does it appear in the results?)
SELECT city_name AS name
FROM city
WHERE city_name LIKE 'W%'
UNION
SELECT state_name
FROM state
WHERE state_name LIKE 'W%';

-- Modify the previous query to include a column that indicates whether the place is a city or state.
SELECT city_name, 'City' AS type_of_place
FROM city
WHERE city_name LIKE 'W%'
UNION
SELECT state_name, 'State' AS type_of_place
FROM state
WHERE state_name LIKE 'W%'
ORDER BY city_name;
--now washington appears as both a city and a state, without that other column the union will only show repeating values once


-- MovieDB
-- After running the script to set up the MovieDB database, make sure it is selected in SSMS and confirm it is working correctly by writing queries to retrieve...

-- The names of all the movie genres
--SELECT genre_name FROM genre;

---- The titles of all the Comedy movies
--SELECT title
--FROM movie
--JOIN movie_genre ON movie.movie_id = movie_genre.movie_id
--JOIN genre ON genre.genre_id = movie_genre.genre_id
--WHERE genre_name = 'Comedy';
