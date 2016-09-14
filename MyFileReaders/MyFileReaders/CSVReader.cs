using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyFileReaders
{
public class CSVReader:IDisposable
    {
        private StreamReader _sr;

        public CSVReader( string fileName )
        {
            _sr = new StreamReader(fileName);
        }

        public string[] ReadRecord()
        {
            string s;

            if ( (s = _sr.ReadLine()) !=null)
            {
                return s.Split(';');
            }
            else
            {
                return null;
            }
        }


        #region IDisposable Members

        public void Dispose()
        {
            _sr.Close();
        }

        #endregion
    }
}
