using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Business
{
    public class Customer: INotifyPropertyChanged
    {
        private Guid? _id;
        private string _name;
        private decimal _accountBalance = 0;
        private CustomerGroup _customerGroup;
        private DateTime _lastActivityDate = DateTime.Now;

        public Guid? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public decimal AccountBalance
        {
            get { return _accountBalance; }
            set
            {
                _accountBalance = value;
                OnPropertyChanged("AccountBalance");
            }
        }

        public CustomerGroup Group 
        {
            get { return _customerGroup; }
            set 
            { 
                _customerGroup = value;
                OnPropertyChanged("Group");
            }
        }

        public DateTime LastActivityDate
        {
            get { return _lastActivityDate; }
            set 
            { 
                    _lastActivityDate = value;
                    OnPropertyChanged("LastActivityDate");
            }
        }

        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Customer( Guid? id )
        {
            Id = id;
        }

        /// <summary>
        /// Ugyfel .ctor
        /// </summary>
        /// <param name="id">azonosito</param>
        /// <param name="name">nev</param>
        /// <param name="group">csoport</param>
        public Customer(Guid? id, string name, CustomerGroup group )
        {
            Id = id;
            Name = name;
            Group = group;
        }
        
        /// <summary>
        /// Terheles
        /// </summary>
        /// <param name="amount">osszeg amivel terhelek</param>
        public void Charge(decimal amount)
        {
            if ( amount < 0)
                throw new ArgumentOutOfRangeException("amount", "Amount should be positive");

            AccountBalance -= amount;
        }

        /// <summary>
        /// Jovairas
        /// </summary>
        /// <param name="amount">osszeg amit jovairok a szamlan</param>
        public void Pay(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount", "Amount should be positive");

            AccountBalance += amount;
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null )
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
