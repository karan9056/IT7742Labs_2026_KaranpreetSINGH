using System;

namespace _7742_Lab2
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            age = 19;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Employee : Person
    {
        protected string employeeId;
        protected string department;

        public Employee(string name, int age, string employeeId, string department) : base(name, age)
        {
            this.employeeId = employeeId;
            this.department = department;
        }

        public Employee(string employeeId, string department) : base("Karanpreet", 21)
        {
            this.employeeId = employeeId;
            this.department = department;
        }

        public string GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(string employeeId)
        {
            this.employeeId = employeeId;
        }

        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string department)
        {
            this.department = department;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee Id: " + employeeId);
            Console.WriteLine("Department: " + department);
        }
    }

    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, int age, string employeeId, string department, int teamSize) : base(name, age, employeeId, department)
        {
            this.teamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size: " + teamSize);
        }
    }

    class LibraryItem
    {
        protected string title;
        protected string author;
        protected int publicationYear;

        public LibraryItem(string title, string author, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Year: " + publicationYear);
        }
    }

    class Book : LibraryItem
    {
        private string isbn;
        private string genre;

        public Book(string title, string author, int publicationYear, string isbn, string genre) : base(title, author, publicationYear)
        {
            this.isbn = isbn;
            this.genre = genre;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Genre: " + genre);
        }
    }

    class Magazine : LibraryItem
    {
        private int issueNumber;
        private string frequency;

        public Magazine(string title, string author, int publicationYear, int issueNumber, string frequency) : base(title, author, publicationYear)
        {
            this.issueNumber = issueNumber;
            this.frequency = frequency;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Issue Number: " + issueNumber);
            Console.WriteLine("Frequency: " + frequency);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2");
            Console.WriteLine();

            Console.WriteLine("Exercise 1");
            Employee e1 = new Employee("Karanpreet", 23, "EMP101", "Support");
            e1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 2");
            Person p1 = new Person("Karanpreet");
            p1.DisplayDetails();

            Console.WriteLine();

            Employee e2 = new Employee("EMP102", "Accounts");
            e2.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 3");
            p1.SetName("Karanpreet Singh");
            p1.SetAge(24);
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetAge());

            e2.SetEmployeeId("EMP500");
            e2.SetDepartment("IT");
            Console.WriteLine(e2.GetEmployeeId());
            Console.WriteLine(e2.GetDepartment());

            Console.WriteLine();

            Console.WriteLine("Exercise 4");
            e1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 5");
            Person p2 = new Person("Aman", 20);
            Employee e3 = new Employee("Ritika", 26, "EMP210", "HR");
            Manager m1 = new Manager("Karanpreet", 31, "M301", "Admin", 9);

            p2.DisplayDetails();
            Console.WriteLine();
            e3.DisplayDetails();
            Console.WriteLine();
            m1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 6");
            Book b1 = new Book("Object Oriented Programming", "Neha Sharma", 2023, "ISBN-777", "Education");
            Magazine m2 = new Magazine("Code World", "Rahul Mehta", 2025, 6, "Monthly");

            b1.DisplayDetails();
            Console.WriteLine();
            m2.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Reflect");
            Console.WriteLine("constructor part was difficcult");
            Console.WriteLine("OOP ideas showed me how this is used in software design.");
            Console.WriteLine("For banking and office systems use is possible.");
        }
    }
}