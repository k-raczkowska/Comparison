using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTP_Zadanie3.chain.wnioski
{
    class TransferRequest : Request
    {
        public TransferRequest(string title, DateTime date)
        {
            this.title = title;
            this.date = date;
        }
    }
}
