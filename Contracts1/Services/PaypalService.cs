using Contracts1.Entities;

namespace Contracts1.Services
{
    class PaypalService : IPaymentService
    {
        public void generateInstallments(Contract contract, int installments)
        {
            double baseAmount = contract.value / installments;
            for (int i = 1; i <= installments; i++)
            {
                double amount = (baseAmount * (1 + 0.01 * i)) * 1.02;
                Installment currentInstallment = new Installment(contract.date.AddMonths(i), amount);
                contract.AddInstallment(currentInstallment);
            }
        }
    }
}
