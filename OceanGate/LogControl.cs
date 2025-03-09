using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class LogControl : UserControl
    {
        public LogControl()
        {
            InitializeComponent();
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
         
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {       
           LogManager log = new LogManager();
           dvLogs.DataSource = log.GetAllLogs();
            //_logManager.LogAction("Tüm Kullanıcılar Listelendi: ","Users");
        }
           
        

        private void SaveLogAction(string action)
        {
           
        }

       
    }
}
