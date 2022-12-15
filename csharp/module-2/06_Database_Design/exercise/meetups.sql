USE master;
GO --do that thing we said to do, then move on to the next step and stop

--check to see if db already exists and if it does, drop it
DROP DATABASE IF EXISTS Meetups; --allows you to run this sequence over and over again
--create db
CREATE DATABASE Meetups; --cannot run this cmd twice
GO

--switch to ArtGalleryDB
USE Meetups;
GO

BEGIN TRANSACTION;
CREATE TABLE member(
	member_number INT IDENTITY(1,1),
	last_name VARCHAR(20) NOT NULL,
	first_name VARCHAR(20) NOT NULL,
	email_address VARCHAR(50) NOT NULL,
	phone_number VARCHAR(14),
	date_of_birth DATE NOT NULL,
	has_reminders BIT NOT NULL,
	CONSTRAINT pk_member PRIMARY KEY (member_number)
);

CREATE TABLE interest_group(
	group_number INT IDENTITY(1,1),
	group_name VARCHAR(50) NOT NULL,
	total_members INT NOT NULL,
	
	CONSTRAINT pk_interest_group PRIMARY KEY (group_number),
	--CONSTRAINT fk_interest_group_member FOREIGN KEY (member_number) REFERENCES member(member_number)

);

CREATE TABLE event(
	event_number INT IDENTITY(1,1),
	event_name VARCHAR(50) NOT NULL,
	event_description VARCHAR(200) NOT NULL,
	start_date_and_time DATETIME NOT NULL,
	duration INT NOT NULL,
	--group_name VARCHAR(50),
	group_number INT,
	total_members INT NOT NULL,
	member_number INT,
	--CONSTRAINT fk_event_member FOREIGN KEY (member_number) REFERENCES member(member_number),
	CONSTRAINT pk_event PRIMARY KEY (event_number),
	CONSTRAINT fk_event_interest_group FOREIGN KEY (group_number) REFERENCES interest_group(group_number),
	CONSTRAINT chk_event CHECK (duration>=30)
);

CREATE TABLE member_group(
member_number INT,
group_number INT,
CONSTRAINT pk_member_group PRIMARY KEY (member_number, group_number),
CONSTRAINT fk_member_group_interest_group FOREIGN KEY (group_number) REFERENCES interest_group(group_number),
CONSTRAINT fk_member_group_member FOREIGN KEY (member_number) REFERENCES member(member_number)
);

CREATE TABLE member_event(
member_number INT,
event_number INT,
CONSTRAINT pk_member_event PRIMARY KEY (member_number, event_number),
CONSTRAINT fk_member_event_member FOREIGN KEY (member_number) REFERENCES member(member_number),
CONSTRAINT fk_member_event_event FOREIGN KEY (event_number) REFERENCES event(event_number)
);


COMMIT;

INSERT INTO member (last_name, first_name, email_address, date_of_birth, has_reminders)
VALUES ('Friedmann', 'Sean', 'seanfriedmann@yahoo.com', '05-04-1999', 1), 
('Whitcomb', 'Darr', 'darrwhitcomb@outlook.com', '09-12-1990', 0),
('Measor', 'Ben', 'benmeasor@gmail.com', '03-29-1989', 1),
('Rivera', 'Maria', 'mariarivera@hotmail.com', '03-19-2000', 0),
('Long', 'Peri', 'perilong@icloud.com', '03-20-1998', 1),
('Heberling', 'Dan', 'danheberling@army.com', '09-04-1990', 1),
('Nye', 'Kevin', 'kevinnye@gmail.com', '10-08-1985', 0),
('Detwiller', 'Colin', 'colindetwiller@gmail.com', '05-29-2000', 1);

UPDATE member SET phone_number = '440-123-4567' 
WHERE last_name = 'Friedmann';



INSERT INTO interest_group (group_name, total_members)
VALUES ('Foosball Group', 1),
('D&D Group', 2),
('Baseball Group', 7)

--SELECT * FROM interest_group
--SELECT * FROM event
INSERT INTO event (event_name, event_description, start_date_and_time, duration, group_number,total_members, member_number)
VALUES ('Foosball Tournament', 'Intense Foosball Championship Tournament', '2022-10-20 06:00:00', 45, (SELECT group_number FROM interest_group WHERE group_name = 'Foosball Group'), 1, (SELECT member_number FROM member WHERE last_name = 'Friedmann')),
('D&D Raid', 'Dungeons and Dragons session at Tech Elevator.', '2022-10-27 12:00:00', 60, (SELECT group_number FROM interest_group WHERE group_name = 'D&D Group'), 1, (SELECT member_number FROM member WHERE last_name = 'Whitcomb')),
('World Series Watch Party', 'We will watch the Guardians win the World Series', '2022-11-23 8:00:00', 90, (SELECT group_number FROM interest_group WHERE group_name = 'Baseball Group'), 1, (SELECT member_number FROM member WHERE last_name = 'Nye')),
('Foosball World Championship', 'The Greatest Foosballers from around the world meet for one final match', '2022-12-31 6:00:00', 120, (SELECT group_number FROM interest_group WHERE group_name = 'Foosball Group'), 1, (SELECT member_number FROM member WHERE last_name = 'Heberling'));

SELECT * FROM member;
SELECT * FROM interest_group;
SELECT * FROM event