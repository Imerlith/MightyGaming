-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-06-11 17:45:40.996

-- tables
-- Table: Assignments
CREATE TABLE Assignments (
    IdAssignments serial  NOT NULL,
    Booking_IdBooking int  NOT NULL,
    Employee_IdEmployee int  NOT NULL,
    CONSTRAINT Assignments_pk PRIMARY KEY (IdAssignments)
);

-- Table: Booking
CREATE TABLE Booking (
    IdBooking serial  NOT NULL,
    Date date  NOT NULL,
    Hour time  NOT NULL,
    Opinion int NULL,
    Notes varchar(255) NULL,
    RequiredEmployees int  NOT NULL,
    NumberOfPeople int  NOT NULL,
    Cost decimal(5,2)  NOT NULL,
    Customer_IdCustomer int  NOT NULL,
    CONSTRAINT Booking_pk PRIMARY KEY (IdBooking)
);

-- Table: Customer
CREATE TABLE Customer (
    IdCustomer serial  NOT NULL,
    PhoneNumber varchar(12)  NOT NULL,
    Email varchar(50)  NOT NULL,
    Person_IdPerson int  NOT NULL,
    CONSTRAINT Customer_pk PRIMARY KEY (IdCustomer)
);

-- Table: Employee
CREATE TABLE Employee (
    IdEmployee serial  NOT NULL,
    HireDate date  NOT NULL,
    Person_IdPerson int  NOT NULL,
    CONSTRAINT Employee_pk PRIMARY KEY (IdEmployee)
);

-- Table: Equipment
CREATE TABLE Equipment (
    SerialNumber serial  NOT NULL,
    Name varchar(75)  NOT NULL,
    PurchaseDate date  NOT NULL,
    Type varchar(75)  NOT NULL,
    Producent varchar(150)  NOT NULL,
    WarrantyDate date  NOT NULL,
    CONSTRAINT Equipment_pk PRIMARY KEY (SerialNumber)
);

-- Table: Extras
CREATE TABLE Extras (
    IdExtras serial  NOT NULL,
    Booking_IdBooking int  NOT NULL,
    Order_IdOrder int  NOT NULL,
    CONSTRAINT Extras_pk PRIMARY KEY (IdExtras)
);

-- Table: Order
CREATE TABLE "Order" (
    IdOrder serial  NOT NULL,
    Name varchar(75)  NOT NULL,
    Description varchar(255)  NOT NULL,
    Cost decimal(5,2)  NOT NULL,
    CONSTRAINT Order_pk PRIMARY KEY (IdOrder)
);

-- Table: Person
CREATE TABLE Person (
    IdPerson serial  NOT NULL,
    FirstName varchar(75)  NOT NULL,
    LastName varchar(75)  NOT NULL,
    CONSTRAINT Person_pk PRIMARY KEY (IdPerson)
);

-- Table: Station
CREATE TABLE Station (
    StationNumber serial  NOT NULL,
    Specialization varchar(255)  NOT NULL,
    InspectionDate date  NOT NULL,
    CONSTRAINT Station_pk PRIMARY KEY (StationNumber)
);

-- Table: Stations_Bookings
CREATE TABLE Stations_Bookings (
    Id serial  NOT NULL,
    Booking_IdBooking int  NOT NULL,
    Station_StationNumber int  NOT NULL,
    CONSTRAINT Stations_Bookings_pk PRIMARY KEY (Id)
);

-- Table: Stations_Equipment
CREATE TABLE Stations_Equipment (
    Id serial  NOT NULL,
    Station_StationNumber int  NOT NULL,
    Equipment_SerialNumber int  NOT NULL,
    CONSTRAINT Stations_Equipment_pk PRIMARY KEY (Id)
);

-- foreign keys
-- Reference: Assignments_Booking (table: Assignments)
ALTER TABLE Assignments ADD CONSTRAINT Assignments_Booking
    FOREIGN KEY (Booking_IdBooking)
    REFERENCES Booking (IdBooking)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Assignments_Employee (table: Assignments)
ALTER TABLE Assignments ADD CONSTRAINT Assignments_Employee
    FOREIGN KEY (Employee_IdEmployee)
    REFERENCES Employee (IdEmployee)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Booking_Customer (table: Booking)
ALTER TABLE Booking ADD CONSTRAINT Booking_Customer
    FOREIGN KEY (Customer_IdCustomer)
    REFERENCES Customer (IdCustomer)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Customer_Person (table: Customer)
ALTER TABLE Customer ADD CONSTRAINT Customer_Person
    FOREIGN KEY (Person_IdPerson)
    REFERENCES Person (IdPerson)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Employee_Person (table: Employee)
ALTER TABLE Employee ADD CONSTRAINT Employee_Person
    FOREIGN KEY (Person_IdPerson)
    REFERENCES Person (IdPerson)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Extras_Booking (table: Extras)
ALTER TABLE Extras ADD CONSTRAINT Extras_Booking
    FOREIGN KEY (Booking_IdBooking)
    REFERENCES Booking (IdBooking)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Extras_Order (table: Extras)
ALTER TABLE Extras ADD CONSTRAINT Extras_Order
    FOREIGN KEY (Order_IdOrder)
    REFERENCES "Order" (IdOrder)
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Stations_Bookings_Booking (table: Stations_Bookings)
ALTER TABLE Stations_Bookings ADD CONSTRAINT Stations_Bookings_Booking
    FOREIGN KEY (Booking_IdBooking)
    REFERENCES Booking (IdBooking)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Stations_Bookings_Station (table: Stations_Bookings)
ALTER TABLE Stations_Bookings ADD CONSTRAINT Stations_Bookings_Station
    FOREIGN KEY (Station_StationNumber)
    REFERENCES Station (StationNumber)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Stations_Equipment_Equipment (table: Stations_Equipment)
ALTER TABLE Stations_Equipment ADD CONSTRAINT Stations_Equipment_Equipment
    FOREIGN KEY (Equipment_SerialNumber)
    REFERENCES Equipment (SerialNumber)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- Reference: Stations_Equipment_Station (table: Stations_Equipment)
ALTER TABLE Stations_Equipment ADD CONSTRAINT Stations_Equipment_Station
    FOREIGN KEY (Station_StationNumber)
    REFERENCES Station (StationNumber)  
    NOT DEFERRABLE 
    INITIALLY IMMEDIATE
;

-- End of file.

