-- 21. For every person in the person table with the first name of "George", list the number of movies they've been in. Name the count column 'num_of_movies'.
-- Include all Georges, even those that have not appeared in any movies. Display the names in alphabetical order. 
-- (59 rows)

--SELECT city_name, 'City' AS type_of_place
--FROM city
--WHERE city_name LIKE 'W%'
--UNION
--SELECT state_name, 'State' AS type_of_place
--FROM state
--WHERE state_name LIKE 'W%'
--ORDER BY city_name;


SELECT person_name, COUNT(title) AS num_of_movies
FROM person
LEFT JOIN movie_actor ON person.person_id = movie_actor.actor_id
LEFT JOIN movie ON movie.movie_id = movie_actor.movie_id
--LEFT JOIN movie ON person.person_id = movie.director_id
WHERE person_name LIKE 'George %'
GROUP BY person_name, profile_path
ORDER BY person_name;

--SELECT person_


