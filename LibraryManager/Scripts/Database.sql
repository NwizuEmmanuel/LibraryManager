-- Use the LibraryDB database
USE [LibraryDB];
GO

-- Books Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Books' AND xtype = 'U')
BEGIN
    CREATE TABLE [Books] (
        [BookId] INT IDENTITY(1,1) PRIMARY KEY,
        [Title] VARCHAR(255) NOT NULL,
        [ISBN] VARCHAR(13) UNIQUE NOT NULL,
		[Authors] VARCHAR(255) NOT NULL,
        [Category] VARCHAR(255) NOT NULL,
        [Publisher] VARCHAR(255) NOT NULL,
        [PublishedDate] DATE NOT NULL,
    );
END

-- Students Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Students' AND xtype = 'U')
BEGIN
    CREATE TABLE [Students] (
        [StudentId] INT IDENTITY(1,1) PRIMARY KEY,
        [FirstName] VARCHAR(100) NOT NULL,
        [LastName] VARCHAR(100) NOT NULL,
        [Sex] VARCHAR(10) NOT NULL,
        [Department] VARCHAR(255) NOT NULL,
        [Email] VARCHAR(100) UNIQUE NOT NULL,
        [PhoneNumber] VARCHAR(15) NOT NULL,
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

-- Loans Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Borrows' AND xtype = 'U')
BEGIN
    CREATE TABLE [Borrows] (
        [BorrowId] INT IDENTITY(1,1) PRIMARY KEY,
        [BookId] INT NOT NULL,
        [StudentId] INT NOT NULL,
        [BorrowDate] DATE NOT NULL,
        [DueDate] DATE NOT NULL,
        [ReturnDate] DATE NOT NULL,
        [LibrarianId] INT NOT NULL,
        FOREIGN KEY ([BookId]) REFERENCES [Books]([BookId]),
        FOREIGN KEY ([StudentId]) REFERENCES [Students]([StudentId]),
        FOREIGN KEY ([LibrarianId]) REFERENCES [Librarians]([LibrarianId])
    );
END
