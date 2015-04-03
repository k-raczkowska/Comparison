using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZTP_Zadanie3.chain.wnioski;

namespace ZTP_Zadanie3.pracownicy
{
    class ClubPresident : Employee
    {
        public ClubPresident() { }

        public override void receiveARequest(Request request)
        {
            if (isAllowedToReceive(request, "ContractRequest"))
            {
                Console.WriteLine("Club president has received " + request.GetType().Name);
            }
            else
            {
                base.receiveARequest(request);
            }
        }
    }
}
