-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-06-11 17:45:40.996

-- foreign keys
ALTER TABLE Assignments
    DROP CONSTRAINT Assignments_Booking;

ALTER TABLE Assignments
    DROP CONSTRAINT Assignments_Employee;

ALTER TABLE Booking
    DROP CONSTRAINT Booking_Customer;

ALTER TABLE Customer
    DROP CONSTRAINT Customer_Person;

ALTER TABLE Employee
    DROP CONSTRAINT Employee_Person;

ALTER TABLE Extras
    DROP CONSTRAINT Extras_Booking;

ALTER TABLE Extras
    DROP CONSTRAINT Extras_Order;

ALTER TABLE Stations_Bookings
    DROP CONSTRAINT Stations_Bookings_Booking;

ALTER TABLE Stations_Bookings
    DROP CONSTRAINT Stations_Bookings_Station;

ALTER TABLE Stations_Equipment
    DROP CONSTRAINT Stations_Equipment_Equipment;

ALTER TABLE Stations_Equipment
    DROP CONSTRAINT Stations_Equipment_Station;

-- tables
DROP TABLE Assignments;

DROP TABLE Booking;

DROP TABLE Customer;

DROP TABLE Employee;

DROP TABLE Equipment;

DROP TABLE Extras;

DROP TABLE "Order";

DROP TABLE Person;

DROP TABLE Station;

DROP TABLE Stations_Bookings;

DROP TABLE Stations_Equipment;

-- End of file.

