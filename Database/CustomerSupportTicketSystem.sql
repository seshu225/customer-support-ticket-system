Create database: SupportTicketDB

Tables
1. Users
CREATE TABLE Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL, -- User / Admin
    CreatedAt DATETIME NOT NULL
);
2. Tickets
CREATE TABLE Tickets (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TicketNumber VARCHAR(20) NOT NULL,
    Subject VARCHAR(200) NOT NULL,
    Description TEXT NOT NULL,
    Priority VARCHAR(20) NOT NULL,
    Status VARCHAR(20) NOT NULL,
    CreatedBy INT NOT NULL,
    AssignedTo INT NULL,
    CreatedAt DATETIME NOT NULL,
    FOREIGN KEY (CreatedBy) REFERENCES Users(Id),
    FOREIGN KEY (AssignedTo) REFERENCES Users(Id)
);
3. TicketStatusHistory
CREATE TABLE TicketStatusHistory (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TicketId INT NOT NULL,
    OldStatus VARCHAR(20),
    NewStatus VARCHAR(20),
    UpdatedBy INT NOT NULL,
    UpdatedAt DATETIME NOT NULL,
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id),
    FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
);
4. TicketComments
CREATE TABLE TicketComments (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TicketId INT NOT NULL,
    Comment TEXT NOT NULL,
    IsInternal BOOLEAN NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME NOT NULL,
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id),
    FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
);