using System;
using System.Collections.Generic;
using System.Text;

namespace stackoverflow
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<order> Orders;


        public Customer()
        {
            Orders = new List<order>();
        }

        public Customer(int id)
        { 
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }

     

    }
}
