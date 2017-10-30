using System;

namespace Amazon
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

        //Avoid Protected access modifier unless you have to
        //private int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}