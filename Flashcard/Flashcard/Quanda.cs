using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class Quanda
    {
        private string _question;
        private string _answer;
        private bool _answered = false;
        private bool _firstTry = true;

        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        public bool Answered
        {
            get { return _answered; }
            set { _answered = Convert.ToBoolean(value); }
        }

        public Quanda(string question, string answer)
        {
            _question = question;
            _answer = answer;
        }

        public bool FirstTry
        {
            get { return _firstTry; }
            set { _firstTry = Convert.ToBoolean(value); }
        }


    }
}
