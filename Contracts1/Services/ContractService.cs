using Contracts1.Entities;

namespace Contracts1.Services
{
    class ContractService
    {
        Contract contract;
        int installments;
        IPaymentService paymentService;

        public ContractService(Contract contract, int installments, IPaymentService paymentService)
        {
            this.contract = contract;
            this.installments = installments;
            this.paymentService = paymentService;
        }

        public void generateInstallments()
        {
            paymentService.generateInstallments(contract, installments);
        }
    }
}
