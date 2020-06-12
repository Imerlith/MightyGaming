using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MightyClient.Models
{
    class SampleData
    {
        public List<Person> GetPeople()
        {
            List<Person> People = new List<Person>();

            People.Add( new Person { Idperson = 1, Firstname = "Adam", Lastname = "Kamilowicz" });
            People.Add(new Person { Idperson = 2, Firstname = "Piotr", Lastname = "Adamowicz" });
            People.Add(new Person { Idperson = 3, Firstname = "Kamil", Lastname = "Pawłowski" });
            People.Add(new Person { Idperson = 4, Firstname = "Paweł", Lastname = "Janowski" });
            People.Add(new Person { Idperson = 5, Firstname = "Jan", Lastname = "Piotrowski" });

            People.Add(new Person { Idperson = 6, Firstname = "Agent", Lastname = "Smith" });
            People.Add(new Person { Idperson = 7, Firstname = "Papa", Lastname = "Johnes" });
            People.Add(new Person { Idperson = 8, Firstname = "Donald", Lastname = "Mac" });
            People.Add(new Person { Idperson = 9, Firstname = "Thomas", Lastname = "DeTrain" });
            People.Add(new Person { Idperson = 10, Firstname = "Anthony", Lastname = "Hopkins" });

            return People;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> Customers = new List<Customer>();
            List<Person> people = GetPeople();

            Customers.Add(new Customer { Idcustomer = 1, Phonenumber = "502205502", Email = "A_dam@poczta.ex", PersonIdperson = 1, PersonIdpersonNavigation = people[0] });
            Customers.Add(new Customer { Idcustomer = 2, Phonenumber = "602206602", Email = "314otr@poczta.ex", PersonIdperson = 2, PersonIdpersonNavigation = people[1] });
            Customers.Add(new Customer { Idcustomer = 3, Phonenumber = "702207702", Email = "Limak@poczta.ex", PersonIdperson = 3, PersonIdpersonNavigation = people[2] });
            Customers.Add(new Customer { Idcustomer = 4, Phonenumber = "802208802", Email = "pablito@poczta.ex", PersonIdperson = 4, PersonIdpersonNavigation = people[3] });
            Customers.Add(new Customer { Idcustomer = 5, Phonenumber = "902209902", Email = "j_a_n_k_o@poczta.ex", PersonIdperson = 5, PersonIdpersonNavigation = people[4] });

            return Customers;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> Employees = new List<Employee>();
            List<Person> people = GetPeople();

            Employees.Add(new Employee { Idemployee = 1, Hiredate = new DateTime(2001, 09 ,11), PersonIdperson = 6, PersonIdpersonNavigation = people[5] });
            Employees.Add(new Employee { Idemployee = 2, Hiredate = new DateTime(2004, 04, 24), PersonIdperson = 7, PersonIdpersonNavigation = people[6] });
            Employees.Add(new Employee { Idemployee = 3, Hiredate = new DateTime(2011, 11, 11), PersonIdperson = 8, PersonIdpersonNavigation = people[7] });
            Employees.Add(new Employee { Idemployee = 4, Hiredate = new DateTime(2020, 06, 12), PersonIdperson = 9, PersonIdpersonNavigation = people[8] });
            Employees.Add(new Employee { Idemployee = 5, Hiredate = new DateTime(2020, 06, 12), PersonIdperson = 10, PersonIdpersonNavigation = people[9] });

            return Employees;
        }

        public List<Booking> GetBookings()
        {
            List<Booking> Bookings = new List<Booking>();
            List<Customer> Customers = GetCustomers();

            Bookings.Add(new Booking { Idbooking = 1, Date = new DateTime(2020, 06, 14), Hour = new TimeSpan(14, 00, 00), Numberofpeople = 12, Notes = "Fani anime", Cost = 500, Requiredemployees = 3, CustomerIdcustomerNavigation = Customers[0] }); 
            Bookings.Add(new Booking { Idbooking = 2, Date = new DateTime(2020, 06, 14), Hour = new TimeSpan(15, 30, 00), Numberofpeople = 40, Notes = "Fani mario", Cost = 1500, Requiredemployees = 8, CustomerIdcustomerNavigation = Customers[1] }); 
            Bookings.Add(new Booking { Idbooking = 3, Date = new DateTime(2020, 06, 15), Hour = new TimeSpan(15, 30, 00), Numberofpeople = 40, Notes = "Fani mario", Cost = 1500, Requiredemployees = 8, CustomerIdcustomerNavigation = Customers[2] }); 
            Bookings.Add(new Booking { Idbooking = 4, Date = new DateTime(2019, 12, 15), Hour = new TimeSpan(10, 30, 00), Numberofpeople = 5, Notes = "Fani mario", Cost = 200, Requiredemployees = 1, CustomerIdcustomerNavigation = Customers[3] }); 
            Bookings.Add(new Booking { Idbooking = 5, Date = new DateTime(2028, 06, 21), Hour = new TimeSpan(11, 45, 00), Numberofpeople = 13, Notes = "Fani mario", Cost = 1000, Requiredemployees = 3, CustomerIdcustomerNavigation = Customers[4] }); 

            return Bookings;
        }

        public List<Order> GetOrders()
        {
            List<Order> Orders = new List<Order>();

            Orders.Add(new Order { Idorder = 1, Cost = 200, Description = "Food delivered to Your station", Name = "Food" });
            Orders.Add(new Order { Idorder = 2, Cost = 100, Description = "Music will fill your station", Name = "Music" });
            Orders.Add(new Order { Idorder = 3, Cost = 500, Description = "Anime waifus in your station", Name = "Cosplay" });
            Orders.Add(new Order { Idorder = 4, Cost = 300, Description = "Yes...", Name = "Alcohol"});

            return Orders;
        }

        public List<Extras> GetExtras()
        {
            List<Extras> ExtrasList = new List<Extras>();
            List<Booking> Bookings = GetBookings();
            List<Order> Orders = GetOrders();

            ExtrasList.Add(new Extras { Idextras = 1, BookingIdbooking = 1, OrderIdorder = 1, BookingIdbookingNavigation = Bookings[0], OrderIdorderNavigation = Orders[0] });
            ExtrasList.Add(new Extras { Idextras = 2, BookingIdbooking = 1, OrderIdorder = 2, BookingIdbookingNavigation = Bookings[0], OrderIdorderNavigation = Orders[1] });
            ExtrasList.Add(new Extras { Idextras = 3, BookingIdbooking = 2, OrderIdorder = 3, BookingIdbookingNavigation = Bookings[1], OrderIdorderNavigation = Orders[2] });
            ExtrasList.Add(new Extras { Idextras = 4, BookingIdbooking = 3, OrderIdorder = 3, BookingIdbookingNavigation = Bookings[2], OrderIdorderNavigation = Orders[2] });
            
            return ExtrasList;
        }

        public List<Station> GetStation()
        {
            List<Station> Stations = new List<Station>();

            Stations.Add(new Station { Stationnumber = 1, Specialization = "pro", Inspectiondate = new DateTime(2020, 06, 12)});
            Stations.Add(new Station { Stationnumber = 2, Specialization = "amatorska", Inspectiondate = new DateTime(2020, 05, 25) });
            Stations.Add(new Station { Stationnumber = 3, Specialization = "amatorska", Inspectiondate = new DateTime(2019, 08, 30) });
            Stations.Add(new Station { Stationnumber = 4, Specialization = "pro", Inspectiondate = new DateTime(2019, 11, 11) });
            Stations.Add(new Station { Stationnumber = 5, Specialization = "esport", Inspectiondate = new DateTime(2020, 01, 01) });

            return Stations;
        }

        public List<Equipment> GetEquipment()
        {
            List<Equipment> Equipments = new List<Equipment>();

            Equipments.Add(new Equipment { Serialnumber = 1, Name = "Xbox One", Purchasedate = new DateTime(2022, 01, 01), Producent = "Microsoft", Type = "Konsola", Warrantydate = new DateTime(2022, 01, 01) });
            Equipments.Add(new Equipment { Serialnumber = 2, Name = "PlayStation 5", Purchasedate = new DateTime(2020, 01, 01), Producent = "Sony", Type = "Konsola", Warrantydate = new DateTime(2022, 01, 01) });
            Equipments.Add(new Equipment { Serialnumber = 3, Name = "Wii", Purchasedate = new DateTime(2010, 12, 24), Producent = "Nintendo", Type = "Konsola", Warrantydate = new DateTime(2011, 12, 24) });
            Equipments.Add(new Equipment { Serialnumber = 4, Name = "Xbox One", Purchasedate = new DateTime(2020, 06, 12), Producent = "Microsoft", Type = "Konsola", Warrantydate = new DateTime(2022, 06, 12) });
            Equipments.Add(new Equipment { Serialnumber = 5, Name = "PlayStation 4", Purchasedate = new DateTime(2020, 07, 17), Producent = "Sony", Type = "Konsola", Warrantydate = new DateTime(2022, 07, 17) });
            Equipments.Add(new Equipment { Serialnumber = 6, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });
            Equipments.Add(new Equipment { Serialnumber = 7, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });
            Equipments.Add(new Equipment { Serialnumber = 8, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });

            return Equipments;
        }

        public List<Assignments> GetAssignments()
        {
            List<Assignments> AssignmentsList = new List<Assignments>();
            List<Booking> Bookings = GetBookings();
            List<Employee> Employees = GetEmployees();

            AssignmentsList.Add(new Assignments { Idassignments = 1, BookingIdbooking = 1, EmployeeIdemployee = 1, BookingIdbookingNavigation = Bookings[0], EmployeeIdemployeeNavigation = Employees[0] });
            AssignmentsList.Add(new Assignments { Idassignments = 2, BookingIdbooking = 1, EmployeeIdemployee = 2, BookingIdbookingNavigation = Bookings[0], EmployeeIdemployeeNavigation = Employees[1] });
            AssignmentsList.Add(new Assignments { Idassignments = 3, BookingIdbooking = 2, EmployeeIdemployee = 1, BookingIdbookingNavigation = Bookings[1], EmployeeIdemployeeNavigation = Employees[0] });
            AssignmentsList.Add(new Assignments { Idassignments = 4, BookingIdbooking = 3, EmployeeIdemployee = 1, BookingIdbookingNavigation = Bookings[2], EmployeeIdemployeeNavigation = Employees[0] });
            AssignmentsList.Add(new Assignments { Idassignments = 5, BookingIdbooking = 4, EmployeeIdemployee = 3, BookingIdbookingNavigation = Bookings[3], EmployeeIdemployeeNavigation = Employees[2] });
            AssignmentsList.Add(new Assignments { Idassignments = 6, BookingIdbooking = 4, EmployeeIdemployee = 4, BookingIdbookingNavigation = Bookings[4], EmployeeIdemployeeNavigation = Employees[3] });
            AssignmentsList.Add(new Assignments { Idassignments = 7, BookingIdbooking = 5, EmployeeIdemployee = 5, BookingIdbookingNavigation = Bookings[5], EmployeeIdemployeeNavigation = Employees[4] });

            return AssignmentsList;
        }

        public List<StationsBookings> GetStationsBookings()
        {
            List<StationsBookings> StationsBookingsList = new List<StationsBookings>();
            List<Booking> Bookings = GetBookings();
            List<Station> Stations = GetStation();

            StationsBookingsList.Add(new StationsBookings { Id = 1, BookingIdbooking = 1, StationStationnumber =  1, BookingIdbookingNavigation = Bookings[0], StationStationnumberNavigation = Stations[0]}); 
            StationsBookingsList.Add(new StationsBookings { Id = 2, BookingIdbooking = 2, StationStationnumber =  1, BookingIdbookingNavigation = Bookings[1], StationStationnumberNavigation = Stations[0]}); 
            StationsBookingsList.Add(new StationsBookings { Id = 3, BookingIdbooking = 3, StationStationnumber =  4, BookingIdbookingNavigation = Bookings[2], StationStationnumberNavigation = Stations[3]}); 
            StationsBookingsList.Add(new StationsBookings { Id = 4, BookingIdbooking = 4, StationStationnumber =  3, BookingIdbookingNavigation = Bookings[3], StationStationnumberNavigation = Stations[2]}); 
            StationsBookingsList.Add(new StationsBookings { Id = 5, BookingIdbooking = 5, StationStationnumber =  5, BookingIdbookingNavigation = Bookings[4], StationStationnumberNavigation = Stations[4]}); 

            return StationsBookingsList;
        }

        public List<StationsEquipment> GetStationsEquipment()
        {
            List<StationsEquipment> StationsEquipmentList = new List<StationsEquipment>();
            List<Station> Stations= new List<Station>();
            List<Equipment> Equipments = new List<Equipment>();

            StationsEquipmentList.Add(new StationsEquipment { Id = 1, EquipmentSerialnumber = 1, StationStationnumber = 1, EquipmentSerialnumberNavigation = Equipments[0], StationStationnumberNavigation = Stations[0] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 2, EquipmentSerialnumber = 2, StationStationnumber = 2, EquipmentSerialnumberNavigation = Equipments[1], StationStationnumberNavigation = Stations[1] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 3, EquipmentSerialnumber = 3, StationStationnumber = 1, EquipmentSerialnumberNavigation = Equipments[2], StationStationnumberNavigation = Stations[0] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 4, EquipmentSerialnumber = 4, StationStationnumber = 3, EquipmentSerialnumberNavigation = Equipments[3], StationStationnumberNavigation = Stations[2] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 5, EquipmentSerialnumber = 5, StationStationnumber = 4, EquipmentSerialnumberNavigation = Equipments[4], StationStationnumberNavigation = Stations[3] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 6, EquipmentSerialnumber = 6, StationStationnumber = 5, EquipmentSerialnumberNavigation = Equipments[5], StationStationnumberNavigation = Stations[4] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 7, EquipmentSerialnumber = 7, StationStationnumber = 5, EquipmentSerialnumberNavigation = Equipments[6], StationStationnumberNavigation = Stations[4] });
            StationsEquipmentList.Add(new StationsEquipment { Id = 8, EquipmentSerialnumber = 8, StationStationnumber = 5, EquipmentSerialnumberNavigation = Equipments[7], StationStationnumberNavigation = Stations[4] });

            return StationsEquipmentList;
        }

    }
}
