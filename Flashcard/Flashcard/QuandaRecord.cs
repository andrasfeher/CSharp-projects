using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class QuandaRecord
    {
        private Quanda _quandaItem;

        public Quanda QuandaItem
        {
            get { return _quandaItem; }
            set { _quandaItem = value; }
        }

        private int _retrievedTimes;

        public int RetrievedTimes
        {
            get { return _retrievedTimes; }
            set { _retrievedTimes = value; }
        }

        public QuandaRecord(Quanda quandaItem)
        {
            QuandaItem = quandaItem;
            RetrievedTimes = 0;
        }
    }
}
