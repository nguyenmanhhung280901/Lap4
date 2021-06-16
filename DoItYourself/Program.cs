using System;

namespace DoItYourself
{
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Email)}: {Email}";
        }
    }

    class Students : Person
    {
        public string EnrollProgram { get; set; }

        public Students(string name, string phone, string email, string enrollProgram) : base(name, phone, email)
        {
            Name = name;
            Phone = phone;
            Email = email;
            EnrollProgram = enrollProgram;
        }

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}, {nameof(Email)}: {Email}, {nameof(EnrollProgram)}: {EnrollProgram}";
        }
    }

    abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public double HiredDate { get; set; }

        public Employee(string name, string phone, string email, string department, double salary, double hiredDate) :
            base(name, phone, email)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Department = department;
            Salary = salary;
            HiredDate = hiredDate;
        }

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}, {nameof(Email)}: {Email}, {nameof(Department)}: {Department}, {nameof(Salary)}: {Salary}, {nameof(HiredDate)}: {HiredDate}";
        }

        public abstract void CalculateBonus();
        public abstract void CalculateVacation();
    }

    class Faculty : Employee
    {
        public Faculty(string name, string phone, string email, string department, double salary, double hiredDate) : base(name, phone, email, department, salary, hiredDate)
        {
            Salary = salary;
        }

        public override void CalculateBonus()
        {
            double bonus = 1000 + 0.05 * Salary;
            Console.WriteLine(bonus);
        }

        public override void CalculateVacation()
        {
            if (HiredDate > 3 || Department == "Senior Lecturer")
            {
                System.Console.WriteLine("5 weeks");
            }
            else
            {
                System.Console.WriteLine("4 weeks");
            }
        }
    }

    class Staff : Employee
    {
        public Staff(string name, string phone, string email, string department, double salary, double hiredDate) : base(name, phone, email, department, salary, hiredDate)
        {
            Salary = salary;
        }

        public override void CalculateBonus()
        {
            double bonus = 0.06 * Salary;
            Console.WriteLine(bonus);
        }

        public override void CalculateVacation()
        {
            if (HiredDate > 5)
            {
                Console.WriteLine("4 weeks");
            }
            else
            {
                Console.WriteLine("3 weeks");
            }
        }
    }
    

    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1. Salary
            Faculty faculty = new Faculty("Lam", "787988945", "fjidjfiodfj@djfiodjf.com", "Senior Lecturer", 3000, 3);
            faculty.CalculateBonus();
            faculty.CalculateVacation();
            Staff staff = new Staff("Lam", "787988945", "fjidjfiodfj@djfiodjf.com", "Senior Lecturer", 3000, 3);
            staff.CalculateBonus();
            staff.CalculateVacation();
        }
    }
}