using AutoService.Classes;
using AutoService.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoService
{
    public partial class MainForm : Form
    {
        Model model;
        List<Service> services;

        NumberFormatInfo ru = new CultureInfo("ru-RU", false).NumberFormat;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            services = new List<Service>();

            using (StreamReader file = new StreamReader("../../Data/Services.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                    parseLine(ln);
                file.Close();
            }

            model = null;
        }

        private void ShowStats()
        {
            timeTb.Text = model.GetTime();

            moneyTb.Text = model.GetMoney().ToString("C", ru);

            model.SetRequestsDT(requests);
            model.SetServiceInfoDT(serviceInfo);

            int[] queueLens = model.GetQueuesLen();
            queueLentb1.Text = queueLens[0].ToString();
            queueLentb2.Text = queueLens[1].ToString();
            queueLentb3.Text = queueLens[2].ToString();
            queueLentb4.Text = queueLens[3].ToString();

            float[] avgQueueLens = model.GetAvgQueueLen();
            avgQueueLentb1.Text = Math.Round(avgQueueLens[0], 2).ToString();
            avgQueueLentb2.Text = Math.Round(avgQueueLens[1], 2).ToString();
            avgQueueLentb3.Text = Math.Round(avgQueueLens[2], 2).ToString();
            avgQueueLentb4.Text = Math.Round(avgQueueLens[3], 2).ToString();

            int[] busynesses = model.GetBusyness();
            busytb1.Text = busynesses[0].ToString();
            busytb2.Text = busynesses[1].ToString();
            busytb3.Text = busynesses[2].ToString();
            busytb4.Text = busynesses[3].ToString();

            float[] avgBusynesses = model.GetAvgBusyness();
            avgBusytb1.Text = Math.Round(avgBusynesses[0], 2).ToString();
            avgBusytb2.Text = Math.Round(avgBusynesses[1], 2).ToString();
            avgBusytb3.Text = Math.Round(avgBusynesses[2], 2).ToString();
            avgBusytb4.Text = Math.Round(avgBusynesses[3], 2).ToString();

            float avgBusyAll = 0;
            foreach (float i in avgBusynesses)
                avgBusyAll += i;
            avgBusyAlltb.Text = Math.Round((avgBusyAll / 4), 2).ToString();

            avgSalarytb.Text = Math.Round(model.GetAvgSalary(), 2).ToString("C", ru);

            avgServeTimetb.Text = model.GetAvgServeTime();

            totRequestCounttb.Text = model.GetRequestNum().ToString();

            doneCounttb.Text = model.GetDoneRequestNum().ToString();
        }

        private void parseLine(string line)
        {
            string[] servInfo = line.Split(',');
            services.Add(new Service(servInfo[0], int.Parse(servInfo[1]), int.Parse(servInfo[2]), int.Parse(servInfo[3]), int.Parse(servInfo[4])));
        }

        private void start()
        {
            model = new Model(services, (int)workersCountNUD.Value, (int)maxServListLenNUD.Value, new int[2] { (int)requestTimeMinNUD.Value, (int)requestTimeMaxNUD.Value });
            ShowStats();
            moneyChart.Series[0].Points.AddXY(model.GetTime(), model.GetMoney());

            stepBtn.Text = "Сделать шаг";

            toEndbtn.Enabled = true;
            restartbtn.Enabled = true;

            stepBtn.BackColor = Color.MediumAquamarine;
            toEndbtn.BackColor = Color.MediumAquamarine;
            restartbtn.BackColor = Color.LightCoral;

            maxServListLenNUD.Enabled = false;
            requestTimeMaxNUD.Enabled = false;
            requestTimeMinNUD.Enabled = false;
            workersCountNUD.Enabled = false;
        }

        private void step()
        {
            for (int i = 0; i < (int)stepsNUD.Value * 60; i++)
            {
                model.Tick();
                if (i % 60 == 0)
                    moneyChart.Series[0].Points.AddXY(model.GetTime(), model.GetMoney());

                if (model.IsEnd())
                {
                    stepBtn.Text = "Начать";
                    stepBtn.Enabled = false;
                    toEndbtn.Enabled = false;

                    stepBtn.BackColor = Color.White;
                    toEndbtn.BackColor = Color.White;
                    restartbtn.BackColor = Color.LightCoral;

                    break;
                }
            }
            moneyChart.Series[0].Points.AddXY(model.GetTime(), model.GetMoney());
        }

        private void stepBtn_Click(object sender, EventArgs e)
        {
            if (model == null)
                start();
            else
            {
                step();
                ShowStats();
            }
        }

        private void toEndbtn_Click(object sender, EventArgs e)
        {
            stepsNUD.Value = 12;
            while (!model.IsEnd())
                step();
            ShowStats();
            
            stepBtn.Text = "Начать";
            stepBtn.Enabled = false;
            toEndbtn.Enabled = false;


            stepBtn.BackColor = Color.White;
            toEndbtn.BackColor = Color.White;
            restartbtn.BackColor = Color.LightCoral;

            ShowStats();

            stepsNUD.Value = 1;
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            model = null;

            stepBtn.Text = "Начать";

            maxServListLenNUD.Enabled = true;
            requestTimeMaxNUD.Enabled = true;
            requestTimeMinNUD.Enabled = true;
            workersCountNUD.Enabled = true;

            stepBtn.Enabled = true;
            toEndbtn.Enabled = false;
            restartbtn.Enabled = false;

            stepBtn.BackColor = Color.PaleGreen;
            toEndbtn.BackColor = Color.White;
            restartbtn.BackColor = Color.White;

            moneyChart.Series[0].Points.Clear();
        }

        private void requestTimeMaxNUD_ValueChanged(object sender, EventArgs e)
        {
            if (requestTimeMaxNUD.Value < requestTimeMinNUD.Value)
                requestTimeMaxNUD.Value = requestTimeMinNUD.Value;
        }

        private void requestTimeMinNUD_ValueChanged(object sender, EventArgs e)
        {
            requestTimeMaxNUD_ValueChanged(sender, e);
        }
    }
}
