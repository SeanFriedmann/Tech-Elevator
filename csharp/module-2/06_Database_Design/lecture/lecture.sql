--switch to using system db
USE master;
GO --do that thing we said to do, then move on to the next step and stop

--check to see if db already exists and if it does, drop it
DROP DATABASE IF EXISTS ArtGallery; --allows you to run this sequence over and over again
--create db
CREATE DATABASE ArtGallery; --cannot run this cmd twice
GO

--switch to ArtGalleryDB
USE ArtGallery;
GO

BEGIN TRANSACTION;
--make customer table
CREATE TABLE customer (
	--column name, data type, maybe auto incrementing
	customer_id INT IDENTITY(1,1), --identity is MSSQL auto incrementing feature, usually used for PK's
	customer_name VARCHAR(50) NOT NULL,
	address VARCHAR(100) NOT NULL,
	phone VARCHAR(14) NOT NULL,
	--add PK constraint
	--CONSTRAINT (constraint name) TYPE (column name)
	CONSTRAINT PK_customer PRIMARY KEY (customer_id)

);

CREATE TABLE artist(
	artist_id INT IDENTITY(1,1),
	artist_name VARCHAR(50) NOT NULL,
	address VARCHAR(100) NOT NULL,
	phone VARCHAR(14) NOT NULL,
	CONSTRAINT pk_artist PRIMARY KEY (artist_id)
);

CREATE TABLE artwork (
	artwork_id INT IDENTITY(1,1),
	title VARCHAR(50) NOT NULL,
	description VARCHAR(50), --desc is allowed to be null
	artist_id INT NOT NULL,
	CONSTRAINT PK_artwork PRIMARY KEY (artwork_id),
	--CONSTRAINT name FOREIGN KEY column name REFERENCES tablename(columname)
	CONSTRAINT FK_artist FOREIGN KEY (artist_id) REFERENCES artist(artist_id)

);

CREATE TABLE artwork_customer(
	customer_id INT NOT NULL, --coming from somewhere else
	artwork_id INT NOT NULL, --coming from somewehre else
	purchase_date DATE NOT NULL,
	--price INT NOT NULL,
	--composite keys: put 2 columns inside PRIMARY KEY paranthesis
	CONSTRAINT pk_artwork_customer PRIMARY KEY (customer_id, artwork_id),
	CONSTRAINT fk_artwork_customer_customer FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
	CONSTRAINT fk_artwork_customer_artwork FOREIGN KEY (artwork_id) REFERENCES artwork(artwork_id)
);
COMMIT;

--HW CRITERIA
--your script should build a database