﻿
namespace PomodoroTimer.UserControls
{
    partial class CounterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.lblElapsedTimeH = new System.Windows.Forms.Label();
            this.lblTasksToBeCompleted = new System.Windows.Forms.Label();
            this.lblEstimatedTimeH = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCompletedTasks, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblElapsedTimeH, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTasksToBeCompleted, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEstimatedTimeH, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(765, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Completed Tasks";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(510, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Elapsed time (h)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(255, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tasks to be completed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estimated time (h)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTasks.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCompletedTasks.Location = new System.Drawing.Point(768, 0);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblCompletedTasks.Size = new System.Drawing.Size(251, 50);
            this.lblCompletedTasks.TabIndex = 3;
            this.lblCompletedTasks.Text = "0";
            this.lblCompletedTasks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblElapsedTimeH
            // 
            this.lblElapsedTimeH.AutoSize = true;
            this.lblElapsedTimeH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblElapsedTimeH.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTimeH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblElapsedTimeH.Location = new System.Drawing.Point(513, 0);
            this.lblElapsedTimeH.Name = "lblElapsedTimeH";
            this.lblElapsedTimeH.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblElapsedTimeH.Size = new System.Drawing.Size(249, 50);
            this.lblElapsedTimeH.TabIndex = 2;
            this.lblElapsedTimeH.Text = "0.0";
            this.lblElapsedTimeH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTasksToBeCompleted
            // 
            this.lblTasksToBeCompleted.AutoSize = true;
            this.lblTasksToBeCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTasksToBeCompleted.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksToBeCompleted.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTasksToBeCompleted.Location = new System.Drawing.Point(258, 0);
            this.lblTasksToBeCompleted.Name = "lblTasksToBeCompleted";
            this.lblTasksToBeCompleted.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTasksToBeCompleted.Size = new System.Drawing.Size(249, 50);
            this.lblTasksToBeCompleted.TabIndex = 1;
            this.lblTasksToBeCompleted.Text = "0";
            this.lblTasksToBeCompleted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstimatedTimeH
            // 
            this.lblEstimatedTimeH.AutoSize = true;
            this.lblEstimatedTimeH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstimatedTimeH.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTimeH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEstimatedTimeH.Location = new System.Drawing.Point(3, 0);
            this.lblEstimatedTimeH.Name = "lblEstimatedTimeH";
            this.lblEstimatedTimeH.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblEstimatedTimeH.Size = new System.Drawing.Size(249, 50);
            this.lblEstimatedTimeH.TabIndex = 0;
            this.lblEstimatedTimeH.Text = "0.0";
            this.lblEstimatedTimeH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CounterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CounterUserControl";
            this.Size = new System.Drawing.Size(1022, 70);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Label lblElapsedTimeH;
        private System.Windows.Forms.Label lblTasksToBeCompleted;
        private System.Windows.Forms.Label lblEstimatedTimeH;
    }
}
