using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Itzalizak
{
    public partial class frmItzalizak1 : Form
    {
        private double segunduak;
        protected DateTime itzaliordua;

        public frmItzalizak1()
        {
            InitializeComponent();
        }

        private void cmdEzeztatu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
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
            segunduak = segunduTotalak.Seconds;
            
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

            string arg = flag + " /f /t " + segunduTotalak.Seconds.ToString();
            System.Diagnostics.Process.Start("shutdown", arg);
            
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                
                mynotifyicon.BalloonTipText = "My application still working...";
                mynotifyicon.BalloonTipTitle = "My Sample Application";
                mynotifyicon.BalloonTipIcon = ToolTipIcon.Info;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = false;
            }
        }

        private void chkAukerak_CheckedChanged(object sender, EventArgs e)
        {
            if ( chkAukerak.Checked )
            {
                frmItzalizak1.ActiveForm.Height = 480;
            }
            else
            {
                frmItzalizak1.ActiveForm.Height = 230;
            }
        }

        private void frmItzalizak1_Load(object sender, EventArgs e)
        {
            bool SetchkAukerak = Properties.Settings.Default.chkAukerak;
            if (SetchkAukerak)
            {
                chkAukerak.Checked = true;
            }
        }

        private void frmItzalizak1_Closing(object sender, EventArgs e)
        {
            bool SetchkAukerak = chkAukerak.Checked;
            Properties.Settings.Default.chkAukerak = SetchkAukerak;
            Properties.Settings.Default.Save();
        }
    }
}
