using System;
using System.Collections.Generic;

namespace Contracts1.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }
        public List<Installment> installments = new List<Installment>();

        public Contract(int number, double value, DateTime date)
        {
            this.number = number;
            this.value = value;
            this.date = date;
        }

        public void AddInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            installments.Remove(installment);
        }
    }
}
