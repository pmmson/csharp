using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Task4
{
    class WorkOut
    {
        string fileName;
        List<DataRun> listWorkOut;
        public string FileName
        {
            set { fileName = value; }
        }
        public WorkOut(string fileName)
        {
            this.fileName = fileName;
            listWorkOut = new List<DataRun>();
        }
        public WorkOut()
        {
            listWorkOut = new List<DataRun>();
        }
        public void Add(string d, double r, int t)
        {
            listWorkOut.Add(new DataRun(d, r, t));
        }
        public void Remove(int index)
        {
            if (listWorkOut != null && index < listWorkOut.Count && index >= 0)
            {
                listWorkOut.RemoveAt(index);
            }
        }
        public DataRun this[int index]
        {
            get { return listWorkOut[index]; }
        }
        public int Count
        {
            get { return listWorkOut.Count; }
        }
        public void Save()
        {
            XmlSerializer xFormat = new XmlSerializer(typeof(List<DataRun>));
            Stream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xFormat.Serialize(fileStream, listWorkOut);
            fileStream.Close();
        }
        public void Load()
        {
            XmlSerializer xFormat = new XmlSerializer(typeof(List<DataRun>));
            Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            listWorkOut = (List<DataRun>)xFormat.Deserialize(fileStream);
            fileStream.Close();
        }
        public void FillListView(ListBox list)
        {
            foreach (var val in listWorkOut)
            {
                list.Items.Add(val);
            }
        }
    }
}
