using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class CustomerGroup
    {
        private Guid? _id;
        private string _name = "";
        private bool _isvip;
        private List<Customer> _customers = new List<Customer>();

        public List<Customer> Customers
        {
          get { return _customers; }
        }

        public Guid? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Isvip
        {
            get { return _isvip; }
            set { _isvip = value; }
        }

        public CustomerGroup()
        {
        }

        /// <summary>
        /// Ugyfel csoport azonositoval
        /// </summary>
        /// <param name="id"></param>
        public CustomerGroup( Guid id )
        {
            Id = id;
        }


        /// <summary>
        /// Ugyfel csoport nevvel es azonositoval
        /// </summary>
        /// <param name="id">azonosito</param>
        /// <param name="name">nev</param>
        public CustomerGroup(Guid id, string name )
        {
            Id = id;
            Name = name;

        }

        public void AddCustomer(Customer c)
        { 
            if (c == null)
                throw new ArgumentNullException("customer", "Customer cannot be null");

            if (c.Group!=null)
                c.Group.RemoveCustomer(c);
            
            if (!Customers.Contains(c))
            {
                Customers.Add(c);
            }

            c.Group = this;

            OnCustomerAdded();
        }

        public void RemoveCustomer(Customer c)
        {
            if (c == null)
                throw new ArgumentNullException("customer", "Customer cannot be null");

            if (Customers.Contains(c))
            {
                Customers.Remove(c);
            }

            c.Group = null;
        }

        public event EventHandler<EventArgs> CustomerAdded;

        protected virtual void OnCustomerAdded()
        {
            if (CustomerAdded != null)
                CustomerAdded(this, EventArgs.Empty);
        }

    }
}
