using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class Employee
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        
        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        //printa info 
        public void PrintInfo()
        {
            Console.WriteLine($"{this.GetType().Name}:\nFirst Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }
    }
    //classite od emmployeesot
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName, double salary)
            : base(firstName, lastName, salary) { }
    }

    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary)
            : base(firstName, lastName, salary) { }
    }

    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, double salary)
            : base(firstName, lastName, salary) { }
    }
    //clasa samo ceoto neznaev kako da ja napraam taka da mu kazav na chat gpt za ova
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; }
        public int Shares { get; set; }
        //dole e staeno kao double i edintsven nacin e da go changnes vo kcodot preku metodod
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, int shares)
            : base(firstName, lastName, salary)
        {
            Employees = new List<Employee>();
            Shares = shares;
            SharesPrice = 0.0;
        }
        //za share pricot
        public void AddSharesPrice(double value)
        {
            SharesPrice = value;
        }
        //kako employeesot gi printame
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }
        //salary za ceo
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }

    public class Program
    {
        public static void Main()
        {
            //place holderi za employess
            Contractor contractor1 = new Contractor("bob", "bobert", 800);
            Contractor contractor2 = new Contractor("rick", "rickert", 900);
            Manager manager1 = new Manager("mona", "monalisa", 1000);
            Manager manager2 = new Manager("igor", "igorsky", 1100);
            SalesPerson salesperson = new SalesPerson("lea", "leova", 950);

            //ceoto imeto i podatocite
            var ceo = new CEO("Ron", "Ronsky", 1500, 70);
            ceo.Employees.Add(contractor1);
            ceo.Employees.Add(contractor2);
            ceo.Employees.Add(manager1);
            ceo.Employees.Add(manager2);
            ceo.Employees.Add(salesperson);
            ceo.AddSharesPrice(20);

         //printanjeto dali sve e ok
            ceo.PrintInfo();
            Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");
            ceo.PrintEmployees();
        }
    }


}

