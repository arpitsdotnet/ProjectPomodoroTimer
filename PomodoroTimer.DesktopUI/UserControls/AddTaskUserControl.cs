using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer.DesktopUI.UserControls
{
    public partial class AddTaskUserControl : UserControl
    {
        private string newTaskText = "Add a task to a selected project, press [Enter] to save.";
        public AddTaskUserControl()
        {
            InitializeComponent();
            txtNewTask.Height = 20;
            txtNewTask.Text = newTaskText;
        }

        private void txtNewTask_Click(object sender, EventArgs e)
        {
            if (txtNewTask.Text.Trim() == "")
            {
                txtNewTask.Text = newTaskText;
            }
            if (txtNewTask.Text.Trim() == newTaskText)
            {
                txtNewTask.Text = "";
                txtNewTask.Focus();
            }
        }

        private void txtNewTask_Leave(object sender, EventArgs e)
        {
            if (txtNewTask.Text.Trim() == "")
            {
                txtNewTask.Text = newTaskText;
            }
        }

        private void txtNewTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNewTask.Text = newTaskText;
            }
        }
    }
}
