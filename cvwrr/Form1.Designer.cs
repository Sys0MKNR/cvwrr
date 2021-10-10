namespace cvwrr
{
    partial class cvwrrForm
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
            this.mtxtFrom = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            this.boxJobs = new System.Windows.Forms.ListBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.jobWorker = new System.ComponentModel.BackgroundWorker();
            this.txtErr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtFrom
            // 
            this.mtxtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.mtxtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFrom.ForeColor = System.Drawing.Color.White;
            this.mtxtFrom.Location = new System.Drawing.Point(64, 40);
            this.mtxtFrom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtxtFrom.Mask = "00:00:00";
            this.mtxtFrom.Name = "mtxtFrom";
            this.mtxtFrom.PromptChar = '0';
            this.mtxtFrom.Size = new System.Drawing.Size(87, 27);
            this.mtxtFrom.TabIndex = 0;
            this.mtxtFrom.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSrc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtTo);
            this.groupBox1.Controls.Add(this.mtxtFrom);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination";
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDest.ForeColor = System.Drawing.Color.White;
            this.txtDest.Location = new System.Drawing.Point(6, 205);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(277, 27);
            this.txtDest.TabIndex = 5;
            this.txtDest.Text = "out.mp4";
            this.txtDest.DoubleClick += new System.EventHandler(this.txtDest_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source";
            // 
            // txtSrc
            // 
            this.txtSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrc.ForeColor = System.Drawing.Color.White;
            this.txtSrc.Location = new System.Drawing.Point(6, 126);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(277, 27);
            this.txtSrc.TabIndex = 2;
            this.txtSrc.DoubleClick += new System.EventHandler(this.txtSrc_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // mtxtTo
            // 
            this.mtxtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.mtxtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTo.ForeColor = System.Drawing.Color.White;
            this.mtxtTo.Location = new System.Drawing.Point(211, 40);
            this.mtxtTo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtxtTo.Mask = "00:00:00";
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.PromptChar = '0';
            this.mtxtTo.Size = new System.Drawing.Size(87, 27);
            this.mtxtTo.TabIndex = 1;
            this.mtxtTo.ValidatingType = typeof(System.DateTime);
            // 
            // boxJobs
            // 
            this.boxJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.boxJobs.ForeColor = System.Drawing.Color.White;
            this.boxJobs.FormattingEnabled = true;
            this.boxJobs.HorizontalScrollbar = true;
            this.boxJobs.ItemHeight = 19;
            this.boxJobs.Location = new System.Drawing.Point(324, 22);
            this.boxJobs.Name = "boxJobs";
            this.boxJobs.Size = new System.Drawing.Size(432, 270);
            this.boxJobs.TabIndex = 2;
            // 
            // btnAddJob
            // 
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Location = new System.Drawing.Point(12, 324);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(89, 35);
            this.btnAddJob.TabIndex = 3;
            this.btnAddJob.Text = "Add";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Location = new System.Drawing.Point(324, 324);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(89, 35);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // jobWorker
            // 
            this.jobWorker.WorkerReportsProgress = true;
            this.jobWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.jobWorker_DoWork);
            this.jobWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.jobWorker_ProgressChanged);
            this.jobWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.jobWorker_RunWorkerCompleted);
            // 
            // txtErr
            // 
            this.txtErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.txtErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErr.ForeColor = System.Drawing.Color.White;
            this.txtErr.Location = new System.Drawing.Point(432, 324);
            this.txtErr.Multiline = true;
            this.txtErr.Name = "txtErr";
            this.txtErr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErr.Size = new System.Drawing.Size(324, 35);
            this.txtErr.TabIndex = 7;
            // 
            // cvwrrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(768, 371);
            this.Controls.Add(this.txtErr);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.boxJobs);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "cvwrrForm";
            this.ShowIcon = false;
            this.Text = "cvwrr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.ListBox boxJobs;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnStartStop;
        private System.ComponentModel.BackgroundWorker jobWorker;
        private System.Windows.Forms.TextBox txtErr;
    }
}

