using System;
using System.Globalization;
using Contracts1.Entities;
using Contracts1.Services;

namespace Contracts1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("- Enter contract data -");
                Console.Write("Contract number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Contract date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Number os installments: ");
                int installments = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, value, date);
                ContractService service = new ContractService(contract, installments, new PaypalService());
                service.generateInstallments();

                Console.WriteLine("\nInstallments:");
                foreach (Installment installment in contract.installments)
                {
                    Console.WriteLine(installment);
                }
            }
            catch(Exception exception){
                Console.WriteLine("Error: " + exception.Message);
            }

            Console.ReadLine();
        }
    }
}
