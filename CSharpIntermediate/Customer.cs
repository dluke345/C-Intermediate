using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int ID;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        //Can get rid of this Constructor and initialise the list of orders above instead
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
            //: this()
        {
            this.ID = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //....
        }
    }
}