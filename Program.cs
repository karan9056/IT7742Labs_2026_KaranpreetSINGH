using System;

namespace _7742_Lab3
{
    abstract class Vehicle
    {
        public abstract void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }
    }

    abstract class Shape
    {
        public abstract double Area { get; }

        public void Display()
        {
            Console.WriteLine("Area: " + Area);
        }
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area
        {
            get { return 3.14 * Radius * Radius; }
        }
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area
        {
            get { return Width * Height; }
        }
    }

    abstract class Appliance
    {
        public abstract void Operate();
    }

    class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Washing machine is washing clothes");
        }
    }

    class Refrigerator : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Refrigerator is cooling food");
        }
    }

    abstract class Account
    {
        public string AccountHolder;
        public double Balance;

        public abstract double CalculateInterest();

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class SavingsAccount : Account
    {
        public double Rate;

        public SavingsAccount(string accountHolder, double balance, double rate)
        {
            AccountHolder = accountHolder;
            Balance = balance;
            Rate = rate;
        }

        public override double CalculateInterest()
        {
            return Balance * Rate;
        }
    }

    class CheckingAccount : Account
    {
        public CheckingAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public override double CalculateInterest()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3");
            Console.WriteLine();

            Console.WriteLine("Exercise 5");
            Car c1 = new Car();
            Motorcycle m1 = new Motorcycle();

            c1.StartEngine();
            c1.StopEngine();
            m1.StartEngine();
            m1.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Exercise 6");
            Circle c2 = new Circle(7);
            Rectangle r1 = new Rectangle(5, 9);

            c2.Display();
            r1.Display();

            Console.WriteLine();

            Console.WriteLine("Exercise 7");
            Appliance[] items = { new WashingMachine(), new Refrigerator() };

            for (int i = 0; i < items.Length; i++)
            {
                items[i].Operate();
            }

            Console.WriteLine();

            Console.WriteLine("Exercise 8");
            SavingsAccount s1 = new SavingsAccount("Karanpreet Singh", 12000, 0.04);
            CheckingAccount c3 = new CheckingAccount("Simran Kaur", 8000);

            s1.DisplayAccountInfo();
            Console.WriteLine("Interest: " + s1.CalculateInterest());

            Console.WriteLine();

            c3.DisplayAccountInfo();
            Console.WriteLine("Interest: " + c3.CalculateInterest());
        }
    }
}