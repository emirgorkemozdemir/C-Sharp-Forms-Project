using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace RSS_APP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.cnnturk.com/feed/rss/all/news");

            while (xmloku.Read())
            {
                if (xmloku.Name=="description")
                {
                    lbox.Items.Add(xmloku.ReadString());
                }
            }

        }
    }
}
