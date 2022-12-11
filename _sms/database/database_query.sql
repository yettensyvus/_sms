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

CREATE TABLE users
	(
		id_users	INT PRIMARY KEY IDENTITY(100, 1),
        username	NAMES UNIQUE,
		full_name	NAMES NOT NULL,
		email		NAMES NOT NULL,
        password	NAMES NOT NULL,
		photo		IMAGE,
		role		NAMES DEFAULT 'user',
        secret_word NAMES NOT NULL
	);
