using PomodoroTimer.ServiceLayer.Enumerations;
using PomodoroTimer.ServiceLayer;
using PomodoroTimer.ServiceLayer.Timers;
using PomodoroTimer.ServiceLayer.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using PomodoroTimer.ServiceLayer.Sounds;

namespace PomodoroTimer.DesktopUI
{
    public partial class TimerForm : Form
    {
        private readonly ICountdown _countdown;
        private readonly IAlarm _alarm;

        public TimerForm()
        {
            InitializeComponent();

            // To Initialize drag and drop using form itself.
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width - 30,
                                      workingArea.Bottom - Size.Height - 30);

            _countdown = Countdown.Instance;
            _countdown.TickHappened += Countdown_TickHappened;

            _alarm = new Alarm();

            TimerUpdate();
            SetsCountUpdate();
            SetWorkTheme();
        }

        #region DragAndDrop

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TimerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ShowPlayButtons(false);

            _countdown.StartCountdown();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _countdown.StopCountdown();

            ShowPlayButtons();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _countdown.StopCountdown();
            _countdown.ResetTime();

            ShowPlayButtons();

            TimerUpdate();
        }

        private void Countdown_TickHappened(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                TimerUpdate();
                if (_countdown.IsTimeup)
                {
                    ShowPlayButtons();
                    ResetTimerAndAlert();
                    TimerUpdate();
                }
            }));
        }

        private void ResetTimerAndAlert()
        {
            if (_countdown.IsSetsTypeWork == false)
            {
                // Work has started Or Break has finished (Sequence is important)
                _countdown.SetWorkTimer();

                SetsCountUpdate();
                SetWorkTheme();

                _alarm.PlaySound(StringConstant.WorkSoundLocation);

                MessageBoxShow("Let's start the work!", StringConstant.ApplicationTitle);
            }
            else
            {
                // Break has started Or Work has finished (Sequence is important)
                SetsCountUpdate();
                SetBreakTheme();

                _countdown.SetBreakTimer();

                _alarm.PlaySound(StringConstant.BreakSoundLocation);

                MessageBoxShow("Go enjoy this break time and remember to come back.", StringConstant.ApplicationTitle);
            }
        }

        private void MessageBoxShow(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void SetsCountUpdate()
        {
            lblPomodoroSet.Text = _countdown.SetsCount.ToString();
        }

        private void TimerUpdate()
        {
            lblTimer.Text = _countdown.MinutesLeft.ToString("00") + ":" + _countdown.SecondsLeft.ToString("00");
        }

        private void SetBreakTheme()
        {
            lblSetType.Text = SetsTypes.Break.ToString();
            this.BackColor = Color.SteelBlue;
        }

        private void SetWorkTheme()
        {
            lblSetType.Text = SetsTypes.Work.ToString();
            this.BackColor = Color.OrangeRed;
        }

        /// <summary>
        /// When isPlayActive is true, Button play will show
        /// </summary>
        private void ShowPlayButtons(bool isPlayActive = true)
        {
            if (isPlayActive)
            {
                this.btnPlay.Show();
                this.btnPause.Hide();
                this.btnStop.Hide();
            }
            else
            {
                this.btnPlay.Hide();
                this.btnPause.Show();
                this.btnStop.Show();
            }
        }
    }
}
