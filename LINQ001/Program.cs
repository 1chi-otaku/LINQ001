using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LINQ001
{
    enum Profile
    {
        Marketing, IT, Science, Economic, Service, NoData
    }
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            Name = "N/A";
            Position = " N/A";
            Number = "N/A";
            Email = "N/A";
            Salary = 0;
        }
        public Employee(string name, string pos, string number, string email, double salary)
        {
            Name = name;
            Position = pos;
            Number = number;
            Email = email;
            Salary = salary;

        }
        public override string ToString()
        {
            return "Em.Name - " + Name + "\nPosition - " + Position + "\nNumber + " + Number + "\nEmail - " + Email + "\nSalary - " + Salary;
        }

        class Firm
        {
            public string Name { get; set; }
            public int Found { get; set; }
            public Profile Profile { get; set; }
            public string Director { get; set; }
            public uint Employee_Count { get; set; }
            public string Address { get; set; }
            public Employee[] Employees { get; set; }

            public Firm()
            {
                Name = string.Empty;
                Found = 0;
                Profile = Profile.NoData;
                Director = string.Empty;
                Employee_Count = 0;
                Address = string.Empty;
                Employees = new Employee[0];
            }
            public Firm(string name, int found, Profile profile, string director, uint em_count, string address, Employee[] employees)
            {
                Name = name;
                Found = found;
                Profile = profile;
                Director = director;
                Employee_Count = em_count;
                Address = address;
                Employees = employees;
            }
            public void Print()
            {
                Console.WriteLine("Name - " + Name);
                Console.WriteLine("Founded - " + Found);
                Console.WriteLine("Profile - " + Profile);
                Console.WriteLine("Director - " + Director);
                Console.WriteLine("Employees - " + Employee_Count);
                Console.WriteLine("Address - " + Address);

            }
            public void PrintEmployees()
            {
                for (int i = 0; i < Employees.Count(); i++)
                {
                    Console.WriteLine(Employees[i].ToString());
                }
            }
            public override string ToString()
            {
                return "Name - " + Name + "\nFounded - " + Found + "\nProfile - " + Profile + "\nDirector - " + Director + "\nEmployees - " + Employee_Count + "\nAddress - " + Address;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee[] employees_1 = new Employee[2] { new Employee("Tom","Manager","4343434343","34343@gmail.com",215), new Employee() };
                Employee[] employees_2 = new Employee[2] { new Employee("Bob", "Manager", "2343434343", "34433343@gmail.com", 315), new Employee() };
                Employee[] employees_3 = new Employee[2] { new Employee("Cat", "Manager", "643434343", "3yt3343@gmail.com", 415), new Employee() };
                Employee[] employees_4 = new Employee[2] { new Employee("Lionel", "Manager", "41313143434343", "3424343@gmail.com", 515), new Employee() };
                Employee[] employees_5 = new Employee[2] { new Employee("Alex", "Manager", "2343434343", "3424343@gmail.com", 615), new Employee() };
                Employee[] employees_6 = new Employee[2] { new Employee("Brim", "Manager", "473434343", "094243343@gmail.com",715), new Employee() };
                Employee[] employees_7 = new Employee[2] { new Employee("Batt", "Manager", "83434343", "di243343gmail.com", 815), new Employee() };
                Employee[] employees_8 = new Employee[2] { new Employee("Trow", "Manager", "943434343", "di23243343@gmail.com", 915), new Employee() };
                Firm firm_1 = new Firm("Minecraftsoft", 1999, Profile.IT, "Joe Mama", 1670, "subject_to_change 1",employees_1);
                Firm firm_2 = new Firm("SEGA", 1986, Profile.Service, "Takashi Idzuka", 800, "ST.LK 002", employees_2);
                Firm firm_3 = new Firm("Bruhtendo", 2022, Profile.IT, "IP", 1200, "London", employees_3);
                Firm firm_4 = new Firm("IDM", 2001, Profile.IT, "Nae Idzu", 200, "Japan, Akihabara", employees_4);
                Firm firm_5 = new Firm("SOSONY", 1992, Profile.Marketing, "Joe Papa", 1212, "subject_to_change 2", employees_5);
                Firm firm_6 = new Firm("DirectFire", 2020, Profile.Science, "Mr. White", 5, "Brazil,Rio", employees_6);
                Firm firm_7 = new Firm("AeroSoft", 2002, Profile.Economic, "Tom Bob", 480, "Poland,Krakow", employees_7);
                Firm firm_8 = new Firm("StarMedia Food White", 2006, Profile.Economic, "Black", 1211, "subject_to_change 3", employees_8);

                List<Firm> firms = new List<Firm> { firm_1, firm_2, firm_3, firm_4, firm_5, firm_6, firm_7, firm_8 };

                #region #1

                //var print = from firm in firms
                //            select firm.ToString();
                //foreach (var item in print)
                //{
                //    Console.WriteLine(item);
                //    Console.WriteLine();
                //}
                #endregion

                #region #2
                //var selectedFood = firms.Where(t => t.Name.ToUpper().Contains("FOOD"));
                //foreach (var item in selectedFood)
                //{
                //    item.Print();
                //}
                #endregion

                #region #3
                //var selectedMarketing = firms.Where(f => f.Profile == Profile.Marketing);
                //foreach (var item in selectedMarketing)
                //{
                //    item.Print();
                //}
                #endregion

                #region #4
                //var selectedMarketingOrIT = firms.Where(f => f.Profile == Profile.Marketing || f.Profile == Profile.IT);
                //foreach (var item in selectedMarketingOrIT)
                //{
                //    item.Print();
                //}
                #endregion

                #region #5
                //var selectedEmployees= firms.Where(f => f.Employee_Count > 100);
                //foreach (var item in selectedEmployees)
                //{
                //    item.Print();
                //}
                #endregion

                #region #6
                //var selectedEmployees2 = firms.Where(f => f.Employee_Count > 100 && f.Employee_Count < 300);
                //foreach (var item in selectedEmployees2)
                //{
                //    item.Print();
                //}
                #endregion

                #region #7
                //var selectedLondon = firms.Where(t => t.Address.ToUpper().Contains("LONDON"));
                //foreach (var item in selectedLondon)
                //{
                //    item.Print();
                //}
                #endregion

                #region #8
                //var selectedDirector = firms.Where(t => t.Director.ToUpper().Contains("WHITE"));
                //foreach (var item in selectedDirector)
                //{
                //    item.Print();
                //}
                #endregion

                #region #9
                //var selectedYear = firms.Where(t => DateTime.Now.Year - t.Found > 2);
                //foreach (var item in selectedYear)
                //{
                //    item.Print();
                //}
                #endregion

                #region #10
                //var selectedBlackWhite = firms.Where(t => t.Director.ToUpper().Contains("BLACK") && t.Name.ToUpper().Contains("WHITE"));
                //foreach (var item in selectedBlackWhite)
                //{
                //    item.Print();
                //}

                #endregion

                #region #11
                //var selectedEmployee1 = firms.Where(t => t.Name == "SEGA");
                //foreach (var item in selectedEmployee1)
                //{
                //    item.PrintEmployees(); 
                //}
                #endregion

                #region #12

                //var selectedEmployee2 = from firm in firms 
                //                    from Employee in firm.Employees
                //                    where firm.Name == "SOSONY"
                //                    where Employee.Salary > 100
                //                    select firm;

                //foreach (var item in selectedEmployee2)
                //{
                //    item.Print();
                //}
                #endregion

                #region #13
                //var selectedEmployee3 = from firm in firms
                //                        from Employee in firm.Employees
                //                        where Employee.Position == "Manager"
                //                        select Employee;

                //foreach (var item in selectedEmployee3)
                //{
                //    Console.WriteLine(item.ToString());
                //}
                #endregion

                #region #14
                //var selectedEmployee4 = from firm in firms
                //                        from Employee in firm.Employees
                //                        where Employee.Number.StartsWith("23")
                //                        select Employee;

                //foreach (var item in selectedEmployee4)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                #endregion

                #region #15
                //var selectedEmployee5 = from firm in firms
                //                        from Employee in firm.Employees
                //                        where Employee.Email.StartsWith("di")
                //                        select Employee;

                //foreach (var item in selectedEmployee5)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                #endregion


                #region #16
                //var selectedEmployee6 = from firm in firms
                //                        from Employee in firm.Employees
                //                        where Employee.Name.ToLower().Contains("lionel")
                //                        select Employee;

                //foreach (var item in selectedEmployee6)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                #endregion
            }
        }
    }
}
