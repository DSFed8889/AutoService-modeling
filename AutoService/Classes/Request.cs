using AutoService.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    enum RequestStatus
    {
        onQueue,
        onWork,
        done
    }
    internal class Request
    {
        private List<Service> services;
        public List<Service> servList = new List<Service>();
        public List<Service> doneServList = new List<Service>();
        public RequestStatus status;
        public int startTime;
        public int endTime = 0;
        public Request(List<Service> services, Random rnd, int maxServListLen, int startTime)
        {
            this.services = new List<Service>(services);
            this.startTime = startTime;
            List<int> servIDList = new List<int>();
            for (int i = rnd.Next(maxServListLen) + 1; i > 0; i--)
            {
                var next = rnd.Next(services.Count);
                while (servIDList.FindIndex(x => x.Equals(next)) != -1)
                    next = rnd.Next(services.Count);
                servIDList.Add(next);
                servList.Add(services[next]);
            }
        }

        public void makeServiceDone(string servName)
        {
            //List<int> servIDList = new List<int>();
            //foreach(var serv in servList)
            //{
            //    servIDList.Add(serv.servID);
            //}
            //int servInd = servIDList.FindIndex(x => x.Equals(servID));
            int servInd = servList.FindIndex(x => x.servName.Equals(servName));

            doneServList.Add(servList[servInd]);
            servList.RemoveAt(servInd);
        }
        public int GetDoneServiceCount()
        {
            return doneServList.Count;
        }
    }
}
