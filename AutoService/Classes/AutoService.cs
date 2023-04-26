using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    internal class AutoService
    {
        Manufactury[] manufacturies;

        public AutoService(Random rnd, int workersCount) {
            manufacturies = new Manufactury[4];
            for (int i = 0; i < 4; i++)
            {
                manufacturies[i] = new Manufactury(i, rnd, workersCount);
            }
        }

        public void SetRequest(Request request)
        {
            for (int i = 0; i < 4; i++)
                if (request.servList.FindIndex(x => x.manufactureID.Equals(i)) != -1)
                    manufacturies[i].SetRequest(request);
        }

        public void Tick()
        {
            foreach (Manufactury man in manufacturies)
                man.Tick();
        }

        public void PaySalary()
        {
            foreach (Manufactury man in manufacturies)
                man.PaySalary();
        }

        public int GetSumSalary()
        {
            int sum = 0;
            foreach (Manufactury man in manufacturies)
                sum += man.GetSumSalary();
            return sum;
        }

        public int[] GetQueuesLen()
        {
            int[] queues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                queues[i] = manufacturies[i].GetQueueLen();
            }
            return queues;
        }

        public int[] GetBusyness()
        {
            int[] busyness = new int[4];
            for (int i = 0; i < 4; i++)
                busyness[i] = manufacturies[i].GetBusyness();
            return busyness;
        }
    }
}
