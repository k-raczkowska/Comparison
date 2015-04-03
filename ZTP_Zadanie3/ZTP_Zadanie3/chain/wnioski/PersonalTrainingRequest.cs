using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTP_Zadanie3.chain.wnioski
{
    class PersonalTrainingRequest : Request
    {
        public PersonalTrainingRequest(string title, DateTime date)
        {
            this.date = date;
            this.title = title;
        }
    }
}
