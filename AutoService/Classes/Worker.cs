using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    internal class Worker
    {
        Random rnd;
        Request request;

        List<string> servNames = new List<string>();
        List<Service> serv = new List<Service>();

        public int workedProfit = 0;
        public int salary = 0;
        public bool isBusy = false;

        int timer = 0;

        //конструктор
        public Worker(Random rnd) {
            this.rnd = rnd;
        }

        //установка заявки на выполнение рабочему
        public void SetRequest(Request request, List<string> servNames)
        {
            this.request = request;
            request.status = RequestStatus.onWork;
            this.servNames = servNames;
            foreach(string servName in servNames)
            {
                int servInd = request.servList.FindIndex(x => x.servName.Equals(servName));
                if (servInd != -1)
                    serv.Add(request.servList[servInd]);
            }
            if (serv.Count > 0)
                timer = serv[0].servTime + rnd.Next(serv[0].servTime - serv[0].servTimeDiv, serv[0].servTime + serv[0].servTimeDiv + 1);
            isBusy = true;
        }

        //минута работы рабочего
        public void Tick()
        {
            if (timer > 0 && isBusy)
                timer--;
            else if (isBusy)
            {
                workedProfit += serv[0].price;
                request.makeServiceDone(servNames[0]);
                servNames.RemoveAt(0);
                serv.RemoveAt(0);
                if (servNames.Count > 0)
                    timer = serv[0].servTime + rnd.Next(2 * serv[0].servTimeDiv + 1) - serv[0].servTimeDiv;
                else
                {
                    if (request.servList.Count > 0)
                        request.status = RequestStatus.onQueue;
                    else
                        request.status = RequestStatus.done;
                    isBusy = false;
                }
            }
        }
    }
}
