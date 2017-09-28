using System;
using System.Collections.Generic;
using System.Text;

namespace FeeEngineApp
{
  public  class FeeFactory
    {
        public static IFeesEngine generateFee<T>(T request)
        {
            if (request is settlementFeesRequest)
            {
                return new Settlement(new settlementFeesRequest());
            }
            else if (request is lenderFeesRequest)
            {
                return  new LenderFeescs(new lenderFeesRequest());
            }

            return null;
        }
    }
}
