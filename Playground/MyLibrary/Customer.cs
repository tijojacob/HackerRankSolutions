using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Person {
        public string Name { get; set; }

        public virtual void UpdateName(string newName)
        {
            Name = newName;
        }
    }

    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public override void UpdateName(string newName)
        {
            base.UpdateName(newName);
            Name = "some other value";
        }
        
    }

    public class Supplier : Person
    {
        protected int SupplierId { get; set; }
        internal int SupplierId2 { get; set; }

    }

    public class otherclass {
        //supplier.
        public void dosomthing() {
            Customer customer = new Customer();
            customer.CustomerId=0;
            otherclass supplier = new otherclass();
            supplier.SupplierId = 1;
            supplier.SupplierId2 = 2;

        }

    }
    
}
