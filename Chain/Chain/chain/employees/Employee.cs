using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZTP_Zadanie3.chain.wnioski;

namespace ZTP_Zadanie3.pracownicy
{
    abstract class Employee
    {
        private Employee receiver;

        public virtual void receiveARequest(Request request)
        {
            if (getReceiver() != null)
            {
                getReceiver().receiveARequest(request);
            }
            else
            {
                Console.WriteLine("None of employees could receive " + request.GetType().Name);
            }
        }

        public bool isAllowedToReceive(Request wniosek, string typWniosku)
        {
            return (wniosek == null) || wniosek.GetType().Name.Equals(typWniosku);
        }

        public Employee getReceiver()
        {
            return receiver;
        }

        public void setReceiver(Employee receiver)
        {
            this.receiver = receiver;
        }
    }
}
