using System;
using System.Diagnostics;
using System.Globalization;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "David";
            Console.WriteLine(cookie["name"]);

            var person = new Person(new DateTime(1988, 2, 4));
            Console.WriteLine("Persons Age: " + person.Age);

            //person.SetBirthDate(new DateTime(1982, 1, 3));
            //Console.WriteLine("Persons birthdate: " + person.GetBirthDate());


            
            

            //var p = Person.Parse("John");
            //p.Introduce("Mosh");
          

            var customer = new Customer(1, "John");
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine("Count of orders: " + customer.Orders.Count);

            try
            {
                var parse = int.Parse("abc");
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong.");
            }



            //TryParse is equvilent to using try catch block 
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at {0} {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0} {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
