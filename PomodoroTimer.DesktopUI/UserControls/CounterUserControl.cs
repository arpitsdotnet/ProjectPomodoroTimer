﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer.DesktopUI.UserControls
{
    [DesignerAttribute("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CounterUserControl : UserControl
    {
        public CounterUserControl()
        {
            InitializeComponent();
        }
    }
}
