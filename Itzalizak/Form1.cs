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
    public partial class Form1 : Form
    {
        protected double segunduak;
        protected DateTime itzaliordua;

        public Form1()
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
            MessageBox.Show(segunduTotalak.Seconds.ToString());
            lblInfo.Text = itzaliordua.ToString();
        }

        private void cmdOnartu_Click(object sender, EventArgs e)
        {
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

            string arg = flag + " /f /t " + segunduak.ToString();
            MessageBox.Show(arg);
            System.Diagnostics.Process.Start("shutdown", arg);
            //System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");
        }
    }
}
