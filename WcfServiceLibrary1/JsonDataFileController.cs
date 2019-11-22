using System;
using System.IO;
using System.Text;

namespace WcfServiceLibrary1
{
    public class JsonDataFileController
    {
        public bool IsFileExist(string value)
        {
            //该类用于读取指定配置文件中写入的“共享路径”
            DataFileFoldConfig config = DataFileFoldConfig.Load();
            return (File.Exists(config.BaseFold + "/" + value));
        }

        public bool ReadFileValue(string value)
        {
            bool result = false;
            try
            {
                DataFileFoldConfig config = DataFileFoldConfig.Load();
                string FileName = config.BaseFold + "/" + value;
                using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
                {
                    using (StreamReader sw = new StreamReader(fs, Encoding.UTF8))
                    {
                        Result = sw.ReadToEnd();
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadFileValue {0} ", ex.Message);
            }
            return result;
        }

        public string DisplayError_FileNotExsit(string value)
        {
            DataFileFoldConfig config = DataFileFoldConfig.Load();
            string FileName = config.BaseFold + "/" + value;
            return string.Format("文件{0}不存在", FileName);
        }

        public string DisplayError_FileReadError(string value)
        {
            DataFileFoldConfig config = DataFileFoldConfig.Load();
            string FileName = config.BaseFold + "/" + value;
            return string.Format("文件{0} 读取错误", FileName);
        }

        public string Result { get; set; }

        public void Release()
        {
            Result = "";
        }
    }
}