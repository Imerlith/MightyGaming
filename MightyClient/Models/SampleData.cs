using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MightyClient.Models
{
    class SampleData
    {

        public List<Person> People { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Order> Orders { get; set; }
        public List<Extras> ExtrasList { get; set; }
        public List<Station> Stations { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Assignments> AssignmentsList { get; set; }
        public List<StationsBookings> StationsBookingsList { get; set; }
        public List<StationsEquipment> StationsEquipmentList { get; set; }


        public void Initialize()
        {
            InitializePeople();
            InitializeCustomers();
            InitializeEmployees();
            InitializeBookings();
            InitializeOrders();
            InitializeExtras();
            InitializeAssignments();
            InitializeEquipment();
            InitializeStation();
            InitializeStationsBookings();
            InitializeStationsEquipment();

            ConnectBookingExtras();
            ConnectOrderExtras();
            ConnectCustomerBooking();
            ConnectEmployeeAssignment();
            ConnectBookingAssignments();
            ConnectStationsEquipment();
            ConnectBookingsStations();
        }

        public void InitializePeople()
        {
            this.People = new List<Person>();

            this.People.Add( new Person { Idperson = 1, Firstname = "Adam", Lastname = "Kamilowicz" });
            this.People.Add(new Person { Idperson = 2, Firstname = "Piotr", Lastname = "Adamowicz" });
            this.People.Add(new Person { Idperson = 3, Firstname = "Kamil", Lastname = "Pawłowski" });
            this.People.Add(new Person { Idperson = 4, Firstname = "Paweł", Lastname = "Janowski" });
            this.People.Add(new Person { Idperson = 5, Firstname = "Jan", Lastname = "Piotrowski" });

            this.People.Add(new Person { Idperson = 6, Firstname = "Agent", Lastname = "Smith" });
            this.People.Add(new Person { Idperson = 7, Firstname = "Papa", Lastname = "Johnes" });
            this.People.Add(new Person { Idperson = 8, Firstname = "Donald", Lastname = "Mac" });
            this.People.Add(new Person { Idperson = 9, Firstname = "Thomas", Lastname = "DeTrain" });
            this.People.Add(new Person { Idperson = 10, Firstname = "Anthony", Lastname = "Hopkins" });
        }

        public void InitializeCustomers()
        {
            this.Customers = new List<Customer>();

            this.Customers.Add(new Customer { Idcustomer = 1, Phonenumber = "502205502", Email = "A_dam@poczta.ex", PersonIdperson = 1, PersonIdpersonNavigation = this.People[0] });
            this.Customers.Add(new Customer { Idcustomer = 2, Phonenumber = "602206602", Email = "314otr@poczta.ex", PersonIdperson = 2, PersonIdpersonNavigation = this.People[1] });
            this.Customers.Add(new Customer { Idcustomer = 3, Phonenumber = "702207702", Email = "Limak@poczta.ex", PersonIdperson = 3, PersonIdpersonNavigation = this.People[2] });
            this.Customers.Add(new Customer { Idcustomer = 4, Phonenumber = "802208802", Email = "pablito@poczta.ex", PersonIdperson = 4, PersonIdpersonNavigation = this.People[3] });
            this.Customers.Add(new Customer { Idcustomer = 5, Phonenumber = "902209902", Email = "j_a_n_k_o@poczta.ex", PersonIdperson = 5, PersonIdpersonNavigation = this.People[4] });
        }

        public void InitializeEmployees()
        {
            this.Employees = new List<Employee>();

            this.Employees.Add(new Employee { Idemployee = 1, Hiredate = new DateTime(2001, 09 ,11), PersonIdperson = 6, PersonIdpersonNavigation = this.People[5] });
            this.Employees.Add(new Employee { Idemployee = 2, Hiredate = new DateTime(2004, 04, 24), PersonIdperson = 7, PersonIdpersonNavigation = this.People[6] });
            this.Employees.Add(new Employee { Idemployee = 3, Hiredate = new DateTime(2011, 11, 11), PersonIdperson = 8, PersonIdpersonNavigation = this.People[7] });
            this.Employees.Add(new Employee { Idemployee = 4, Hiredate = new DateTime(2020, 06, 12), PersonIdperson = 9, PersonIdpersonNavigation = this.People[8] });
            this.Employees.Add(new Employee { Idemployee = 5, Hiredate = new DateTime(2020, 06, 12), PersonIdperson = 10, PersonIdpersonNavigation = this.People[9] });
        }

        public void InitializeBookings()
        {
            this.Bookings = new List<Booking>();

            Bookings.Add(new Booking { Idbooking = 1, Date = new DateTime(2020, 06, 14), Hour = new TimeSpan(14, 00, 00), Numberofpeople = 12, Notes = "", Cost = 500, Requiredemployees = 3, CustomerIdcustomerNavigation = this.Customers[0] }); 
            Bookings.Add(new Booking { Idbooking = 2, Date = new DateTime(2020, 06, 14), Hour = new TimeSpan(15, 30, 00), Numberofpeople = 40, Notes = "", Cost = 1500, Requiredemployees = 8, CustomerIdcustomerNavigation = this.Customers[1] }); 
            Bookings.Add(new Booking { Idbooking = 3, Date = new DateTime(2020, 06, 15), Hour = new TimeSpan(15, 30, 00), Numberofpeople = 40, Notes = "", Cost = 1500, Requiredemployees = 8, CustomerIdcustomerNavigation = this.Customers[2] }); 
            Bookings.Add(new Booking { Idbooking = 4, Date = new DateTime(2019, 12, 15), Hour = new TimeSpan(10, 30, 00), Numberofpeople = 5, Notes = "", Cost = 200, Requiredemployees = 1, CustomerIdcustomerNavigation = this.Customers[3] }); 
            Bookings.Add(new Booking { Idbooking = 5, Date = new DateTime(2028, 06, 21), Hour = new TimeSpan(11, 45, 00), Numberofpeople = 13, Notes = "", Cost = 1000, Requiredemployees = 3, CustomerIdcustomerNavigation = this.Customers[4] }); 
        }

        public void InitializeOrders()
        {
            this.Orders = new List<Order>();

            this.Orders.Add(new Order { Idorder = 1, Cost = 200, Description = "Food delivered to Your station", Name = "Food" });
            this.Orders.Add(new Order { Idorder = 2, Cost = 100, Description = "Music will fill your station", Name = "Music" });
            this.Orders.Add(new Order { Idorder = 3, Cost = 500, Description = "Anime waifus in your station", Name = "Cosplay" });
            this.Orders.Add(new Order { Idorder = 4, Cost = 300, Description = "Yes...", Name = "Alcohol"});
        }

        public void InitializeExtras()
        {
            this.ExtrasList = new List<Extras>();

            this.ExtrasList.Add(new Extras { Idextras = 1, BookingIdbooking = 1, OrderIdorder = 1, BookingIdbookingNavigation = this.Bookings[0], OrderIdorderNavigation = this.Orders[0] });
            this.ExtrasList.Add(new Extras { Idextras = 2, BookingIdbooking = 1, OrderIdorder = 2, BookingIdbookingNavigation = this.Bookings[0], OrderIdorderNavigation = this.Orders[1] });
            this.ExtrasList.Add(new Extras { Idextras = 3, BookingIdbooking = 2, OrderIdorder = 3, BookingIdbookingNavigation = this.Bookings[1], OrderIdorderNavigation = this.Orders[2] });
            this.ExtrasList.Add(new Extras { Idextras = 4, BookingIdbooking = 3, OrderIdorder = 3, BookingIdbookingNavigation = this.Bookings[2], OrderIdorderNavigation = this.Orders[2] });

        }

        public void InitializeStation()
        {
            this.Stations = new List<Station>();

            this.Stations.Add(new Station { Stationnumber = 1, Specialization = "pro", Inspectiondate = new DateTime(2020, 06, 12)});
            this.Stations.Add(new Station { Stationnumber = 2, Specialization = "amatorska", Inspectiondate = new DateTime(2020, 05, 25) });
            this.Stations.Add(new Station { Stationnumber = 3, Specialization = "amatorska", Inspectiondate = new DateTime(2019, 08, 30) });
            this.Stations.Add(new Station { Stationnumber = 4, Specialization = "pro", Inspectiondate = new DateTime(2019, 11, 11) });
            this.Stations.Add(new Station { Stationnumber = 5, Specialization = "esport", Inspectiondate = new DateTime(2020, 01, 01) });

        }

        public void InitializeEquipment()
        {
            this.Equipments = new List<Equipment>();

            this.Equipments.Add(new Equipment { Serialnumber = 1, Name = "Xbox One", Purchasedate = new DateTime(2022, 01, 01), Producent = "Microsoft", Type = "Konsola", Warrantydate = new DateTime(2022, 01, 01) });
            this.Equipments.Add(new Equipment { Serialnumber = 2, Name = "PlayStation 5", Purchasedate = new DateTime(2020, 01, 01), Producent = "Sony", Type = "Konsola", Warrantydate = new DateTime(2022, 01, 01) });
            this.Equipments.Add(new Equipment { Serialnumber = 3, Name = "Wii", Purchasedate = new DateTime(2010, 12, 24), Producent = "Nintendo", Type = "Konsola", Warrantydate = new DateTime(2011, 12, 24) });
            this.Equipments.Add(new Equipment { Serialnumber = 4, Name = "Xbox One", Purchasedate = new DateTime(2020, 06, 12), Producent = "Microsoft", Type = "Konsola", Warrantydate = new DateTime(2022, 06, 12) });
            this.Equipments.Add(new Equipment { Serialnumber = 5, Name = "PlayStation 4", Purchasedate = new DateTime(2020, 07, 17), Producent = "Sony", Type = "Konsola", Warrantydate = new DateTime(2022, 07, 17) });
            this.Equipments.Add(new Equipment { Serialnumber = 6, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });
            this.Equipments.Add(new Equipment { Serialnumber = 7, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });
            this.Equipments.Add(new Equipment { Serialnumber = 8, Name = "PC", Purchasedate = new DateTime(2019, 07, 01), Producent = "HP", Type = "PC", Warrantydate = new DateTime(2021, 07, 01) });
        }

        public void InitializeAssignments()
        {
            this.AssignmentsList = new List<Assignments>();

            this.AssignmentsList.Add(new Assignments { Idassignments = 1, BookingIdbooking = 1, EmployeeIdemployee = 1, BookingIdbookingNavigation = this.Bookings[0], EmployeeIdemployeeNavigation = this.Employees[0] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 2, BookingIdbooking = 1, EmployeeIdemployee = 2, BookingIdbookingNavigation = this.Bookings[0], EmployeeIdemployeeNavigation = this.Employees[1] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 3, BookingIdbooking = 2, EmployeeIdemployee = 1, BookingIdbookingNavigation = this.Bookings[1], EmployeeIdemployeeNavigation = this.Employees[0] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 4, BookingIdbooking = 3, EmployeeIdemployee = 1, BookingIdbookingNavigation = this.Bookings[2], EmployeeIdemployeeNavigation = this.Employees[0] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 5, BookingIdbooking = 4, EmployeeIdemployee = 3, BookingIdbookingNavigation = this.Bookings[3], EmployeeIdemployeeNavigation = this.Employees[2] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 6, BookingIdbooking = 4, EmployeeIdemployee = 4, BookingIdbookingNavigation = this.Bookings[3], EmployeeIdemployeeNavigation = this.Employees[3] });
            this.AssignmentsList.Add(new Assignments { Idassignments = 7, BookingIdbooking = 5, EmployeeIdemployee = 5, BookingIdbookingNavigation = this.Bookings[4], EmployeeIdemployeeNavigation = this.Employees[4] });

        }

        public void InitializeStationsBookings()
        {
            this.StationsBookingsList = new List<StationsBookings>();

            this.StationsBookingsList.Add(new StationsBookings { Id = 1, BookingIdbooking = 1, StationStationnumber =  1, BookingIdbookingNavigation = this.Bookings[0], StationStationnumberNavigation = this.Stations[0]});
            this.StationsBookingsList.Add(new StationsBookings { Id = 2, BookingIdbooking = 2, StationStationnumber =  1, BookingIdbookingNavigation = this.Bookings[1], StationStationnumberNavigation = this.Stations[0]});
            this.StationsBookingsList.Add(new StationsBookings { Id = 3, BookingIdbooking = 3, StationStationnumber =  4, BookingIdbookingNavigation = this.Bookings[2], StationStationnumberNavigation = this.Stations[3]});
            this.StationsBookingsList.Add(new StationsBookings { Id = 4, BookingIdbooking = 4, StationStationnumber =  3, BookingIdbookingNavigation = this.Bookings[3], StationStationnumberNavigation = this.Stations[2]});
            this.StationsBookingsList.Add(new StationsBookings { Id = 5, BookingIdbooking = 5, StationStationnumber =  5, BookingIdbookingNavigation = this.Bookings[4], StationStationnumberNavigation = this.Stations[4]}); 

        }

        public void InitializeStationsEquipment()
        {
            this.StationsEquipmentList = new List<StationsEquipment>();


            this.StationsEquipmentList.Add(new StationsEquipment { Id = 1, EquipmentSerialnumber = 1, StationStationnumber = 1, EquipmentSerialnumberNavigation = this.Equipments[0], StationStationnumberNavigation = this.Stations[0] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 2, EquipmentSerialnumber = 2, StationStationnumber = 2, EquipmentSerialnumberNavigation = this.Equipments[1], StationStationnumberNavigation = this.Stations[1] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 3, EquipmentSerialnumber = 3, StationStationnumber = 1, EquipmentSerialnumberNavigation = this.Equipments[2], StationStationnumberNavigation = this.Stations[0] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 4, EquipmentSerialnumber = 4, StationStationnumber = 3, EquipmentSerialnumberNavigation = this.Equipments[3], StationStationnumberNavigation = this.Stations[2] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 5, EquipmentSerialnumber = 5, StationStationnumber = 4, EquipmentSerialnumberNavigation = this.Equipments[4], StationStationnumberNavigation = this.Stations[3] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 6, EquipmentSerialnumber = 6, StationStationnumber = 5, EquipmentSerialnumberNavigation = this.Equipments[5], StationStationnumberNavigation = this.Stations[4] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 7, EquipmentSerialnumber = 7, StationStationnumber = 5, EquipmentSerialnumberNavigation = this.Equipments[6], StationStationnumberNavigation = this.Stations[4] });
            this.StationsEquipmentList.Add(new StationsEquipment { Id = 8, EquipmentSerialnumber = 8, StationStationnumber = 5, EquipmentSerialnumberNavigation = this.Equipments[7], StationStationnumberNavigation = this.Stations[4] });
        }

        public void ConnectBookingExtras()
        {
            foreach(Booking b in this.Bookings)
            {
                List<Extras> ex = new List<Extras>();
                foreach(Extras e in this.ExtrasList)
                {
                    if (b.Idbooking == e.BookingIdbooking)
                        ex.Add(e);
                }
                b.Extras = ex;
            }
        }

        public void ConnectOrderExtras()
        {
            foreach (Order o in this.Orders)
            {
                List<Extras> ex = new List<Extras>();
                foreach (Extras e in this.ExtrasList)
                {
                    if (o.Idorder == e.OrderIdorder)
                        ex.Add(e);
                }
                o.Extras = ex;
            }
        }

        public void ConnectCustomerBooking()
        {
            foreach (Customer c in this.Customers)
            {
                List<Booking> bk = new List<Booking>();
                
                foreach (Booking b in this.Bookings)
                {
                    if (b.CustomerIdcustomer == c.Idcustomer)
                        bk.Add(b);
                }
                c.Booking = bk;
            }
        }

        public void ConnectBookingAssignments()
        {
            foreach (Booking b in this.Bookings)
            {
                List<Assignments> ass = new List<Assignments>();

                foreach (Assignments a in this.AssignmentsList)
                {
                    if (a.BookingIdbooking== b.Idbooking)
                        ass.Add(a);
                }
                b.Assignments = ass;
            }
        }

        public void ConnectEmployeeAssignment()
        {
            foreach (Employee e in this.Employees)
            {
                List<Assignments> ass = new List<Assignments>();

                foreach (Assignments a in this.AssignmentsList)
                {
                    if (a.EmployeeIdemployee == e.Idemployee)
                        ass.Add(a);
                }
                e.Assignments = ass;
            }
        }

        public void ConnectBookingsStations()
        {
            foreach (Booking b in this.Bookings)
            {
                List<StationsBookings> sb = new List<StationsBookings>();

                foreach (StationsBookings s in this.StationsBookingsList)
                {
                    if (s.BookingIdbooking == b.Idbooking)
                        sb.Add(s);
                }
                b.StationsBookings = sb;
            }

            foreach (Station s in this.Stations)
            {
                List<StationsBookings> sbs = new List<StationsBookings>();

                foreach (StationsBookings sb in this.StationsBookingsList)
                {
                    if (sb.StationStationnumber == s.Stationnumber)
                        sbs.Add(sb);
                }
                s.StationsBookings = sbs;
            }
        }

        public void ConnectStationsEquipment()
        {
            foreach (Station s in this.Stations)
            {
                List<StationsEquipment> ses = new List<StationsEquipment>();

                foreach (StationsEquipment se in this.StationsEquipmentList)
                {
                    if (se.StationStationnumber == s.Stationnumber)
                        ses.Add(se);
                }
                s.StationsEquipment = ses;
            }

            foreach (Equipment e in this.Equipments)
            {
                List<StationsEquipment> ses = new List<StationsEquipment>();

                foreach (StationsEquipment se in this.StationsEquipmentList)
                {
                    if (se.EquipmentSerialnumber == e.Serialnumber)
                        ses.Add(se);
                }
                e.StationsEquipment = ses;
            }
        }



    }
}
