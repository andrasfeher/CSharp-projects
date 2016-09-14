using System;
using System.Collections.Generic;
using System.Text;

namespace BindingTest
{
    class Record
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _val;

        public string Val
        {
            get { return _val; }
            set { _val = value; }
        }
    
    }
}
