-- 9. The titles of movies directed by James Cameron, sorted alphabetically.
-- (6 rows)
SELECT DISTINCT title
FROM genre
JOIN movie_genre ON genre.genre_id = movie_genre.genre_id
JOIN movie ON movie.movie_id = movie_genre.movie_id
JOIN movie_actor ON movie.movie_id = movie_actor.movie_id
JOIN person ON person.person_id = movie.director_id
WHERE person_name = 'James Cameron'
ORDER BY title;
