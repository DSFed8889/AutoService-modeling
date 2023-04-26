namespace AutoService
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restartbtn = new System.Windows.Forms.Button();
            this.maxServListLenNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toEndbtn = new System.Windows.Forms.Button();
            this.stepBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.stepsNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.requestTimeMaxNUD = new System.Windows.Forms.NumericUpDown();
            this.requestTimeMinNUD = new System.Windows.Forms.NumericUpDown();
            this.workersCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moneyTb = new System.Windows.Forms.TextBox();
            this.totRequestCounttb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avgServeTimetb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.avgSalarytb = new System.Windows.Forms.TextBox();
            this.avgBusyAlltb = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.avgQueueLentb4 = new System.Windows.Forms.TextBox();
            this.avgQueueLentb3 = new System.Windows.Forms.TextBox();
            this.avgQueueLentb2 = new System.Windows.Forms.TextBox();
            this.avgQueueLentb1 = new System.Windows.Forms.TextBox();
            this.avgBusytb4 = new System.Windows.Forms.TextBox();
            this.avgBusytb3 = new System.Windows.Forms.TextBox();
            this.avgBusytb2 = new System.Windows.Forms.TextBox();
            this.avgBusytb1 = new System.Windows.Forms.TextBox();
            this.busytb4 = new System.Windows.Forms.TextBox();
            this.busytb3 = new System.Windows.Forms.TextBox();
            this.busytb2 = new System.Windows.Forms.TextBox();
            this.busytb1 = new System.Windows.Forms.TextBox();
            this.queueLentb4 = new System.Windows.Forms.TextBox();
            this.queueLentb3 = new System.Windows.Forms.TextBox();
            this.queueLentb2 = new System.Windows.Forms.TextBox();
            this.queueLentb1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.невыпУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выпУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requests = new AutoService.Data.Requests();
            this.dTRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTServiceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceInfo = new AutoService.Data.ServiceInfo();
            this.doneCounttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxServListLenNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTimeMaxNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTimeMinNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRequestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRequestBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTServiceInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restartbtn);
            this.groupBox1.Controls.Add(this.maxServListLenNUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeTb);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.toEndbtn);
            this.groupBox1.Controls.Add(this.stepBtn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.stepsNUD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.requestTimeMaxNUD);
            this.groupBox1.Controls.Add(this.requestTimeMinNUD);
            this.groupBox1.Controls.Add(this.workersCountNUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(319, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры системы";
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.SystemColors.Control;
            this.restartbtn.Enabled = false;
            this.restartbtn.Location = new System.Drawing.Point(154, 150);
            this.restartbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(90, 24);
            this.restartbtn.TabIndex = 36;
            this.restartbtn.Text = "Начать заново";
            this.restartbtn.UseVisualStyleBackColor = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // maxServListLenNUD
            // 
            this.maxServListLenNUD.Location = new System.Drawing.Point(271, 78);
            this.maxServListLenNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxServListLenNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxServListLenNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxServListLenNUD.Name = "maxServListLenNUD";
            this.maxServListLenNUD.Size = new System.Drawing.Size(39, 20);
            this.maxServListLenNUD.TabIndex = 35;
            this.maxServListLenNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Максимальное количество услуг в заявке";
            // 
            // timeTb
            // 
            this.timeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeTb.Location = new System.Drawing.Point(116, 181);
            this.timeTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTb.Name = "timeTb";
            this.timeTb.ReadOnly = true;
            this.timeTb.Size = new System.Drawing.Size(140, 19);
            this.timeTb.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 184);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Текущее время";
            // 
            // toEndbtn
            // 
            this.toEndbtn.BackColor = System.Drawing.SystemColors.Control;
            this.toEndbtn.Enabled = false;
            this.toEndbtn.Location = new System.Drawing.Point(45, 206);
            this.toEndbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toEndbtn.Name = "toEndbtn";
            this.toEndbtn.Size = new System.Drawing.Size(184, 24);
            this.toEndbtn.TabIndex = 29;
            this.toEndbtn.Text = "Промоделировать до конца";
            this.toEndbtn.UseVisualStyleBackColor = false;
            this.toEndbtn.Click += new System.EventHandler(this.toEndbtn_Click);
            // 
            // stepBtn
            // 
            this.stepBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.stepBtn.Location = new System.Drawing.Point(35, 152);
            this.stepBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(92, 24);
            this.stepBtn.TabIndex = 25;
            this.stepBtn.Text = "Начать";
            this.stepBtn.UseVisualStyleBackColor = false;
            this.stepBtn.Click += new System.EventHandler(this.stepBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "часов";
            // 
            // stepsNUD
            // 
            this.stepsNUD.Location = new System.Drawing.Point(154, 128);
            this.stepsNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stepsNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.stepsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepsNUD.Name = "stepsNUD";
            this.stepsNUD.Size = new System.Drawing.Size(53, 20);
            this.stepsNUD.TabIndex = 23;
            this.stepsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Шаг моделирования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "от";
            // 
            // requestTimeMaxNUD
            // 
            this.requestTimeMaxNUD.Location = new System.Drawing.Point(271, 50);
            this.requestTimeMaxNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requestTimeMaxNUD.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.requestTimeMaxNUD.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.requestTimeMaxNUD.Name = "requestTimeMaxNUD";
            this.requestTimeMaxNUD.Size = new System.Drawing.Size(39, 20);
            this.requestTimeMaxNUD.TabIndex = 8;
            this.requestTimeMaxNUD.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.requestTimeMaxNUD.ValueChanged += new System.EventHandler(this.requestTimeMaxNUD_ValueChanged);
            // 
            // requestTimeMinNUD
            // 
            this.requestTimeMinNUD.Location = new System.Drawing.Point(205, 50);
            this.requestTimeMinNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requestTimeMinNUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.requestTimeMinNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.requestTimeMinNUD.Name = "requestTimeMinNUD";
            this.requestTimeMinNUD.Size = new System.Drawing.Size(39, 20);
            this.requestTimeMinNUD.TabIndex = 7;
            this.requestTimeMinNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.requestTimeMinNUD.ValueChanged += new System.EventHandler(this.requestTimeMinNUD_ValueChanged);
            // 
            // workersCountNUD
            // 
            this.workersCountNUD.Location = new System.Drawing.Point(271, 20);
            this.workersCountNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workersCountNUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.workersCountNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.workersCountNUD.Name = "workersCountNUD";
            this.workersCountNUD.Size = new System.Drawing.Size(39, 20);
            this.workersCountNUD.TabIndex = 4;
            this.workersCountNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время между заявками(мин)";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество работников";
            // 
            // moneyChart
            // 
            chartArea1.AxisX.Title = "Время";
            chartArea1.AxisY.LabelStyle.Format = "##,# ₽";
            chartArea1.AxisY.Title = "Деньги";
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.moneyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.moneyChart.Legends.Add(legend1);
            this.moneyChart.Location = new System.Drawing.Point(14, 266);
            this.moneyChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyChart.Name = "moneyChart";
            this.moneyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Прибыль";
            series1.YValuesPerPoint = 4;
            this.moneyChart.Series.Add(series1);
            this.moneyChart.Size = new System.Drawing.Size(771, 232);
            this.moneyChart.TabIndex = 2;
            this.moneyChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doneCounttb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.moneyTb);
            this.groupBox2.Controls.Add(this.totRequestCounttb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.avgServeTimetb);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.avgSalarytb);
            this.groupBox2.Controls.Add(this.avgBusyAlltb);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.avgQueueLentb4);
            this.groupBox2.Controls.Add(this.avgQueueLentb3);
            this.groupBox2.Controls.Add(this.avgQueueLentb2);
            this.groupBox2.Controls.Add(this.avgQueueLentb1);
            this.groupBox2.Controls.Add(this.avgBusytb4);
            this.groupBox2.Controls.Add(this.avgBusytb3);
            this.groupBox2.Controls.Add(this.avgBusytb2);
            this.groupBox2.Controls.Add(this.avgBusytb1);
            this.groupBox2.Controls.Add(this.busytb4);
            this.groupBox2.Controls.Add(this.busytb3);
            this.groupBox2.Controls.Add(this.busytb2);
            this.groupBox2.Controls.Add(this.busytb1);
            this.groupBox2.Controls.Add(this.queueLentb4);
            this.groupBox2.Controls.Add(this.queueLentb3);
            this.groupBox2.Controls.Add(this.queueLentb2);
            this.groupBox2.Controls.Add(this.queueLentb1);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(359, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(412, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Общая информация";
            // 
            // moneyTb
            // 
            this.moneyTb.Location = new System.Drawing.Point(292, 187);
            this.moneyTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyTb.Name = "moneyTb";
            this.moneyTb.ReadOnly = true;
            this.moneyTb.Size = new System.Drawing.Size(82, 20);
            this.moneyTb.TabIndex = 11;
            // 
            // totRequestCounttb
            // 
            this.totRequestCounttb.Location = new System.Drawing.Point(170, 191);
            this.totRequestCounttb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totRequestCounttb.Name = "totRequestCounttb";
            this.totRequestCounttb.ReadOnly = true;
            this.totRequestCounttb.Size = new System.Drawing.Size(74, 20);
            this.totRequestCounttb.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(298, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Прибыль";
            // 
            // avgServeTimetb
            // 
            this.avgServeTimetb.Location = new System.Drawing.Point(170, 170);
            this.avgServeTimetb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgServeTimetb.Name = "avgServeTimetb";
            this.avgServeTimetb.ReadOnly = true;
            this.avgServeTimetb.Size = new System.Drawing.Size(74, 20);
            this.avgServeTimetb.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(365, 15);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "4";
            // 
            // avgSalarytb
            // 
            this.avgSalarytb.Location = new System.Drawing.Point(170, 147);
            this.avgSalarytb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgSalarytb.Name = "avgSalarytb";
            this.avgSalarytb.ReadOnly = true;
            this.avgSalarytb.Size = new System.Drawing.Size(74, 20);
            this.avgSalarytb.TabIndex = 29;
            // 
            // avgBusyAlltb
            // 
            this.avgBusyAlltb.Location = new System.Drawing.Point(170, 126);
            this.avgBusyAlltb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBusyAlltb.Name = "avgBusyAlltb";
            this.avgBusyAlltb.ReadOnly = true;
            this.avgBusyAlltb.Size = new System.Drawing.Size(74, 20);
            this.avgBusyAlltb.TabIndex = 28;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 193);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Общее число заявок";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 172);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "Ср. время обслуживания";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 149);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Ср. зарплата рабочих";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 128);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Ср. занятость рабочих";
            // 
            // avgQueueLentb4
            // 
            this.avgQueueLentb4.Location = new System.Drawing.Point(341, 99);
            this.avgQueueLentb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgQueueLentb4.Name = "avgQueueLentb4";
            this.avgQueueLentb4.ReadOnly = true;
            this.avgQueueLentb4.Size = new System.Drawing.Size(61, 20);
            this.avgQueueLentb4.TabIndex = 23;
            // 
            // avgQueueLentb3
            // 
            this.avgQueueLentb3.Location = new System.Drawing.Point(274, 99);
            this.avgQueueLentb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgQueueLentb3.Name = "avgQueueLentb3";
            this.avgQueueLentb3.ReadOnly = true;
            this.avgQueueLentb3.Size = new System.Drawing.Size(61, 20);
            this.avgQueueLentb3.TabIndex = 22;
            // 
            // avgQueueLentb2
            // 
            this.avgQueueLentb2.Location = new System.Drawing.Point(208, 99);
            this.avgQueueLentb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgQueueLentb2.Name = "avgQueueLentb2";
            this.avgQueueLentb2.ReadOnly = true;
            this.avgQueueLentb2.Size = new System.Drawing.Size(61, 20);
            this.avgQueueLentb2.TabIndex = 21;
            // 
            // avgQueueLentb1
            // 
            this.avgQueueLentb1.Location = new System.Drawing.Point(140, 99);
            this.avgQueueLentb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgQueueLentb1.Name = "avgQueueLentb1";
            this.avgQueueLentb1.ReadOnly = true;
            this.avgQueueLentb1.Size = new System.Drawing.Size(61, 20);
            this.avgQueueLentb1.TabIndex = 20;
            // 
            // avgBusytb4
            // 
            this.avgBusytb4.Location = new System.Drawing.Point(341, 76);
            this.avgBusytb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBusytb4.Name = "avgBusytb4";
            this.avgBusytb4.ReadOnly = true;
            this.avgBusytb4.Size = new System.Drawing.Size(61, 20);
            this.avgBusytb4.TabIndex = 19;
            // 
            // avgBusytb3
            // 
            this.avgBusytb3.Location = new System.Drawing.Point(274, 76);
            this.avgBusytb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBusytb3.Name = "avgBusytb3";
            this.avgBusytb3.ReadOnly = true;
            this.avgBusytb3.Size = new System.Drawing.Size(61, 20);
            this.avgBusytb3.TabIndex = 18;
            // 
            // avgBusytb2
            // 
            this.avgBusytb2.Location = new System.Drawing.Point(208, 76);
            this.avgBusytb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBusytb2.Name = "avgBusytb2";
            this.avgBusytb2.ReadOnly = true;
            this.avgBusytb2.Size = new System.Drawing.Size(61, 20);
            this.avgBusytb2.TabIndex = 17;
            // 
            // avgBusytb1
            // 
            this.avgBusytb1.Location = new System.Drawing.Point(140, 76);
            this.avgBusytb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBusytb1.Name = "avgBusytb1";
            this.avgBusytb1.ReadOnly = true;
            this.avgBusytb1.Size = new System.Drawing.Size(61, 20);
            this.avgBusytb1.TabIndex = 16;
            // 
            // busytb4
            // 
            this.busytb4.Location = new System.Drawing.Point(341, 54);
            this.busytb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.busytb4.Name = "busytb4";
            this.busytb4.ReadOnly = true;
            this.busytb4.Size = new System.Drawing.Size(61, 20);
            this.busytb4.TabIndex = 15;
            // 
            // busytb3
            // 
            this.busytb3.Location = new System.Drawing.Point(274, 54);
            this.busytb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.busytb3.Name = "busytb3";
            this.busytb3.ReadOnly = true;
            this.busytb3.Size = new System.Drawing.Size(61, 20);
            this.busytb3.TabIndex = 14;
            // 
            // busytb2
            // 
            this.busytb2.Location = new System.Drawing.Point(208, 54);
            this.busytb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.busytb2.Name = "busytb2";
            this.busytb2.ReadOnly = true;
            this.busytb2.Size = new System.Drawing.Size(61, 20);
            this.busytb2.TabIndex = 13;
            // 
            // busytb1
            // 
            this.busytb1.Location = new System.Drawing.Point(140, 54);
            this.busytb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.busytb1.Name = "busytb1";
            this.busytb1.ReadOnly = true;
            this.busytb1.Size = new System.Drawing.Size(61, 20);
            this.busytb1.TabIndex = 12;
            // 
            // queueLentb4
            // 
            this.queueLentb4.Location = new System.Drawing.Point(341, 31);
            this.queueLentb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueLentb4.Name = "queueLentb4";
            this.queueLentb4.ReadOnly = true;
            this.queueLentb4.Size = new System.Drawing.Size(61, 20);
            this.queueLentb4.TabIndex = 11;
            // 
            // queueLentb3
            // 
            this.queueLentb3.Location = new System.Drawing.Point(274, 31);
            this.queueLentb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueLentb3.Name = "queueLentb3";
            this.queueLentb3.ReadOnly = true;
            this.queueLentb3.Size = new System.Drawing.Size(61, 20);
            this.queueLentb3.TabIndex = 10;
            // 
            // queueLentb2
            // 
            this.queueLentb2.Location = new System.Drawing.Point(208, 31);
            this.queueLentb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueLentb2.Name = "queueLentb2";
            this.queueLentb2.ReadOnly = true;
            this.queueLentb2.Size = new System.Drawing.Size(61, 20);
            this.queueLentb2.TabIndex = 9;
            // 
            // queueLentb1
            // 
            this.queueLentb1.Location = new System.Drawing.Point(140, 31);
            this.queueLentb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueLentb1.Name = "queueLentb1";
            this.queueLentb1.ReadOnly = true;
            this.queueLentb1.Size = new System.Drawing.Size(61, 20);
            this.queueLentb1.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(103, 15);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Цеха:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(299, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(165, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 102);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Ср. длина очереди";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ср. занятость рабочих";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 56);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Занятость рабочих";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Длина очереди";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 502);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(561, 229);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заявки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.невыпУслугиDataGridViewTextBoxColumn,
            this.выпУслугиDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn,
            this.времяОбслуживанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTRequestBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // невыпУслугиDataGridViewTextBoxColumn
            // 
            this.невыпУслугиDataGridViewTextBoxColumn.DataPropertyName = "Невып. услуги";
            this.невыпУслугиDataGridViewTextBoxColumn.HeaderText = "Невып. услуги";
            this.невыпУслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.невыпУслугиDataGridViewTextBoxColumn.Name = "невыпУслугиDataGridViewTextBoxColumn";
            this.невыпУслугиDataGridViewTextBoxColumn.ReadOnly = true;
            this.невыпУслугиDataGridViewTextBoxColumn.Width = 179;
            // 
            // выпУслугиDataGridViewTextBoxColumn
            // 
            this.выпУслугиDataGridViewTextBoxColumn.DataPropertyName = "Вып. услуги";
            this.выпУслугиDataGridViewTextBoxColumn.HeaderText = "Вып. услуги";
            this.выпУслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.выпУслугиDataGridViewTextBoxColumn.Name = "выпУслугиDataGridViewTextBoxColumn";
            this.выпУслугиDataGridViewTextBoxColumn.ReadOnly = true;
            this.выпУслугиDataGridViewTextBoxColumn.Width = 179;
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            this.состояниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.состояниеDataGridViewTextBoxColumn.Width = 75;
            // 
            // времяОбслуживанияDataGridViewTextBoxColumn
            // 
            this.времяОбслуживанияDataGridViewTextBoxColumn.DataPropertyName = "Время обслуживания";
            this.времяОбслуживанияDataGridViewTextBoxColumn.HeaderText = "Время обслуживания";
            this.времяОбслуживанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяОбслуживанияDataGridViewTextBoxColumn.Name = "времяОбслуживанияDataGridViewTextBoxColumn";
            this.времяОбслуживанияDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяОбслуживанияDataGridViewTextBoxColumn.Width = 95;
            // 
            // dTRequestBindingSource1
            // 
            this.dTRequestBindingSource1.DataMember = "DTRequest";
            this.dTRequestBindingSource1.DataSource = this.requestsBindingSource;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataSource = this.requests;
            this.requestsBindingSource.Position = 0;
            // 
            // requests
            // 
            this.requests.DataSetName = "Requests";
            this.requests.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTRequestBindingSource
            // 
            this.dTRequestBindingSource.DataMember = "DTRequest";
            this.dTRequestBindingSource.DataSource = this.requestsBindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(574, 502);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(211, 229);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статистика услуг";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn,
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dTServiceInfoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(4, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 4;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(202, 207);
            this.dataGridView2.TabIndex = 0;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоВыполненныхУслугDataGridViewTextBoxColumn
            // 
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn.DataPropertyName = "Количество выполненных услуг";
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn.HeaderText = "Количество выполненных услуг";
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn.Name = "количествоВыполненныхУслугDataGridViewTextBoxColumn";
            this.количествоВыполненныхУслугDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTServiceInfoBindingSource
            // 
            this.dTServiceInfoBindingSource.DataMember = "DTServiceInfo";
            this.dTServiceInfoBindingSource.DataSource = this.serviceInfoBindingSource;
            // 
            // serviceInfoBindingSource
            // 
            this.serviceInfoBindingSource.DataSource = this.serviceInfo;
            this.serviceInfoBindingSource.Position = 0;
            // 
            // serviceInfo
            // 
            this.serviceInfo.DataSetName = "ServiceInfo";
            this.serviceInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doneCounttb
            // 
            this.doneCounttb.Location = new System.Drawing.Point(170, 215);
            this.doneCounttb.Margin = new System.Windows.Forms.Padding(2);
            this.doneCounttb.Name = "doneCounttb";
            this.doneCounttb.ReadOnly = true;
            this.doneCounttb.Size = new System.Drawing.Size(74, 20);
            this.doneCounttb.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Количество выполнненых";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 737);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.moneyChart);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 776);
            this.MinimumSize = new System.Drawing.Size(809, 776);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxServListLenNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTimeMaxNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTimeMinNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRequestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRequestBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTServiceInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown requestTimeMaxNUD;
        private System.Windows.Forms.NumericUpDown requestTimeMinNUD;
        private System.Windows.Forms.NumericUpDown workersCountNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toEndbtn;
        private System.Windows.Forms.Button stepBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown stepsNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart moneyChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox avgQueueLentb4;
        private System.Windows.Forms.TextBox avgQueueLentb3;
        private System.Windows.Forms.TextBox avgQueueLentb2;
        private System.Windows.Forms.TextBox avgQueueLentb1;
        private System.Windows.Forms.TextBox avgBusytb4;
        private System.Windows.Forms.TextBox avgBusytb3;
        private System.Windows.Forms.TextBox avgBusytb2;
        private System.Windows.Forms.TextBox avgBusytb1;
        private System.Windows.Forms.TextBox busytb4;
        private System.Windows.Forms.TextBox busytb3;
        private System.Windows.Forms.TextBox busytb2;
        private System.Windows.Forms.TextBox busytb1;
        private System.Windows.Forms.TextBox queueLentb4;
        private System.Windows.Forms.TextBox queueLentb3;
        private System.Windows.Forms.TextBox queueLentb2;
        private System.Windows.Forms.TextBox queueLentb1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox totRequestCounttb;
        private System.Windows.Forms.TextBox avgServeTimetb;
        private System.Windows.Forms.TextBox avgSalarytb;
        private System.Windows.Forms.TextBox avgBusyAlltb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource serviceInfoBindingSource;
        private Data.ServiceInfo serviceInfo;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private Data.Requests requests;
        private System.Windows.Forms.TextBox timeTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown maxServListLenNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dTRequestBindingSource;
        private System.Windows.Forms.BindingSource dTServiceInfoBindingSource;
        private System.Windows.Forms.BindingSource dTRequestBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВыполненныхУслугDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox moneyTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn невыпУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выпУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox doneCounttb;
        private System.Windows.Forms.Label label7;
    }
}

