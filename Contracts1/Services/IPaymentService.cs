using Contracts1.Entities;

namespace Contracts1.Services
{
    interface IPaymentService
    {
        void generateInstallments(Contract contract, int installments);
    }
}
