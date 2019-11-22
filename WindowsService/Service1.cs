using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost host = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                host = new ServiceHost(typeof(WcfServiceLibrary1.WebService));
                if (host.State != CommunicationState.Opened)
                {
                    host.Open();
                }
            }
            catch (Exception e)
            {
                  Console.Write(e);
            }
        }

        protected override void OnStop()
        {
            host?.Close();
        }
    }
}
