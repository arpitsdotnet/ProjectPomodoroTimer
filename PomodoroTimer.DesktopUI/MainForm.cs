using PomodoroTimer.DesktopUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer.DesktopUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TimerForm timerForm = new TimerForm();
            //timerMini.MdiParent = this;
            timerForm.Show();

            AttachCounterUserControl();
            AttachAddTaskUserControl();

        }

        private void AttachCounterUserControl()
        {
            CounterUserControl counter = new CounterUserControl
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 10)
            };
            tlpContentPanel.Controls.Add(counter);
        }
        private void AttachAddTaskUserControl()
        {
            AddTaskUserControl addTask = new AddTaskUserControl
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 10)
            };
            tlpContentPanel.Controls.Add(addTask);
        }

        private void ResetAllTabs()
        {
            menuTodaysTask.BackColor = Color.White;
            menuTomorrowsTask.BackColor = Color.White;
            menuUpcomingTask.BackColor = Color.White;
            menuSomedayTask.BackColor = Color.White;
            menuCompletedTask.BackColor = Color.White;
        }

        private void menuTodaysTask_Click(object sender, EventArgs e)
        {
            ResetAllTabs();
            menuTodaysTask.BackColor = Color.WhiteSmoke;

            lblTitle.Text = "Today";

        }

        private void menuTomorrowsTask_Click(object sender, EventArgs e)
        {
            ResetAllTabs();
            menuTomorrowsTask.BackColor = Color.WhiteSmoke;

            lblTitle.Text = "Tomorrow";

        }

        private void menuUpcomingTask_Click(object sender, EventArgs e)
        {
            ResetAllTabs();
            menuUpcomingTask.BackColor = Color.WhiteSmoke;

            lblTitle.Text = "Upcoming";

        }

        private void menuSomedayTask_Click(object sender, EventArgs e)
        {
            ResetAllTabs();
            menuSomedayTask.BackColor = Color.WhiteSmoke;

            lblTitle.Text = "Someday";

        }

        private void menuCompletedTask_Click(object sender, EventArgs e)
        {
            ResetAllTabs();
            menuCompletedTask.BackColor = Color.WhiteSmoke;

            lblTitle.Text = "Completed";

        }
    }
}
