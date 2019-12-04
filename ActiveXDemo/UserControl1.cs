using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActiveXDemo
{
    [Guid("AC4E04EF-EA02-4EE7-AC26-08A7F465E116")]
    public partial class UserControl1: UserControl,IObjectSafety
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void GetInterfaceSafetyOptions(int riid, out int pdwSupportedOptions, out int pdwEnabledOptions)
        {
            pdwSupportedOptions = 1;
            pdwEnabledOptions = 2;
        }

        public void SetInterfaceSafetyOptions(int riid, int dwOptionSetMask, int dwEnabledOptions)
        {
           
        }
    }
}
