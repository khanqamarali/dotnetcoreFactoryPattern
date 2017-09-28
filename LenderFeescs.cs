using System;
using System.Collections.Generic;
using System.Text;

namespace FeeEngineApp
{
    public class lenderFeesRequest {
        public int loanNum { get; set; } ;
        public string LoanType { get; set; } 
    }
    public class LenderFeescs : IFeesEngine
    {
        private lenderFeesRequest _lenderRequest;
        public LenderFeescs(lenderFeesRequest lenderRequest)
        {
            _lenderRequest = lenderRequest;
        }
        public FeeResponse GetFees() 
        {
            var response = new FeeResponse();
            response.fees = 10;
            response.desc = "originations";
            return response;
        }
    }
}
