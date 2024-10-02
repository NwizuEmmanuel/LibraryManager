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
        [ReturnDate] DATE,
        [LibrarianId] INT NOT NULL,
        FOREIGN KEY ([BookId]) REFERENCES [Books]([BookId]),
        FOREIGN KEY ([StudentId]) REFERENCES [Students]([StudentId]),
        FOREIGN KEY ([LibrarianId]) REFERENCES [Librarians]([LibrarianId])
    );
END

-- Enable explicit ID insertion for Books table
SET IDENTITY_INSERT [Books] ON;

-- Insert data into Books table with explicit IDs
INSERT INTO [Books] (BookId, Title, ISBN, Authors, Category, Publisher, PublishedDate)
VALUES 
(1, 'The Great Gatsby', '1234567890123', 'F. Scott Fitzgerald', 'Fiction', 'Scribner', '1925-04-10'),
(2, '1984', '1234567890124', 'George Orwell', 'Dystopian', 'Secker & Warburg', '1949-06-08'),
(3, 'To Kill a Mockingbird', '1234567890125', 'Harper Lee', 'Fiction', 'J.B. Lippincott & Co.', '1960-07-11'),
(4, 'Moby Dick', '1234567890126', 'Herman Melville', 'Adventure', 'Harper & Brothers', '1851-10-18'),
(5, 'Pride and Prejudice', '1234567890127', 'Jane Austen', 'Romance', 'T. Egerton', '1813-01-28'),
(6, 'The Catcher in the Rye', '1234567890128', 'J.D. Salinger', 'Fiction', 'Little, Brown and Company', '1951-07-16'),
(7, 'Brave New World', '1234567890129', 'Aldous Huxley', 'Dystopian', 'Chatto & Windus', '1932-08-30'),
(8, 'The Hobbit', '1234567890130', 'J.R.R. Tolkien', 'Fantasy', 'George Allen & Unwin', '1937-09-21'),
(9, 'War and Peace', '1234567890131', 'Leo Tolstoy', 'Historical Fiction', 'The Russian Messenger', '1869-01-01'),
(10, 'Crime and Punishment', '1234567890132', 'Fyodor Dostoevsky', 'Philosophical Fiction', 'The Russian Messenger', '1866-01-01');

-- Disable explicit ID insertion for Books table
SET IDENTITY_INSERT [Books] OFF;

-- Enable explicit ID insertion for Students table
SET IDENTITY_INSERT [Students] ON;

-- Insert data into Students table with explicit IDs
INSERT INTO [Students] (StudentId, FirstName, LastName, Sex, Department, Email, PhoneNumber, Address)
VALUES 
(1, 'John', 'Doe', 'Male', 'Computer Science', 'john.doe@example.com', '555-1234', '123 Main St'),
(2, 'Jane', 'Smith', 'Female', 'History', 'jane.smith@example.com', '555-2345', '456 Oak Ave'),
(3, 'Michael', 'Johnson', 'Male', 'Physics', 'michael.johnson@example.com', '555-3456', '789 Maple Rd'),
(4, 'Emily', 'Davis', 'Female', 'Mathematics', 'emily.davis@example.com', '555-4567', '101 Pine Ln'),
(5, 'Chris', 'Brown', 'Male', 'Engineering', 'chris.brown@example.com', '555-5678', '202 Cedar Dr'),
(6, 'Anna', 'Wilson', 'Female', 'Biology', 'anna.wilson@example.com', '555-6789', '303 Birch St'),
(7, 'David', 'Taylor', 'Male', 'Chemistry', 'david.taylor@example.com', '555-7890', '404 Spruce Blvd'),
(8, 'Laura', 'Martinez', 'Female', 'Literature', 'laura.martinez@example.com', '555-8901', '505 Elm St'),
(9, 'James', 'Anderson', 'Male', 'Art', 'james.anderson@example.com', '555-9012', '606 Pine St'),
(10, 'Sarah', 'Lee', 'Female', 'Music', 'sarah.lee@example.com', '555-0123', '707 Oak Dr');

-- Disable explicit ID insertion for Students table
SET IDENTITY_INSERT [Students] OFF;

-- Enable explicit ID insertion for Librarians table
SET IDENTITY_INSERT [Librarians] ON;

-- Insert data into Librarians table with explicit IDs
INSERT INTO [Librarians] (LibrarianId, FirstName, LastName, Email, PhoneNumber, Password)
VALUES 
(1, 'Alice', 'Williams', 'alice.williams@example.com', '555-9876', 'password123'),
(2, 'Bob', 'Miller', 'bob.miller@example.com', '555-8765', 'password234'),
(3, 'Carol', 'Jones', 'carol.jones@example.com', '555-7654', 'password345'),
(4, 'David', 'Thomas', 'david.thomas@example.com', '555-6543', 'password456'),
(5, 'Emma', 'Brown', 'emma.brown@example.com', '555-5432', 'password567'),
(6, 'Frank', 'Garcia', 'frank.garcia@example.com', '555-4321', 'password678'),
(7, 'Grace', 'Martinez', 'grace.martinez@example.com', '555-3210', 'password789'),
(8, 'Hank', 'Rodriguez', 'hank.rodriguez@example.com', '555-2109', 'password890'),
(9, 'Ivy', 'Wilson', 'ivy.wilson@example.com', '555-1098', 'password901'),
(10, 'Jack', 'Moore', 'jack.moore@example.com', '555-0987', 'password012');

-- Disable explicit ID insertion for Librarians table
SET IDENTITY_INSERT [Librarians] OFF;

SET IDENTITY_INSERT [Borrows] ON;
-- Insert data into Borrows table with explicit IDs, some with NULL ReturnDate
INSERT INTO [Borrows] (BorrowId, BookId, StudentId, BorrowDate, DueDate, ReturnDate, LibrarianId)
VALUES 
(1, 1, 1, '2024-09-01', '2024-09-15', '2024-09-14', 1),
(2, 2, 2, '2024-09-02', '2024-09-16', '2024-09-15', 2),
(3, 3, 3, '2024-09-03', '2024-09-17', NULL, 3), -- No return date
(4, 4, 4, '2024-09-04', '2024-09-18', '2024-09-17', 4),
(5, 5, 5, '2024-09-05', '2024-09-19', NULL, 5), -- No return date
(6, 6, 6, '2024-09-06', '2024-09-20', '2024-09-19', 6),
(7, 7, 7, '2024-09-07', '2024-09-21', NULL, 7), -- No return date
(8, 8, 8, '2024-09-08', '2024-09-22', '2024-09-21', 8),
(9, 9, 9, '2024-09-09', '2024-09-23', '2024-09-22', 9),
(10, 10, 10, '2024-09-10', '2024-09-24', NULL, 10); -- No return date

-- Disable explicit ID insertion for Borrows table
SET IDENTITY_INSERT [Borrows] OFF;