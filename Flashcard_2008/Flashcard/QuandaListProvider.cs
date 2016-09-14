using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class QuandaListProvider
    {
        private List<Quanda> _quandaList = new List<Quanda>();

        public QuandaListProvider()
        {
        }

        public QuandaListProvider( string FilePath )
        {
            _quandaList.Add(new Quanda("kerdes1", "valasz1"));
            _quandaList.Add(new Quanda("kerdes2", "valasz2"));
            _quandaList.Add(new Quanda("kerdes3", "valasz3"));
        }

        public List<Quanda> GetQuandaList()
        {
            return _quandaList;
        }

    }
}
