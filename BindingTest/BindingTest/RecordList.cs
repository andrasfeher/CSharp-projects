using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BindingTest
{
    class RecordList
    {
        private List<Record> _recordList;

        public List<Record> Content
        {
            get { return _recordList; }
            set { _recordList = value; }
        }

    }
}
