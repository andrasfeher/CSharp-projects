using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class QuandaList
    {
        private int _current;
        private int _range = 5;
        private List<QuandaRecord> _quandaRecordList = new List<QuandaRecord>();

        public event EventHandler NoMoreQuanda;


        public QuandaList( int range )
        {
            if ( _range != 5 )
                _range = range;
        }

        public Quanda GetNextQuanda()
        {
            List<int> candidateQuandas = new List<int>();
            int i = 0;

            while (i < _quandaRecordList.Count && candidateQuandas.Count < _range )
            {
                if (!_quandaRecordList[i].QuandaItem.Answered)
                    candidateQuandas.Add(i);
            }

            if (candidateQuandas.Count == 0)
            {
                if (NoMoreQuanda != null)
                    NoMoreQuanda(this, EventArgs.Empty);

                return null;
            }
            else
            {
                Random rnd1 = new Random();

                _current = candidateQuandas[rnd1.Next(candidateQuandas.Count + 1)];

                _quandaRecordList[_current].RetrievedTimes++;

                return _quandaRecordList[_current].QuandaItem;
            }
                       
        }

        public void MarkCurrentQuandaAsAnswered()
        {
            _quandaRecordList[_current].QuandaItem.Answered = true;
        }

        public int GetTotalQuandaNr()
        {
            return _quandaRecordList.Count;
        }

        public int GetAnsweredQuandaNr()
        {
            int cnt = 0;

            foreach (QuandaRecord qr in _quandaRecordList)
                if (qr.QuandaItem.Answered)
                    cnt++;

            return cnt;
        }

        public int GetAnsweredForFirstQuandaNr()
        {
            int cnt = 0;

            foreach (QuandaRecord qr in _quandaRecordList)
                if (qr.QuandaItem.Answered && qr.RetrievedTimes==1)
                    cnt++;

            return cnt;
        }

        public decimal GetAnsweredForFirstQuandaPercent()
        {
            return (GetAnsweredForFirstQuandaNr() / GetTotalQuandaNr() )*100;
        }

        public int GetRestQuandaNr()
        {
            return GetTotalQuandaNr() - GetAnsweredQuandaNr();
        }

        public void Restart()
        {
            foreach (QuandaRecord qr in _quandaRecordList)
            {
                qr.QuandaItem.Answered = false;
                qr.RetrievedTimes = 0;
            }
        }

        public void Reset( QuandaListProvider qp )
        {
            _quandaRecordList.RemoveAll(AllQuandaRecords);

            foreach (Quanda q in qp.GetQuandaList())
                _quandaRecordList.Add(new QuandaRecord(q));
        }

        private static bool AllQuandaRecords(QuandaRecord qr)
        {
            return true;
        }


    }
}
