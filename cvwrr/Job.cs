using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvwrr
{
    public enum JOB_STATUS { SUCCESS, ERROR };


    class Job
    {
        public Job(string from, string to, string srcPath, string destPath)
        {
            this.from = from;
            this.to = to;
            this.srcPath = srcPath;
            this.destPath = string.IsNullOrWhiteSpace(destPath) ? "out.mp4" : destPath;
            this.started = false;
            this.status = "";
        }


        public string from { get; set; }
        public string to { get; set; }
        public string srcPath { get;  set; }
        public string destPath { get; set; }
        public bool started { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return System.IO.Path.GetFileName(srcPath) + " [" + from + " - " + to + "]" + (status.Length > 0 ? " (" + status + ")" : "");
        }

    }

    class JobFinished
    {
        public JobFinished(JOB_STATUS status, Object data)
        {
            this.status = status;
            this.data = data;
        }
        public JOB_STATUS status { get; set; }
        public Object data { get; set; }
    }
}
