
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

        //конструктор
        public Manufactury (int manufactureID, Random rnd, int workersCount) {
            this.manufactureID = manufactureID;
            workers = new Worker[workersCount];
            for (int i = 0; i < workersCount; i++)
            {
                workers[i] = new Worker(rnd);
            }
        }

        //установка заявки в очередь
        public void SetRequest (Request request)
        {
            request.status = RequestStatus.onQueue;
            requests.Add(request);
        }

        //минута работы цеха
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

        //выдача зарплаты рабочим
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

        //получение общей суммы выплат рабочим цеха
        public int GetSumSalary()
        {
            int sum = 0;
            foreach (Worker worker in workers)
                sum += worker.salary;
            return sum;
        }

        //получение длины очереди в цеху
        public int GetQueueLen()
        {
            return requests.Count;
        }

        //получение занятости рабочих в цеху
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
