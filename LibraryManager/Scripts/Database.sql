-- Should be deleted on production. from here
USE [master]

IF DB_ID('library_db') IS NULL CREATE DATABASE library_db;
Go

-- Use the LibraryDB database
USE [library_db];
GO

-- Category Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Categories' AND xtype='U')
BEGIN
	CREATE TABLE [Categories](
		[ID] INT IDENTITY(1,1) PRIMARY KEY,
		[Name] NVARCHAR(225)
	);
END

-- Publisher Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Publishers' AND xtype='U')
BEGIN
	CREATE TABLE [Publishers](
		[ID] INT IDENTITY(1,1) PRIMARY KEY,
		[Name] NVARCHAR(225)
	);
END

-- Books Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Books' AND xtype = 'U')
BEGIN
    CREATE TABLE [Books] (
        [BookId] INT IDENTITY(1,1) PRIMARY KEY,
        [Title] VARCHAR(255) NOT NULL,
        [ISBN] VARCHAR(13) NOT NULL UNIQUE,
		[Authors] VARCHAR(255) NOT NULL,
        [CategoryID] INT NOT NULL,
        [PublisherID] INT NOT NULL,
        [PublishedDate] DATE NOT NULL,
		[Quantity] INT NOT NULL,
		FOREIGN KEY ([PublisherID]) REFERENCES [Publishers]([ID]),
		FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([ID])
    );
END

-- Students Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Students' AND xtype = 'U')
BEGIN
    CREATE TABLE [Students] (
        [StudentId] INT PRIMARY KEY,
        [FirstName] VARCHAR(100) NOT NULL,
        [LastName] VARCHAR(100) NOT NULL,
        [Sex] VARCHAR(10) NOT NULL,
        [Department] VARCHAR(255) NOT NULL,
        [Email] VARCHAR(100) UNIQUE,
        [PhoneNumber] VARCHAR(15),
        [Address] VARCHAR(255) NOT NULL,
    );
END

-- Librarians Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Librarians' AND xtype = 'U')
BEGIN
    CREATE TABLE [Librarians] (
        [LibrarianId] INT IDENTITY(1,1) PRIMARY KEY,
        [FirstName] VARCHAR(100) NOT NULL,
        [LastName] VARCHAR(100) NOT NULL,
        [Email] VARCHAR(100) UNIQUE NOT NULL,
        [PhoneNumber] VARCHAR(15) NOT NULL,
        [Password] VARCHAR(50) NOT NULL,
    );
END

-- Borrows Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Borrows' AND xtype = 'U')
BEGIN
    CREATE TABLE [Borrows] (
        [BorrowId] INT IDENTITY(1,1) PRIMARY KEY,
        [BookId] INT NOT NULL,
        [StudentId] INT NOT NULL,
        [BorrowDate] DATE NOT NULL,
        [DueDate] DATE NOT NULL,
        [ReturnDate] DATE,
        [LibrarianId] INT NOT NULL,
        FOREIGN KEY ([BookId]) REFERENCES [Books]([BookId]),
        FOREIGN KEY ([StudentId]) REFERENCES [Students]([StudentId]),
        FOREIGN KEY ([LibrarianId]) REFERENCES [Librarians]([LibrarianId])
    );
END

ALTER TABLE Borrows
ADD CONSTRAINT UQ_Student_Book UNIQUE (BookId, StudentId, ReturnDate);
GO

INSERT INTO [Librarians]([FirstName],[LastName],[Email],[PhoneNumber],[Password])
VALUES ('Emmanuel','Okoro','emmanuel.okoro@yahoo.com','123-234','passowrd123'),
('Lindy','Chukwuemela','lindy.chukwuemela@icloud.com','234-222','password234')
GO

INSERT INTO [Librarians]([FirstName],[LastName],[Email],[PhoneNumber],[Password])
VALUES
('Mike','Obi','mike.obi@mail.com','234-222','mike@obi')
GO