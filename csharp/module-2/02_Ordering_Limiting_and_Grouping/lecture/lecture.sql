-- ORDERING RESULTS

-- Populations of all states from largest to smallest.
--SELECT * FROM state;
SELECT population, state_abbreviation FROM state ORDER BY population DESC;

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT state_name, census_region FROM state ORDER BY census_region DESC, state_name;
--sort by census region first and then alphabetically


-- The biggest park by area
SELECT TOP 1 area, park_name FROM park ORDER BY area DESC;
--parks in order fro largest to smallest
SELECT park_name FROM park ORDER BY area DESC;


-- LIMITING RESULTS

-- The 10 largest cities by populations
SELECT TOP 10 city_name FROM city ORDER BY population DESC;

-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.
SELECT TOP 20 park_name, (YEAR(GETDATE()) - YEAR(date_established)) AS age_in_years FROM park ORDER BY age_in_years DESC, park_name;

--year function to just get the year out of the equation

-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.
SELECT (city_name + ', ' + state_abbreviation) AS city_state_abbreviation FROM city;
--paranthesis just make it easier to read, not necessary, neither is the label

-- All park names and area
SELECT (park_name + ', ' + CONVERT(nvarchar, area)) AS park_area FROM park;
--CONVERT(data type, variable name)
--CAST(variable name as VARCHAR)

-- The census region and state name of all states in the West & Midwest sorted in ascending order.
SELECT census_region + ', ' + state_name FROM state WHERE census_region IN ('West', 'Midwest') ORDER BY census_region;


-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.
 SELECT AVG(population) AS avg_pop FROM state;

-- Total population in the West and South census regions
SELECT SUM(population) AS total_pop FROM state WHERE census_region IN ('West', 'South');

-- The number of cities with populations greater than 1 million
SELECT COUNT(*) AS cities_with_high_pop FROM city WHERE population > 1000000;

-- The number of state nicknames.
SELECT COUNT(state_nickname) AS nicknames FROM state WHERE state_nickname IS NOT NULL;
--this where statement is not necessary because null would not show up in the count

-- The area of the smallest and largest parks.
SELECT MIN(area) AS smallest_park, MAX(area) AS biggest_park FROM park;


-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.
SELECT state_abbreviation, COUNT(city_name) AS city_count FROM city GROUP BY state_abbreviation ORDER BY city_count DESC;
--write state abbrev first to make it apper on the left

-- Determine the average park area depending upon whether parks allow camping or not.
SELECT has_camping, AVG(area) AS avg_park_area FROM park GROUP BY has_camping ORDER BY has_camping;

-- Sum of the population of cities in each state ordered by state abbreviation.
SELECT state_abbreviation, SUM(population) AS city_pop FROM city GROUP BY state_abbreviation ORDER BY state_abbreviation;

-- The smallest city population in each state ordered by city population.
SELECT state_abbreviation, MIN(population) AS min_pop FROM city GROUP BY state_abbreviation ORDER BY min_pop;

/* ORDER OF SQL OPERATIONS
FROM: where is the data coming from: city table
WHERE: out of all the data in our city table, narrow it down, state abbrev is not null
GROUP BY: common value among data, state abbrev
SELECT: grab what info we want, aggregate val of smallest population and state abbrev
ORDER BY: tells what to display first, minimum population first by ascending(lowest first)
*/


-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,
SELECT COUNT(city_name) AS number_of_cities, 
(
	SELECT state_name FROM state AS state_table WHERE state_table.state_abbreviation = city_table.state_abbreviation
) 
AS state_name
FROM city AS city_table
GROUP BY state_abbreviation 
ORDER BY number_of_cities DESC;

-- Include the names of the smallest and largest parks


-- List the capital cities for the states in the Northeast census region.

