USE master
go

IF EXISTS (SELECT 'True' FROM   sys.databases WHERE  NAME = 'school_management')
  BEGIN
      ALTER DATABASE school_management SET single_user WITH ROLLBACK immediate
      DROP DATABASE school_management
  END

go

CREATE DATABASE school_management

go

ALTER AUTHORIZATION ON DATABASE::school_management TO sa

USE school_management

go

CREATE type NAMES FROM VARCHAR(256);

go

CREATE TABLE admins
	(
		id	INT IDENTITY(1, 1),
		id_admin AS 'A' + RIGHT('000' + CAST(id AS VARCHAR(3)), 3) PERSISTED,
        username	NAMES UNIQUE,
		full_name	NAMES NOT NULL,
		email		NAMES NOT NULL,
        password	NAMES NOT NULL,
		photo		IMAGE,
		role		NAMES DEFAULT 'admin',
        secret_word NAMES NOT NULL
	);

CREATE TABLE teachers
	(
		id	INT IDENTITY(1, 1),
		id_teacher AS 'T' + RIGHT('000' + CAST(id AS VARCHAR(3)), 3) PERSISTED,
        username	NAMES UNIQUE,
		full_name	NAMES NOT NULL,
		email		NAMES NOT NULL,
        password	NAMES NOT NULL,
		photo		IMAGE,
		role		NAMES DEFAULT 'teacher',
        secret_word NAMES NOT NULL,

		CONSTRAINT PK_teachers PRIMARY KEY(id_teacher)

	);

CREATE TABLE students
	(
		id	INT IDENTITY(1, 1),
		id_student AS 'S' + RIGHT('000' + CAST(id AS VARCHAR(3)), 3) PERSISTED,
        username	NAMES UNIQUE,
		full_name	NAMES NOT NULL,
		email		NAMES NOT NULL,
        password	NAMES NOT NULL,
		photo		IMAGE,
		role		NAMES DEFAULT 'student',
        secret_word NAMES NOT NULL,

		CONSTRAINT PK_students PRIMARY KEY(id_student)

	);


INSERT INTO admins(username, full_name, email, password, role, secret_word)
VALUES ('admin', 'administrator', 'admin@gmail.com', 'admin', 'admin', 'admin')

INSERT INTO teachers(username, full_name, email, password, role, secret_word)
VALUES ('teacher', 'teacher', 'teacher@gmail.com', 'teacher', 'teacher', 'teacher')

INSERT INTO students(username, full_name, email, password, role, secret_word)
VALUES ('student', 'student', 'student@gmail.com', 'student', 'student', 'student')

SELECT * FROM admins
SELECT * FROM  teachers
SELECT * FROM  students

GO

CREATE VIEW users_view AS
	SELECT id_admin AS id_user, username, full_name, email, password, photo, role, secret_word FROM admins
	UNION ALL
	SELECT id_teacher AS id_user, username, full_name, email, password, photo, role, secret_word FROM teachers
	UNION ALL
	SELECT id_student AS id_user, username, full_name, email, password, photo, role, secret_word FROM students

GO

SELECT * FROM users_view