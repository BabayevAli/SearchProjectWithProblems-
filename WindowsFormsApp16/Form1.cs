using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            string[] arr = { "Ali", "Babayev", "17" };
            string[] arr1 = { "Azer", "Umudov", "19" };
            string[] arr2 = { "Qemer", "Sireliyev", "25" };
        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem a = new ListViewItem(arr);
            ListViewItem b = new ListViewItem(arr1);
            ListViewItem c = new ListViewItem(arr2);
            listView1.Items.Add(a);
            listView1.Items.Add(b);
            listView1.Items.Add(c);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            List<int> asdd = new List<int>();
            ListView cc = new ListView();
            if (text.Length != 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    #region ASS
                    //bool a = false;
                    //for (int k = 0; k < 3; k++)
                    //{
                    //    if (listView1.Items[i].SubItems[k].Text.Substring(0, text.Length) == text)
                    //    {
                    //        a = true;
                    //        break;
                    //    }
                    //}
                    //if (a == false)
                    //{
                    //    asdd.Add(i);
                    //}
                    #endregion
                    var a = listView1.FindItemWithText(text);
                    cc.Items.Add(listView1.Items[a.Index]);
                }
            }
            listView1.Items.Clear();
            for (int i = 0; i < cc.Items.Count; i++)
            {
                listView1.Items.Add(cc.Items[i]);
            }


            //List<ListViewItem> bbb = new List<ListViewItem>();
            //for (int i = 0; i < asdd.Count; i++)
            //{
            //    bbb.Add(listView1.Items[asdd[i]]);
            //}

            //for (int i = 0; i < bbb.Count; i++)
            //{
            //    listView1.Items.Remove(bbb[i]);
            //    MessageBox.Show(bbb[i].Text);
            //}

            if (text.Count() == 0)
            {
                listView1.Items.Clear();
                ListViewItem a = new ListViewItem(arr);
                ListViewItem b = new ListViewItem(arr1);
                ListViewItem c = new ListViewItem(arr2);
                listView1.Items.Add(a);
                listView1.Items.Add(b);
                listView1.Items.Add(c);
            }

        }
    }
}
