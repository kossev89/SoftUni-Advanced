using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
            SecondDate = secondDate;
            FirstDate = firstDate;
        }

        public string SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }


        public string FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }

        public double CalculateDate(DateModifier dateModifier)
        {
            DateTime first = DateTime.Parse(dateModifier.FirstDate);
            DateTime second = DateTime.Parse(dateModifier.SecondDate);
            double totalDays = (second - first).TotalDays;
            return totalDays;
        }

    }
}
