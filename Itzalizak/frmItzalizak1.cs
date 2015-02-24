using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Itzalizak
{
    public partial class frmItzalizak1 : Form
    {
        private double totalSegunduak;
        protected DateTime itzaliordua;
        protected bool SetchkAukerak;

        public frmItzalizak1()
        {
            InitializeComponent();
        }

        private void cmdEzeztatu_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "shutdown";
            startInfo.Arguments = "/a";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(startInfo);

            lblInfo.Text = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            burutuAgindua();            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            burutuAgindua();    
        }

   
        protected void burutuAgindua()
        {
            int urtea = monthCalendar1.SelectionRange.Start.Year;
            int hilabetea = monthCalendar1.SelectionRange.Start.Month;
            int eguna = monthCalendar1.SelectionRange.Start.Day;
            int orduak = dateTimePicker1.Value.Hour;
            int minutuak = dateTimePicker1.Value.Minute;
            int segunduak = dateTimePicker1.Value.Second;

            itzaliordua = new DateTime(urtea, hilabetea, eguna, orduak, minutuak, segunduak);
            DateTime orain = DateTime.Now;

            TimeSpan segunduTotalak = itzaliordua - orain;
            totalSegunduak = segunduTotalak.TotalSeconds;
            
            lblInfo.Text = itzaliordua.ToString();
        }

        private void cmdOnartu_Click(object sender, EventArgs e)
        {
            burutuAgindua();
            string flag;
            if (optItzali.Checked )
            {
                flag = "/s";
            } 
            else if ( optBerrabiarazi.Checked )
            {
                flag = "/r";
            }
            else
            {
                flag = "/l";
            }
                        
            DateTime orain = DateTime.Now;

            TimeSpan segunduTotalak = itzaliordua - orain;

            if (Math.Round(segunduTotalak.TotalSeconds) > 0)
            {
                string strSeconds = Math.Round(segunduTotalak.TotalSeconds).ToString();
                string arg = flag + " /f /t " + strSeconds;

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "shutdown";
                startInfo.Arguments = arg;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(startInfo);

                notifyIcon1.BalloonTipText = itzaliordua.ToString();
                notifyIcon1.BalloonTipTitle = "Itzalizak!";
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("Shutdown time must be in the future!");
                return;
            }
        }

        private void chkAukerak_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.prueba = "Es una prueba";
            if ( chkAukerak.Checked == true )
            {
                frmItzalizak1.ActiveForm.Height = 480;
                SetchkAukerak = true;
                Properties.Settings.Default.chkAukerak = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                frmItzalizak1.ActiveForm.Height = 230;
                SetchkAukerak = false;
                Properties.Settings.Default.chkAukerak = SetchkAukerak;
                Properties.Settings.Default.Save();                
            }
        }

        private void frmItzalizak1_Load(object sender, EventArgs e)
        {
            SetchkAukerak = Properties.Settings.Default.chkAukerak;
            notifyIcon1.BalloonTipText = itzaliordua.ToString();
            notifyIcon1.BalloonTipTitle = "Itzalizak!";
        }

        private void frmItzalizak1_Shown(Object sender, EventArgs e)
        {
            if (SetchkAukerak == true)
            {
                chkAukerak.Checked = true;
                frmItzalizak1.ActiveForm.Height = 480;
            }
            else
            {
                chkAukerak.Checked = false;
                frmItzalizak1.ActiveForm.Height = 230;
            }
        }

        private void frmItzalizak1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
