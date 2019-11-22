using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel;
using System.Web;
using WcfServiceLibrary1;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WebService)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("服务已经启动,输入exit退出...");
                    while (true)
                    {
                        string temp = Console.ReadLine();
                        if (temp != null && temp.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                        {
                            break;
                        }
                    }

                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("服务启动异常{0},输入exit退出...", ex.Message);
                }
            }
        }
    }
}
