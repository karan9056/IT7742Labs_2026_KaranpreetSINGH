using System;

namespace _7742_Lab1
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public Car()
        {
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("This car is a " + Year + " " + Make + " " + Model + ".");
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    class Book
    {
        public string Title;
        public string Author;
        public int Pages;

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void Read()
        {
            Console.WriteLine("Reading '" + Title + "' by " + Author + ".");
        }
    }

    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Age = 30;
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    class Counter
    {
        public static int Count = 0;

        public void Increment()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }
    }

    class Product
    {
        public string Name;
        public int Stock;

        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public void ShowItem()
        {
            Console.WriteLine("Product: " + Name + ", Stock: " + Stock);
        }

        public void Sell(int qty)
        {
            if (qty <= Stock)
            {
                Stock = Stock - qty;
                Console.WriteLine(qty + " units sold from " + Name);
            }
            else
            {
                Console.WriteLine("Not enough stock for " + Name);
            }
        }
    }

    class Shop
    {
        public string ShopName;

        public Shop(string shopName)
        {
            ShopName = shopName;
        }

        public void SellProduct(Product p, int qty)
        {
            Console.WriteLine("Welcome to " + ShopName);
            p.Sell(qty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 1");
            Console.WriteLine();

            Console.WriteLine("Exercise 1");
            Car c1 = new Car();
            c1.Make = "Hyundai";
            c1.Model = "i20";
            c1.Year = 2021;
            c1.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Exercise 2");
            Car c2 = new Car("Maruti", "Swift", 2023);
            c2.DisplayInfo();
            c2.StartEngine();

            Console.WriteLine();

            Console.WriteLine("Exercise 3");
            Book b1 = new Book("Basic C#", "Anita Verma", 180);
            b1.Read();

            Console.WriteLine();

            Console.WriteLine("Exercise 4");
            Person p1 = new Person();
            Console.WriteLine("First Name: " + p1.FirstName);
            Console.WriteLine("Last Name: " + p1.LastName);
            Console.WriteLine("Age: " + p1.Age);

            Console.WriteLine();

            Console.WriteLine("Exercise 5");
            Calculator cal = new Calculator();
            Console.WriteLine("2 numbers: " + cal.Add(2, 4));
            Console.WriteLine("3 numbers: " + cal.Add(2, 4, 6));
            Console.WriteLine("4 numbers: " + cal.Add(2, 4, 6, 8));

            Console.WriteLine();

            Console.WriteLine("Exercise 6");
            Counter x = new Counter();
            Counter y = new Counter();
            x.Increment();
            y.Increment();
            y.Increment();
            Console.WriteLine("Count is: " + Counter.GetCount());

            Console.WriteLine();

            Console.WriteLine("Bonus Challenge");
            Shop s1 = new Shop("Karanpreet Fashion House");
            Product pr1 = new Product("Designer Tie", 20);
            pr1.ShowItem();
            s1.SellProduct(pr1, 5);
            pr1.ShowItem();
        }
    }
}