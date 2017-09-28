using System;
using System.Collections.Generic;
using System.Text;

namespace FeeEngineApp
{
    public class settlementFeesRequest
    {
        public int vendorid { get; set; } = 10;
        public string county { get; set; }
    }
    public class Settlement : IFeesEngine
    {
        private settlementFeesRequest _settlementFeesRequest;
        public Settlement(settlementFeesRequest settlementFeesRequest)
        {
            _settlementFeesRequest = settlementFeesRequest;
        }
        public FeeResponse GetFees() 
        {
            var response = new FeeResponse();
            response.fees = 20;
            response.desc = "Title Fees";
            return response;
        }
    }
}
