/* ===============================
   Datenbank: LibraryDB
   =============================== */
CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO

/* ===============================
   Tabelle: Users
   =============================== */
CREATE TABLE Users
(
    UserId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Pin NVARCHAR(20) NOT NULL,
    Role NVARCHAR(20) NOT NULL -- 'User' oder 'Admin'
);

/* ===============================
   Tabelle: Books
   =============================== */
CREATE TABLE Books
(
    BookId INT PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    IsAvailable BIT NOT NULL
);

/* ===============================
   Tabelle: Loans
   =============================== */
CREATE TABLE Loans
(
    LoanId INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL,
    BookId INT NOT NULL,
    BorrowedAt DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnedAt DATE NULL,

    CONSTRAINT FK_Loans_Users FOREIGN KEY (UserId)
        REFERENCES Users(UserId),

    CONSTRAINT FK_Loans_Books FOREIGN KEY (BookId)
        REFERENCES Books(BookId)
);

/* ===============================
   Beispieldaten: Users
   =============================== */
INSERT INTO Users (UserId, Name, Pin, Role) VALUES
(1, 'Max Mustermann', '1234', 'User'),
(2, 'Erika Musterfrau', '4321', 'User'),
(3, 'Admin Anna', '0000', 'Admin');

/* ===============================
   Beispieldaten: Books
   =============================== */
INSERT INTO Books (BookId, Title, Author, IsAvailable) VALUES
(1, 'Clean Code', 'Robert C. Martin', 0),
(2, 'The Pragmatic Programmer', 'Andrew Hunt', 1),
(3, 'Design Patterns', 'Erich Gamma', 1),
(4, 'C# in Depth', 'Jon Skeet', 0),
(5, 'Introduction to Algorithms', 'Thomas H. Cormen', 1);

/* ===============================
   Beispieldaten: Loans
   =============================== */
INSERT INTO Loans (UserId, BookId, BorrowedAt, DueDate, ReturnedAt) VALUES
-- Aktive Ausleihe
(1, 1, '2026-01-10', '2026-01-24', NULL),

-- Überfällige Ausleihe
(1, 4, '2025-12-20', '2026-01-03', NULL),

-- Bereits zurückgegeben
(2, 2, '2026-01-01', '2026-01-15', '2026-01-10');
