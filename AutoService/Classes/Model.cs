using AutoService.Data;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace AutoService.Classes
{
    internal class Model
    {
        private List<Service> services;
        AutoService autoService;
        List<Request> requestList = new List<Request>();
        Random rnd = new Random();
        int requestTimer;
        int workersCount;
        int maxServListLen;
        int[] requestTime;
        int time;
        int[] queuesSum;
        int[] busynessesSum;
        int ticksCount = 0;

        const int endTime = 9660;

        public Model(List<Service> services, int workersCount, int maxServListLen, int[] requestTime) {
            this.services = services;
            this.maxServListLen = maxServListLen;
            this.workersCount = workersCount;
            autoService = new AutoService(rnd, workersCount);
            this.requestTime = requestTime;
            queuesSum = new int[4] { 0, 0, 0, 0 };
            busynessesSum = new int[4] { 0, 0, 0, 0 };
            requestTimer = 0;
            time = 540;
        }

        public bool IsEnd()
        {
            return time >= endTime;
        }

        public string GetTime()
        {
            return (time / 1440 + 1).ToString() + "-й день " + (time % 1440 / 60).ToString() + "-й час";
        }

        private void nextTime()
        {
        }

        private bool isNotWorkTime()
        {
            int day = (time / 1440) % 7;
            bool isMorning = time % 1440 < 540;
            if (day == 5 || day == 6)
                return isMorning || time % 1440 > 1020;
            else
                return isMorning || time % 1440 > 1260;
        }

        public void Tick()
        {

            time++;

            if (time % 10080 == 9660)
                autoService.PaySalary();

            nextTime();
            if (isNotWorkTime())
                return;

            if (requestTimer > 0)
                requestTimer--;
            else
            {
                Request request = new Request(services, rnd, maxServListLen, time);
                requestList.Add(request);
                autoService.SetRequest(request);
                requestTimer = rnd.Next(requestTime[0], requestTime[1] + 1);
            }
            autoService.Tick();

            int[] queues = autoService.GetQueuesLen();
            int[] busynesses = autoService.GetBusyness();
            for (int i = 0; i < 4; i++)
            {
                queuesSum[i] += queues[i];
                busynessesSum[i] += busynesses[i];
            }
            ticksCount++;

            foreach (var request in requestList)
                if (request.status == RequestStatus.done && request.endTime == 0)
                    request.endTime = time;
        }

        public void SetRequestsDT(Requests requests)
        {
            requests.DTRequest.Clear();

            foreach (var request in requestList)
            {
                DataRow dr = requests.DTRequest.NewRow();

                List<string> servs = new List<string>();
                List<string> doneServs = new List<string>();
                foreach (Service service in request.servList)
                    servs.Add(service.servName);
                foreach (Service service in request.doneServList)
                    doneServs.Add(service.servName);

                dr["Невып. услуги"] = String.Join(", ", servs.ToArray());
                dr["Вып. услуги"] = String.Join(", ", doneServs.ToArray());
                switch (request.status)
                {
                    case RequestStatus.done:
                        dr["Состояние"] = "Выполнена";
                        break;
                    case RequestStatus.onWork:
                        dr["Состояние"] = "В работе";
                        break;
                    case RequestStatus.onQueue:
                        dr["Состояние"] = "В очереди";
                        break;
                }

                int requestTime = (request.endTime == 0 ? time : request.endTime) - request.startTime;
                dr["Время обслуживания"] = requestTime / 60 + " ч. " + requestTime % 60 + " мин.";

                requests.DTRequest.Rows.Add(dr);
            }
        }

        public void SetServiceInfoDT(ServiceInfo serviceInfo)
        {
            serviceInfo.DTServiceInfo.Clear();

            int[] doneCount = new int[services.Count];

            foreach (Request request in requestList)
                foreach (Service serv in request.doneServList)
                    doneCount[services.FindIndex(x => x.servName.Equals(serv.servName))]++;

            foreach (Service serv in services)
            {
                DataRow dr = serviceInfo.DTServiceInfo.NewRow();
                dr["Имя"] = serv.servName;
                dr["Количество выполненных услуг"] = doneCount[services.FindIndex(x => x.servName.Equals(serv.servName))];
                serviceInfo.DTServiceInfo.Rows.Add(dr);
            }
        }

        public void SetMoneyChart(Chart moneyChart)
        {
            moneyChart.Series[0].Points.AddXY(GetTime(), GetMoney());
        }

        public int GetMoney()
        {
            int money = 0;
            foreach (Request request in requestList)
                foreach (Service serv in request.doneServList)
                    money += serv.price;
            money -= autoService.GetSumSalary();
            return money;
        }

        public float[] GetAvgQueueLen()
        {
            float[] avgQueues = new float[4];
            for (int i = 0; i < 4; i++)
                avgQueues[i] = ticksCount > 0 ? (float)queuesSum[i] / ticksCount : 0;
            return avgQueues;
        }

        public string GetAvgServeTime()
        {
            float avgServeTime = 0;
            int count = 0;
            foreach (var request in requestList)
            {
                avgServeTime += (request.endTime != 0 ? request.endTime : time) - request.startTime;
                count++;
            }
            int servTime = count == 0 ? 0 : (int)Math.Round(avgServeTime / count);
            return servTime / 60 + " ч. " + servTime % 60 + " мин.";
        }

        public float[] GetAvgBusyness()
        {
            float[] avgBusinesses = new float[4];
            for (int i = 0; i < 4; i++)
                avgBusinesses[i] = ticksCount > 0 ? (float)busynessesSum[i] / ticksCount : 0;
            return avgBusinesses;
        }

        public float GetAvgSalary()
        {
            return autoService.GetSumSalary() / (4 * workersCount);
        }

        public int[] GetQueuesLen()
        {
            return autoService.GetQueuesLen();
        }

        public int[] GetBusyness()
        {
            return autoService.GetBusyness();
        }

        public int GetRequestNum()
        {
            return requestList.Count;
        }

        public int GetDoneRequestNum()
        {
            int n = 0;
            foreach (var req in requestList)
                if (req.status == RequestStatus.done) n++;
            return n;
        }
    }
}
