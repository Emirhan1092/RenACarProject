-- Cars tablosunu oluştur
DROP TABLE IF EXISTS Cars;

CREATE TABLE Cars (
    CarId INT PRIMARY KEY,
    CarName VARCHAR(255),
    BrandId INT,
    ColorId INT,
    ModelYear INT,
    DailyPrice DECIMAL(10,2),
    Descriptions VARCHAR(255)
);

-- Cars tablosuna veri ekle
INSERT INTO Cars (CarId, CarName, BrandId, ColorId, ModelYear, DailyPrice, Descriptions) VALUES 
(1, 'Toyota Camry', 1, 1, 2022, 100.00, 'Toyota Camry 2022 Red'),
(2, 'Honda Civic', 2, 2, 2021, 90.00, 'Honda Civic 2021 Blue'),
(3, 'Ford Focus', 3, 3, 2020, 95.00, 'Ford Focus 2020 Black'),
(4, 'Porsche Panamera', 4, 4, 2020, 135.00, 'Porsche Panamera 2020 White'),
(5, 'Lamborghini Urus', 5, 5, 2021, 125.00, 'Lamborghini Urus 2021 Yellow');

-- Brands tablosunu oluştur
DROP TABLE IF EXISTS Brands;

CREATE TABLE Brands (
    Id INT PRIMARY KEY,
    BrandName VARCHAR(255)
);

-- Brands tablosuna veri ekle
INSERT INTO Brands (Id, BrandName) VALUES 
(1, 'Toyota'),
(2, 'Honda'),
(3, 'Ford'),
(4, 'Porsche'),
(5, 'Lamborghini');

-- Colors tablosunu oluştur
DROP TABLE IF EXISTS Colors;

CREATE TABLE Colors (
    Id INT PRIMARY KEY,
    ColorName VARCHAR(255)
);

-- Colors tablosuna veri ekle
INSERT INTO Colors (Id, ColorName) VALUES 
(1, 'Red'),
(2, 'Blue'),
(3, 'Black'),
(4, 'White'),
(5, 'Yellow');

-- Customers tablosunu oluştur
DROP TABLE IF EXISTS Customers;

CREATE TABLE Customers (
    Id INT PRIMARY KEY,
    CompanyName VARCHAR(255)
);

-- Customers tablosuna veri ekle
INSERT INTO Customers (Id, CompanyName) VALUES
(1, 'Erdin LTD. ŞTİ.'),
(2, 'Demiroğ LTD. ŞTİ.');

-- Rentals tablosunu oluştur
DROP TABLE IF EXISTS Rentals;

CREATE TABLE Rentals (
    RentalId INT PRIMARY KEY,
    CarId INT,
    CustomerId INT,
    RentDate DATETIME,
    ReturnDate DATETIME
);

-- Rentals tablosuna veri ekle
INSERT INTO Rentals (RentalId, CarId, CustomerId, RentDate, ReturnDate) VALUES
(1, 1, 1, '2024-02-27', NULL),
(2, 3, 2, '2024-02-27', NULL),
(3, 5, 2, '2024-02-27', NULL),
(4, 4, 1, '2024-02-15', NULL);


-- Users tablosunu oluşr
DROP TABLE IF EXISTS Users;
CREATE TABLE Users (
    Id INT PRIMARY KEY,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Email VARCHAR(255),
    PasswordHash VARCHAR(255)
);

-- Users tablosuna veri ekle
INSERT INTO Users (Id, FirstName, LastName, Email, PasswordHash) VALUES
(1, 'Muhammed', 'Erdin', 'BLABLA@gmail.com', '12345'),
(2, 'Engin', 'Demiroğ', 'blabla@gmail.com', '12345');

-- Diğer tabloları oluştur ve veri ekle
