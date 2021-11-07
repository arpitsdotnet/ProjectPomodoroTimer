
namespace PomodoroTimer.DesktopUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.menuCompletedTask = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuSomedayTask = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSomedayTaskTimeH = new System.Windows.Forms.Label();
            this.lblSomedayTaskCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuUpcomingTask = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUpcomingTaskTimeH = new System.Windows.Forms.Label();
            this.lblUpcomingTaskCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuTomorrowsTask = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTomorrowTaskTimeH = new System.Windows.Forms.Label();
            this.lblTomorrowTaskCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuTodaysTask = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTodayTaskTimeH = new System.Windows.Forms.Label();
            this.lblTodayTaskCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpContentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuCompletedTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuSomedayTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuUpcomingTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuTomorrowsTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuTodaysTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpContentPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 770);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(876, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 720);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.menuCompletedTask);
            this.panel1.Controls.Add(this.menuSomedayTask);
            this.panel1.Controls.Add(this.menuUpcomingTask);
            this.panel1.Controls.Add(this.menuTomorrowsTask);
            this.panel1.Controls.Add(this.menuTodaysTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(300, 770);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(20, 201);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(260, 1);
            this.panel8.TabIndex = 8;
            // 
            // menuCompletedTask
            // 
            this.menuCompletedTask.Controls.Add(this.pictureBox5);
            this.menuCompletedTask.Controls.Add(this.label2);
            this.menuCompletedTask.Controls.Add(this.label3);
            this.menuCompletedTask.Controls.Add(this.label7);
            this.menuCompletedTask.Location = new System.Drawing.Point(0, 148);
            this.menuCompletedTask.Name = "menuCompletedTask";
            this.menuCompletedTask.Size = new System.Drawing.Size(300, 33);
            this.menuCompletedTask.TabIndex = 7;
            this.menuCompletedTask.Click += new System.EventHandler(this.menuCompletedTask_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 6);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.menuCompletedTask_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "0h";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.menuCompletedTask_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.menuCompletedTask_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(56, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Completed";
            this.label7.Click += new System.EventHandler(this.menuCompletedTask_Click);
            // 
            // menuSomedayTask
            // 
            this.menuSomedayTask.Controls.Add(this.pictureBox4);
            this.menuSomedayTask.Controls.Add(this.lblSomedayTaskTimeH);
            this.menuSomedayTask.Controls.Add(this.lblSomedayTaskCount);
            this.menuSomedayTask.Controls.Add(this.label6);
            this.menuSomedayTask.Location = new System.Drawing.Point(0, 112);
            this.menuSomedayTask.Name = "menuSomedayTask";
            this.menuSomedayTask.Size = new System.Drawing.Size(300, 33);
            this.menuSomedayTask.TabIndex = 6;
            this.menuSomedayTask.Click += new System.EventHandler(this.menuSomedayTask_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.menuSomedayTask_Click);
            // 
            // lblSomedayTaskTimeH
            // 
            this.lblSomedayTaskTimeH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSomedayTaskTimeH.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomedayTaskTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSomedayTaskTimeH.Location = new System.Drawing.Point(228, 9);
            this.lblSomedayTaskTimeH.Name = "lblSomedayTaskTimeH";
            this.lblSomedayTaskTimeH.Size = new System.Drawing.Size(28, 16);
            this.lblSomedayTaskTimeH.TabIndex = 2;
            this.lblSomedayTaskTimeH.Text = "0h";
            this.lblSomedayTaskTimeH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSomedayTaskTimeH.Click += new System.EventHandler(this.menuSomedayTask_Click);
            // 
            // lblSomedayTaskCount
            // 
            this.lblSomedayTaskCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSomedayTaskCount.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomedayTaskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSomedayTaskCount.Location = new System.Drawing.Point(262, 9);
            this.lblSomedayTaskCount.Name = "lblSomedayTaskCount";
            this.lblSomedayTaskCount.Size = new System.Drawing.Size(28, 16);
            this.lblSomedayTaskCount.TabIndex = 1;
            this.lblSomedayTaskCount.Text = "0";
            this.lblSomedayTaskCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSomedayTaskCount.Click += new System.EventHandler(this.menuSomedayTask_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(56, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Someday";
            this.label6.Click += new System.EventHandler(this.menuSomedayTask_Click);
            // 
            // menuUpcomingTask
            // 
            this.menuUpcomingTask.Controls.Add(this.pictureBox3);
            this.menuUpcomingTask.Controls.Add(this.lblUpcomingTaskTimeH);
            this.menuUpcomingTask.Controls.Add(this.lblUpcomingTaskCount);
            this.menuUpcomingTask.Controls.Add(this.label5);
            this.menuUpcomingTask.Location = new System.Drawing.Point(0, 76);
            this.menuUpcomingTask.Name = "menuUpcomingTask";
            this.menuUpcomingTask.Size = new System.Drawing.Size(300, 33);
            this.menuUpcomingTask.TabIndex = 5;
            this.menuUpcomingTask.Click += new System.EventHandler(this.menuUpcomingTask_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.menuUpcomingTask_Click);
            // 
            // lblUpcomingTaskTimeH
            // 
            this.lblUpcomingTaskTimeH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpcomingTaskTimeH.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingTaskTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUpcomingTaskTimeH.Location = new System.Drawing.Point(228, 9);
            this.lblUpcomingTaskTimeH.Name = "lblUpcomingTaskTimeH";
            this.lblUpcomingTaskTimeH.Size = new System.Drawing.Size(28, 16);
            this.lblUpcomingTaskTimeH.TabIndex = 2;
            this.lblUpcomingTaskTimeH.Text = "0h";
            this.lblUpcomingTaskTimeH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUpcomingTaskTimeH.Click += new System.EventHandler(this.menuUpcomingTask_Click);
            // 
            // lblUpcomingTaskCount
            // 
            this.lblUpcomingTaskCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpcomingTaskCount.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingTaskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUpcomingTaskCount.Location = new System.Drawing.Point(262, 9);
            this.lblUpcomingTaskCount.Name = "lblUpcomingTaskCount";
            this.lblUpcomingTaskCount.Size = new System.Drawing.Size(28, 16);
            this.lblUpcomingTaskCount.TabIndex = 1;
            this.lblUpcomingTaskCount.Text = "0";
            this.lblUpcomingTaskCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUpcomingTaskCount.Click += new System.EventHandler(this.menuUpcomingTask_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(56, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Upcoming";
            this.label5.Click += new System.EventHandler(this.menuUpcomingTask_Click);
            // 
            // menuTomorrowsTask
            // 
            this.menuTomorrowsTask.Controls.Add(this.pictureBox2);
            this.menuTomorrowsTask.Controls.Add(this.lblTomorrowTaskTimeH);
            this.menuTomorrowsTask.Controls.Add(this.lblTomorrowTaskCount);
            this.menuTomorrowsTask.Controls.Add(this.label4);
            this.menuTomorrowsTask.Location = new System.Drawing.Point(0, 40);
            this.menuTomorrowsTask.Name = "menuTomorrowsTask";
            this.menuTomorrowsTask.Size = new System.Drawing.Size(300, 33);
            this.menuTomorrowsTask.TabIndex = 4;
            this.menuTomorrowsTask.Click += new System.EventHandler(this.menuTomorrowsTask_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.menuTomorrowsTask_Click);
            // 
            // lblTomorrowTaskTimeH
            // 
            this.lblTomorrowTaskTimeH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTomorrowTaskTimeH.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowTaskTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTomorrowTaskTimeH.Location = new System.Drawing.Point(228, 9);
            this.lblTomorrowTaskTimeH.Name = "lblTomorrowTaskTimeH";
            this.lblTomorrowTaskTimeH.Size = new System.Drawing.Size(28, 16);
            this.lblTomorrowTaskTimeH.TabIndex = 2;
            this.lblTomorrowTaskTimeH.Text = "0h";
            this.lblTomorrowTaskTimeH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTomorrowTaskTimeH.Click += new System.EventHandler(this.menuTomorrowsTask_Click);
            // 
            // lblTomorrowTaskCount
            // 
            this.lblTomorrowTaskCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTomorrowTaskCount.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowTaskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTomorrowTaskCount.Location = new System.Drawing.Point(262, 9);
            this.lblTomorrowTaskCount.Name = "lblTomorrowTaskCount";
            this.lblTomorrowTaskCount.Size = new System.Drawing.Size(28, 16);
            this.lblTomorrowTaskCount.TabIndex = 1;
            this.lblTomorrowTaskCount.Text = "0";
            this.lblTomorrowTaskCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTomorrowTaskCount.Click += new System.EventHandler(this.menuTomorrowsTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(56, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tomorrow";
            this.label4.Click += new System.EventHandler(this.menuTomorrowsTask_Click);
            // 
            // menuTodaysTask
            // 
            this.menuTodaysTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuTodaysTask.Controls.Add(this.pictureBox1);
            this.menuTodaysTask.Controls.Add(this.lblTodayTaskTimeH);
            this.menuTodaysTask.Controls.Add(this.lblTodayTaskCount);
            this.menuTodaysTask.Controls.Add(this.label1);
            this.menuTodaysTask.Location = new System.Drawing.Point(0, 4);
            this.menuTodaysTask.Name = "menuTodaysTask";
            this.menuTodaysTask.Size = new System.Drawing.Size(300, 33);
            this.menuTodaysTask.TabIndex = 0;
            this.menuTodaysTask.Click += new System.EventHandler(this.menuTodaysTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.menuTodaysTask_Click);
            // 
            // lblTodayTaskTimeH
            // 
            this.lblTodayTaskTimeH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayTaskTimeH.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTaskTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTodayTaskTimeH.Location = new System.Drawing.Point(228, 9);
            this.lblTodayTaskTimeH.Name = "lblTodayTaskTimeH";
            this.lblTodayTaskTimeH.Size = new System.Drawing.Size(28, 16);
            this.lblTodayTaskTimeH.TabIndex = 2;
            this.lblTodayTaskTimeH.Text = "0h";
            this.lblTodayTaskTimeH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTodayTaskTimeH.Click += new System.EventHandler(this.menuTodaysTask_Click);
            // 
            // lblTodayTaskCount
            // 
            this.lblTodayTaskCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayTaskCount.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTaskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTodayTaskCount.Location = new System.Drawing.Point(262, 9);
            this.lblTodayTaskCount.Name = "lblTodayTaskCount";
            this.lblTodayTaskCount.Size = new System.Drawing.Size(28, 16);
            this.lblTodayTaskCount.TabIndex = 1;
            this.lblTodayTaskCount.Text = "0";
            this.lblTodayTaskCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTodayTaskCount.Click += new System.EventHandler(this.menuTodaysTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today";
            this.label1.Click += new System.EventHandler(this.menuTodaysTask_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(303, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(570, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Today";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpContentPanel
            // 
            this.tlpContentPanel.ColumnCount = 1;
            this.tlpContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContentPanel.Location = new System.Drawing.Point(310, 50);
            this.tlpContentPanel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tlpContentPanel.Name = "tlpContentPanel";
            this.tlpContentPanel.RowCount = 3;
            this.tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentPanel.Size = new System.Drawing.Size(556, 710);
            this.tlpContentPanel.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 770);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuCompletedTask.ResumeLayout(false);
            this.menuCompletedTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuSomedayTask.ResumeLayout(false);
            this.menuSomedayTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuUpcomingTask.ResumeLayout(false);
            this.menuUpcomingTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuTomorrowsTask.ResumeLayout(false);
            this.menuTomorrowsTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuTodaysTask.ResumeLayout(false);
            this.menuTodaysTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContentPanel;
        private System.Windows.Forms.Panel menuCompletedTask;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel menuSomedayTask;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSomedayTaskTimeH;
        private System.Windows.Forms.Label lblSomedayTaskCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel menuUpcomingTask;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUpcomingTaskTimeH;
        private System.Windows.Forms.Label lblUpcomingTaskCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel menuTomorrowsTask;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTomorrowTaskTimeH;
        private System.Windows.Forms.Label lblTomorrowTaskCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel menuTodaysTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTodayTaskTimeH;
        private System.Windows.Forms.Label lblTodayTaskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer1;
    }
}