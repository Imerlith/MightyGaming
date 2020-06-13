INSERT INTO PERSON(FirstName, LastName) VALUES ('Wiktor', 'Androsiuk');
INSERT INTO PERSON(FirstName, LastName) VALUES ('Przemysław', 'Gołębski');
INSERT INTO PERSON(FirstName, LastName) VALUES ('Paweł', 'Kalbarczyk');
INSERT INTO PERSON(FirstName, LastName) VALUES ('Jakub', 'Dzieciątko');

INSERT INTO EMPLOYEE(HireDate, Person_IdPerson) VALUES (current_date, 1);
INSERT INTO EMPLOYEE(HireDate, Person_IdPerson) VALUES (current_date, 2);

INSERT INTO Customer(PhoneNumber, Email, Person_IdPerson) VALUES ('123456789', 'pawelkalbarczyk@gmail.com', 3);
INSERT INTO Customer(PhoneNumber, Email, Person_IdPerson) VALUES ('987654321', 'jakubdzieciatko@gmail.com', 4);

INSERT INTO "Order"(Name, Description, Cost) VALUES ('Drinks', 'Soft drinks inluding cola, pepsi, sprite, lemonade', 30);
INSERT INTO "Order"(Name, Description, Cost) VALUES ('Snacks', 'Chips, sweets, peanuts', 42.9);
INSERT INTO "Order"(Name, Description, Cost) VALUES ('Pizza Party', 'Selection of pizzas for whole group', 79.99);

INSERT INTO Equipment(Name, PurchaseDate, Type, Producent, WarrantyDate) VALUES ('PC', current_date, 'Gaming Machine', 'Lenovo', current_date);
INSERT INTO Equipment(Name, PurchaseDate, Type, Producent, WarrantyDate) VALUES ('PC', current_date, 'Gaming Machine', 'Alienware', current_date);
INSERT INTO Equipment(Name, PurchaseDate, Type, Producent, WarrantyDate) VALUES ('Dell Monitor', current_date, 'Monitor', 'Dell', current_date);
INSERT INTO Equipment(Name, PurchaseDate, Type, Producent, WarrantyDate) VALUES ('PS5', current_date, 'Console', 'Sony', current_date);
INSERT INTO Equipment(Name, PurchaseDate, Type, Producent, WarrantyDate) VALUES ('XBOX', current_date, 'Console', 'Microsoft', current_date);


INSERT INTO Station(Specialization, InspectionDate) VALUES ('Esport', current_date);
INSERT INTO Station(Specialization, InspectionDate) VALUES ('Esport', current_date);
INSERT INTO Station(Specialization, InspectionDate) VALUES ('Esport', current_date);
INSERT INTO Station(Specialization, InspectionDate) VALUES ('Casual', current_date);
INSERT INTO Station(Specialization, InspectionDate) VALUES ('Family', current_date);

INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (1, 1);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (1, 2);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (1, 3);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (1, 3);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (2, 2);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (3, 2);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (3, 3);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (3, 3);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (4, 4);
INSERT INTO Stations_Equipment(Station_StationNumber, Equipment_SerialNumber) VALUES (5, 5);


INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 3, 1, 50, 1, 5, 'opinion1');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 12, 2, 200, 1, 5, 'opinion2');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 4, 1, 50, 1, 4, 'opinion3');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 1, 1, 50, 1, 2, 'opinion4');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 3, 2, 120, 1, 5, 'opinion5');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 3, 1, 50, 2, 6, 'opinion6');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 12, 2, 200, 2, 1, 'opinion7');
INSERT INTO Booking(Date, Hour, RequiredEmployees, NumberOfPeople, Cost, Customer_IdCustomer, Opinion, Notes) VALUES (current_date, current_time, 4, 1, 50, 2, 2, 'opinion8');


INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (1, 1);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (2, 1);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (2, 2);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (3, 2);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (4, 1);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (4, 4);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (5, 1);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (6, 1);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (6, 3);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (7, 3);
INSERT INTO Stations_Bookings(Booking_IdBooking, Station_StationNumber) VALUES (8, 4);

INSERT INTO Extras(Booking_IdBooking, Order_IdOrder) VALUES (2, 1);
INSERT INTO Extras(Booking_IdBooking, Order_IdOrder) VALUES (5, 2);
INSERT INTO Extras(Booking_IdBooking, Order_IdOrder) VALUES (7, 3);

INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (1, 1);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (2, 1);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (2, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (3, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (4, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (5, 1);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (5, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (6, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (7, 1);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (7, 2);
INSERT INTO Assignments(Booking_IdBooking, Employee_IdEmployee) VALUES (8, 1);




