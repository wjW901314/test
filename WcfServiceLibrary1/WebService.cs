﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class WebService : IWebService
    {
        public string GetData()
        {
            return string.Format("Hell world!");
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public ResultEntry ReadFile(string value)
        {
            throw new NotImplementedException();
        }

        public ResultEntry ConnectTest()
        {
            ResultEntry result = ResultEntry.CreateSuccessEntry("this is test");
            return result;
        }
    }
}
