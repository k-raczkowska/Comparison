using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTP_Zadanie3.chain.wnioski
{
    class ContractRequest:Request
    {
        DateTime expiring;

        public ContractRequest(string title, DateTime date, DateTime expiring)
        {
            this.title = title;
            this.date = date;
            this.expiring = expiring;
        }
    }
}
