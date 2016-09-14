using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class QuandaList
    {
        private List<Quanda> _quandaList;
        private int _current;
        private int _range = 5;

        public EventHandler NoMoreQuanda;


        public QuandaList( QuandaListProvider qp, int range )
        {
            if ( _range != 5 )
                _range = range;

            _quandaList = qp.GetQuandaList();
        }

        public Quanda GetNextQuanda()
        {
            List<int> candidateQuandas = new List<int>();
            int i = 0;

            while (i < _quandaList.Count && candidateQuandas.Count < _range )
            {
                if (!_quandaList[i].Answered)
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

                return _quandaList[_current];
            }
                       
        }

        public void MarkCurrentQuandaAsAnswered()
        {
            _quandaList[_current].Answered = true;
        }


    }
}
