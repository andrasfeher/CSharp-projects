using System;
using System.Collections.Generic;
using System.Text;

namespace DateTmeInterval
{
    public class DateTimeInterval
    {
        private DateTime _from;

        public DateTime From
        {
            get { return _from; }
            set { _from = value; }
        }
        private DateTime _to;

        public DateTime To
        {
            get { return _to; }
            set { _to = value; }
        }


        public DateTimeInterval(DateTime from, DateTime to)
        {
            if (from == DateTime.MinValue && to == DateTime.MinValue)
                throw new ArgumentException("Infinite interval");

            if (from.CompareTo(to) > 0 )
                throw new ArgumentException("from > to");

            From = from;


            if (to == DateTime.MinValue)
                To = DateTime.MaxValue;
            else
                To = to;

        
        }

        public bool IsInInterval(DateTime dt)
        {
            return (From.CompareTo(dt) <= 0 && To.CompareTo(dt) >= 0);
        }

        public bool IsOverlapping(DateTimeInterval dti)
        {

            return
                (
                //1 dti.From <= From && dti.To >= From
                    (dti.From.CompareTo(From) <= 0 && dti.To.CompareTo(From) >= 0)
                //2 dti.From >= From && dti.To <= To
                    || (dti.From.CompareTo(From) >= 0 && dti.To.CompareTo(To) <= 0)
                //3 dti.From <= From && dti.To >= To
                    || (dti.From.CompareTo(From) <= 0 && dti.To.CompareTo(To) >= 0)
                //4 dti.From >= From && dti.From <= To
                    || (dti.From.CompareTo(From) >= 0 && dti.From.CompareTo(To) <= 0)
                );
        }
    }
}
