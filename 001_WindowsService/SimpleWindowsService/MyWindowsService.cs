using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWindowsService
{
    public partial class MyWindowsService : ServiceBase
    {
        public MyWindowsService()
        {
            InitializeComponent();
            this.ServiceName = "MyWindowsService";
            this.EventLog.Source = "MyWindowsService";
            this.EventLog.Log = "Application";

            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.CanStop = true;

            if (!EventLog.SourceExists("MyWindowsService"))
                EventLog.CreateEventSource("MyWindowsService", "Application");
        }

        protected override void OnStart(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\WS.txt", false);
            sw.WriteLine("Hello world");
            sw.Flush();
            sw.Close();
        }

        protected override void OnStop()
        {
            //do some action 
        }
    }
}
