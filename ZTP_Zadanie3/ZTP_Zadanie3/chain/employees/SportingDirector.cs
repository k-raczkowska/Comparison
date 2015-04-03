using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZTP_Zadanie3.chain.wnioski;

namespace ZTP_Zadanie3.pracownicy
{
    class SportingDirector : Employee
    {
        public SportingDirector(Employee employee)
        {
            this.setReceiver(employee);
        }

        public override void receiveARequest(Request request)
        {
            if (isAllowedToReceive(request, "TransferRequest"))
            {
                Console.WriteLine("Sporting director has received " + request.GetType().Name);
            }
            else
            {
                base.receiveARequest(request);
            }
        }
    }
}
