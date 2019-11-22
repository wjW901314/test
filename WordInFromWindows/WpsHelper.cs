using System;
using System.Windows.Forms;

namespace WordInFromWindows
{
    public class WpsHelper
    {
        #region 构造函数
        public WpsHelper()
        {
            //这里创建wps实例本机安装的是wps2016
            Type type = Type.GetTypeFromProgID("KWps.Application");
            dynamic wps = Activator.CreateInstance(type);
        }
        #endregion

        #region 在WPS2016中打开指定路径的文档
        /// <summary>
        /// 在WPS2016中打开指定路径的文档
        /// </summary>
        /// <param name="strFilePath">文件路径</param>
        public void OpenWpsFile(string strFilePath)
        {
            try
            {
                Word.Application wordApp = new Word.Application();//应用对象 
                wordApp.NormalTemplate.Saved = true;
                object fileName = strFilePath;
                object confirmConversions = Type.Missing;
                object readOnly = false;
                object addToRecentFiles = Type.Missing;
                object passwordDoc = Type.Missing;
                object passwordTemplate = Type.Missing;
                object revert = Type.Missing;
                object writepwdoc = Type.Missing;
                object writepwTemplate = Type.Missing;
                object format = Type.Missing;
                object encoding = Type.Missing;
                object visible = Type.Missing;
                object openRepair = Type.Missing;
                object docDirection = Type.Missing;
                object notEncoding = Type.Missing;
                object xmlTransform = Type.Missing;
                Word.Document doc = wordApp.Documents.Open(
                  ref fileName, ref confirmConversions, ref readOnly, ref addToRecentFiles,
                  ref passwordDoc, ref passwordTemplate, ref revert, ref writepwdoc,
                  ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,
                  ref docDirection, ref notEncoding, ref xmlTransform);

                wordApp.Visible = true;
                wordApp.Activate();//激活文档使文档为当前处理  
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开文件时出错：" + ex);
            }
        }
        #endregion
    }
}