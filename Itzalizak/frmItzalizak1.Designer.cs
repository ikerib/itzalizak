namespace Itzalizak
{
    partial class frmItzalizak1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItzalizak1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblText1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optWindows = new System.Windows.Forms.GroupBox();
            this.optSaioaItxi = new System.Windows.Forms.RadioButton();
            this.optBerrabiarazi = new System.Windows.Forms.RadioButton();
            this.optItzali = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOnartu = new System.Windows.Forms.Button();
            this.cmdEzeztatu = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.chkAukerak = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.optWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 47);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(38, 31);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(209, 13);
            this.lblText1.TabIndex = 3;
            this.lblText1.Text = "Ordenagailua itzaltzeko programatua dago:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optWindows);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(41, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programatu ezazu noiz itzali nahi duzun";
            // 
            // optWindows
            // 
            this.optWindows.Controls.Add(this.optSaioaItxi);
            this.optWindows.Controls.Add(this.optBerrabiarazi);
            this.optWindows.Controls.Add(this.optItzali);
            this.optWindows.Location = new System.Drawing.Point(273, 106);
            this.optWindows.Name = "optWindows";
            this.optWindows.Size = new System.Drawing.Size(200, 100);
            this.optWindows.TabIndex = 5;
            this.optWindows.TabStop = false;
            this.optWindows.Text = "Opciones Windows";
            // 
            // optSaioaItxi
            // 
            this.optSaioaItxi.AutoSize = true;
            this.optSaioaItxi.Location = new System.Drawing.Point(6, 67);
            this.optSaioaItxi.Name = "optSaioaItxi";
            this.optSaioaItxi.Size = new System.Drawing.Size(67, 17);
            this.optSaioaItxi.TabIndex = 2;
            this.optSaioaItxi.Text = "Saioa itxi";
            this.optSaioaItxi.UseVisualStyleBackColor = true;
            // 
            // optBerrabiarazi
            // 
            this.optBerrabiarazi.AutoSize = true;
            this.optBerrabiarazi.Location = new System.Drawing.Point(7, 43);
            this.optBerrabiarazi.Name = "optBerrabiarazi";
            this.optBerrabiarazi.Size = new System.Drawing.Size(80, 17);
            this.optBerrabiarazi.TabIndex = 1;
            this.optBerrabiarazi.Text = "Berrabiarazi";
            this.optBerrabiarazi.UseVisualStyleBackColor = true;
            // 
            // optItzali
            // 
            this.optItzali.AutoSize = true;
            this.optItzali.Checked = true;
            this.optItzali.Location = new System.Drawing.Point(6, 19);
            this.optItzali.Name = "optItzali";
            this.optItzali.Size = new System.Drawing.Size(46, 17);
            this.optItzali.TabIndex = 0;
            this.optItzali.TabStop = true;
            this.optItzali.Text = "Itzali";
            this.optItzali.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // cmdOnartu
            // 
            this.cmdOnartu.Location = new System.Drawing.Point(502, 79);
            this.cmdOnartu.Name = "cmdOnartu";
            this.cmdOnartu.Size = new System.Drawing.Size(116, 24);
            this.cmdOnartu.TabIndex = 5;
            this.cmdOnartu.Text = "Onartu";
            this.cmdOnartu.UseVisualStyleBackColor = true;
            this.cmdOnartu.Click += new System.EventHandler(this.cmdOnartu_Click);
            // 
            // cmdEzeztatu
            // 
            this.cmdEzeztatu.Location = new System.Drawing.Point(502, 109);
            this.cmdEzeztatu.Name = "cmdEzeztatu";
            this.cmdEzeztatu.Size = new System.Drawing.Size(116, 25);
            this.cmdEzeztatu.TabIndex = 6;
            this.cmdEzeztatu.Text = "Ezeztatu";
            this.cmdEzeztatu.UseVisualStyleBackColor = true;
            this.cmdEzeztatu.Click += new System.EventHandler(this.cmdEzeztatu_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(33, 73);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 47);
            this.lblInfo.TabIndex = 7;
            // 
            // chkAukerak
            // 
            this.chkAukerak.AutoSize = true;
            this.chkAukerak.Checked = true;
            this.chkAukerak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAukerak.Location = new System.Drawing.Point(41, 164);
            this.chkAukerak.Name = "chkAukerak";
            this.chkAukerak.Size = new System.Drawing.Size(159, 17);
            this.chkAukerak.TabIndex = 8;
            this.chkAukerak.Text = "Erakutsi / Ezkutatu aukerak";
            this.chkAukerak.UseVisualStyleBackColor = true;
            this.chkAukerak.CheckedChanged += new System.EventHandler(this.chkAukerak_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmItzalizak1
            // 
            this.AcceptButton = this.cmdOnartu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdEzeztatu;
            this.ClientSize = new System.Drawing.Size(654, 442);
            this.Controls.Add(this.chkAukerak);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmdEzeztatu);
            this.Controls.Add(this.cmdOnartu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblText1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItzalizak1";
            this.Text = "itzalizak!";
            this.Load += new System.EventHandler(this.frmItzalizak1_Load);
            this.Shown += new System.EventHandler(this.frmItzalizak1_Shown);
            this.Resize += new System.EventHandler(this.frmItzalizak1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.optWindows.ResumeLayout(false);
            this.optWindows.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox optWindows;
        private System.Windows.Forms.RadioButton optSaioaItxi;
        private System.Windows.Forms.RadioButton optBerrabiarazi;
        private System.Windows.Forms.RadioButton optItzali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOnartu;
        private System.Windows.Forms.Button cmdEzeztatu;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkAukerak;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

