using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZTP_Zadanie3.chain.wnioski;
using ZTP_Zadanie3.pracownicy;

namespace ZTP_Zadanie3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Request> listaWnioskow = zbierzWnioski();

            Employee clubPresident = new ClubPresident();
            Employee sportingDirector = new SportingDirector(clubPresident);
            Employee coach = new Coach(sportingDirector);
            foreach(Request request in listaWnioskow){
                coach.receiveARequest(request);
            }
            Console.ReadKey();
        }

        private static List<Request> zbierzWnioski()
        {
            List<Request> wnioski = new List<Request>();
            wnioski.Add(new ContractRequest("x", new DateTime(), new DateTime()));
            wnioski.Add(new DressingRoomRepairRequest("y", new DateTime()));
            wnioski.Add(new TransferRequest("z", new DateTime()));
            wnioski.Add(new PersonalTrainingRequest("a", new DateTime()));
            wnioski.Add(new TransferRequest("b", new DateTime()));
            
            return wnioski;
        }
    }
}
