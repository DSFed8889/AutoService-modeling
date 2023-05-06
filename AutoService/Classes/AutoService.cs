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

        //конструктор
        public AutoService(Random rnd, int workersCount) {
            manufacturies = new Manufactury[4];
            for (int i = 0; i < 4; i++)
            {
                manufacturies[i] = new Manufactury(i, rnd, workersCount);
            }
        }

        //отправка заявки в цеха
        public void SetRequest(Request request)
        {
            for (int i = 0; i < 4; i++)
                if (request.servList.FindIndex(x => x.manufactureID.Equals(i)) != -1)
                    manufacturies[i].SetRequest(request);
        }

        //минута работы автосервиса
        public void Tick()
        {
            foreach (Manufactury man in manufacturies)
                man.Tick();
        }

        //команда всем цехам выдать зарплату рабочим
        public void PaySalary()
        {
            foreach (Manufactury man in manufacturies)
                man.PaySalary();
        }

        //получение полной суммы выплат рабочим
        public int GetSumSalary()
        {
            int sum = 0;
            foreach (Manufactury man in manufacturies)
                sum += man.GetSumSalary();
            return sum;
        }

        //получение длин очередей в цехах
        public int[] GetQueuesLen()
        {
            int[] queues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                queues[i] = manufacturies[i].GetQueueLen();
            }
            return queues;
        }

        //получение занятости в цехах
        public int[] GetBusyness()
        {
            int[] busyness = new int[4];
            for (int i = 0; i < 4; i++)
                busyness[i] = manufacturies[i].GetBusyness();
            return busyness;
        }
    }
}
