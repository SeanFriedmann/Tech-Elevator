-- 10. The names of directors who have directed a movie over 3 hours [180 minutes], sorted alphabetically.
-- (15 rows)
SELECT DISTINCT person_name
FROM genre
JOIN movie_genre ON genre.genre_id = movie_genre.genre_id
JOIN movie ON movie.movie_id = movie_genre.movie_id
JOIN movie_actor ON movie.movie_id = movie_actor.movie_id
JOIN person ON person.person_id = movie.director_id
WHERE length_minutes > 180
ORDER BY person_name;
