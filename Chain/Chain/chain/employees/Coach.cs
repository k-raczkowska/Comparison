using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZTP_Zadanie3.chain.wnioski;

namespace ZTP_Zadanie3.pracownicy
{
    class Coach : Employee
    {
        public Coach(Employee employee)
        {
            this.setReceiver(employee);
        }

        public override void receiveARequest(Request request)
        {
            if (isAllowedToReceive(request, "PersonalTrainingRequest"))
            {
                Console.WriteLine("Coach has received " + request.GetType().Name);
            }
            else
            {
                base.receiveARequest(request);
            }
        }
    }
}
