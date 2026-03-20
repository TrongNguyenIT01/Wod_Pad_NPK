using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_PAD__01_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XuLyOpenClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text files |*txt | My Word| *rtf";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var fileName = ofd.FileName;
                var ext = System.IO.Path.GetExtension(fileName);
                if (ext == ".txt")
                {
                    richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                }
                else if (ext == ".rtf")
                {
                    richTextBox1.LoadFile(fileName, RichTextBoxStreamType.RichText);
                }
            }


        }
    }
}
