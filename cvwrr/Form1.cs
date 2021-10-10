using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace cvwrr
{

    public partial class cvwrrForm : Form
    {
        public cvwrrForm()
        {
            InitializeComponent();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSrc.Text))            
                return;            


            string from = mtxtFrom.MaskedTextProvider.ToDisplayString();
            string to = mtxtTo.MaskedTextProvider.ToDisplayString();

            if (to == "00:00:00")                            
                return;            

            if (DateTime.Compare(DateTime.ParseExact(from, "HH:mm:ss", null), DateTime.ParseExact(to, "HH:mm:ss", null)) >= 0)
                return;


            boxJobs.Items.Add(new Job(from, to, txtSrc.Text, txtDest.Text));

            mtxtFrom.Clear();
            mtxtTo.Clear();
            txtSrc.Clear();
            txtDest.Text = "out.mp4";

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (btnAddJob.Enabled)
            {
                btnAddJob.Enabled = false;
                btnStartStop.Text = "Stop";
                if (jobWorker.IsBusy != true)
                    jobWorker.RunWorkerAsync();
                else
                    btnAddJob.Enabled = true;
            }
            else
            {
                btnAddJob.Enabled = true;
                btnStartStop.Text = "Start";
            }



        }

        private void setJobState(bool state)
        {

        }

        private void jobWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            List<Task> taskList = new List<Task>();


            foreach (Job j in boxJobs.Items)
            {
                Task task = Task.Factory.StartNew(() => CVWRRTask(j));
                taskList.Add(task);
            }
            Task.WaitAll(taskList.ToArray());
            

        }
        private int CVWRRTask(Job j)
        {
            Console.WriteLine("run job" + j);
            var sb = new StringBuilder();

            Process p = new Process();

            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "ffmpeg.exe";
            p.StartInfo.Arguments = "-y -i \"" + j.srcPath + "\" -ss " + j.from + " -to " + j.to + " -c copy " + j.destPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;


            p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.ErrorDataReceived += (sender, args) => sb.AppendLine(args.Data);


            try
            {
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
                Console.WriteLine(sb);
                jobWorker.ReportProgress(0, new JobFinished(JOB_STATUS.SUCCESS, j));

                if (sb.ToString().Contains("No such file or directory"))
                {
                    throw new Exception("No such file or directory: " + j.srcPath);
                }

                Console.WriteLine("success");
                return 0;            
            }
            catch (Exception err)
            {
                jobWorker.ReportProgress(0, new JobFinished(JOB_STATUS.ERROR, err));            
                return -1;
            }
                                          
        }

        private void jobWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            JobFinished jF = (JobFinished)e.UserState;

            if (jF.status == JOB_STATUS.SUCCESS)
            {
                Job j = (Job)jF.data;
                Console.WriteLine("Progress: " + j);

                boxJobs.Items.Remove(j);
            }
            else if (jF.status == JOB_STATUS.ERROR)
            {
                Exception err = (Exception)jF.data;
                Console.WriteLine(err.ToString());
                txtErr.Text += err.Message + Environment.NewLine;
             }
            

        }

        private void jobWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnAddJob.Enabled = true;
            btnStartStop.Text = "Start";
        }

        private void txtSrc_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtSrc.Text = file.FileName;
            }
        }

        private void txtDest_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "mp4";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDest.Text = file.FileName;
            }
        }
    }
   
}


