-- 23. The name and date established of parks opened in the 1960s (6 rows)
SELECT park_name, date_established FROM park WHERE date_established = '1961-07-01' OR date_established = '1964-09-12' OR date_established = '1966-10-15' OR date_established = '1968-10-02' OR date_established = '1962-12-09';
--SELECT date_established FROM park;