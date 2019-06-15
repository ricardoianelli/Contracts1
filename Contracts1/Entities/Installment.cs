using System;
using System.Globalization;

namespace Contracts1.Entities
{
    class Installment
    {
        public DateTime dueTime { get; set; }
        public double amount { get; set; }

        public Installment(DateTime dueTime, double amount)
        {
            this.dueTime = dueTime;
            this.amount = amount;
        }

        public override string ToString()
        {
            return dueTime.ToString("dd/MM/yyyy") + " - " + amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
