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
            List<Request> listOfRequests = gatherRequests();

            Employee clubPresident = new ClubPresident();
            Employee sportingDirector = new SportingDirector(clubPresident);
            Employee coach = new Coach(sportingDirector);
            foreach(Request request in listOfRequests){
                coach.receiveARequest(request);
            }
            Console.ReadKey();
        }

        private static List<Request> gatherRequests()
        {
            List<Request> requests = new List<Request>();
            requests.Add(new ContractRequest("x", new DateTime(), new DateTime()));
            requests.Add(new DressingRoomRepairRequest("y", new DateTime()));
            requests.Add(new TransferRequest("z", new DateTime()));
            requests.Add(new PersonalTrainingRequest("a", new DateTime()));
            requests.Add(new TransferRequest("b", new DateTime()));

            return requests;
        }
    }
}
