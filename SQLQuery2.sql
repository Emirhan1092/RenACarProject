-- Kullanıcılar tablosu
CREATE TABLE Users
(
    Id INT NOT NULL PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL
);

-- Müşteriler tablosu
CREATE TABLE Customers
(
    UserId INT NOT NULL PRIMARY KEY,
    CompanyName NVARCHAR(100) NOT NULL,
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

-- Arabanın kiralanma bilgisini tutan tablo
CREATE TABLE Rentals
(
    Id INT NOT NULL PRIMARY KEY,
    CarId INT NOT NULL,
    CustomerId INT NOT NULL,
    RentDate DATETIME NOT NULL,
    ReturnDate DATETIME,
    FOREIGN KEY (CarId) REFERENCES Cars(Id),
    FOREIGN KEY (CustomerId) REFERENCES Customers(UserId)
);
