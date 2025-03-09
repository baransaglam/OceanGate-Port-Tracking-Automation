using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using BLL; 
namespace LogService
{
    public partial class Service1 : ServiceBase
    {
        private Timer _timer;
       private LogManager _logManager;  

        public Service1()
        {
            InitializeComponent();
            _logManager = new LogManager();  
        }

        protected override void OnStart(string[] args)
        {
            _timer = new Timer(5000);  
            _timer.Elapsed += new ElapsedEventHandler(TimerElapsed);
            _timer.Start();
            Console.WriteLine(LogManager.logFilePath);  

        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {           
            _logManager.LogAction("Service is running...", "ServiceLog");
            Console.WriteLine(LogManager.logFilePath);  
        }

        protected override void OnStop()
        {
            _timer.Stop();
        }
    }
}


