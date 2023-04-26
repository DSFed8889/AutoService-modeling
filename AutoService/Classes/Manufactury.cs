
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    internal class Manufactury
    {
        int manufactureID;
        Worker[] workers;
        List<Request> requests = new List<Request>();
        public Manufactury (int manufactureID, Random rnd, int workersCount) {
            this.manufactureID = manufactureID;
            workers = new Worker[workersCount];
            for (int i = 0; i < workersCount; i++)
            {
                workers[i] = new Worker(rnd);
            }
        }

        public void SetRequest (Request request)
        {
            request.status = RequestStatus.onQueue;
            requests.Add(request);
        }

        public void Tick()
        {
            if (requests.Count > 0)
            {
                foreach (Worker worker in workers)
                {
                    if (!worker.isBusy)
                    {
                        for (int i = requests.Count - 1; i >= 0; i--)
                        {
                            if (requests[i].status == RequestStatus.onQueue)
                            {
                                List<string> servNames = new List<string>();
                                foreach (Service serv in requests[i].servList)
                                    if (serv.manufactureID == manufactureID)
                                        servNames.Add(serv.servName);
                                worker.SetRequest(requests[i], servNames);
                                requests.RemoveAt(i);
                                i = -1;
                            }
                        }
                    }
                    worker.Tick();
                }
            }
        }

        public void PaySalary()
        {
            foreach(Worker worker in workers)
            {
                if (worker.workedProfit * 0.35 > 7000)
                    worker.salary += (int)(worker.workedProfit * 0.35);
                else
                    worker.salary += 7000;
                worker.workedProfit = 0;
            }
        }

        public int GetSumSalary()
        {
            int sum = 0;
            foreach (Worker worker in workers)
                sum += worker.salary;
            return sum;
        }

        public int GetQueueLen()
        {
            return requests.Count;
        }

        public int GetBusyness()
        {
            int n = 0;
            foreach (Worker worker in workers)
                if (worker.isBusy)
                    n++;
            return n;
        }
    }
}
