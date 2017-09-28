using System;

namespace FeeEngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFeesEngine feeEngine;

             var request1 = new lenderFeesRequest() { loanNum = 123, LoanType = "ABC" };
              feeEngine = FeeFactory.generateFee(request1);
             var data = feeEngine.GetFees();     

            Console.WriteLine("Hello World!");
        }
    }
}
