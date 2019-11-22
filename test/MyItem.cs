using System;
using System.Windows.Forms;

namespace test
{
    [Serializable]
    public class MyItem
    {
        public MyItem()
        {
            itemName = "This is a Custom Item";
        }

        public string ItemName
        {
            get { return itemName; }
        }

        private string itemName;

        public void CopyToClipboard()
        {
            DataFormats.Format format = DataFormats.GetFormat(typeof(MyItem).FullName);
            IDataObject dataObj = new DataObject();
            dataObj.SetData(format.Name, false, this);
            Clipboard.SetDataObject(dataObj, false);
        }
    }
}