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

        private void XuLySave(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text files |*txt | My Word| *rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fileName = sfd.FileName;
                var ext = System.IO.Path.GetExtension(fileName);
                if (ext == ".txt")
                {
                    richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                }
                else if (ext == ".rtf")
                {
                    richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void selectFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var font = new FontDialog();
            font.ShowColor = true;
            font.ShowApply = true;
            font.Apply += new EventHandler(XuLyApplyFont);
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
                richTextBox1.SelectionColor = font.Color;
            }
        }

        private void XuLyApplyFont(object sender, EventArgs e)
        {
            var font = sender as FontDialog;
            richTextBox1.SelectionFont = font.Font;
            richTextBox1.SelectionColor = font.Color;
        }

        private void frontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var font = new ColorDialog();
            font.Color = richTextBox1.SelectionColor;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = font.Color;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newFontStyle;
            if (currentFont.Bold)
            {
                newFontStyle = currentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Bold;
            }
            richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newFontStyle;
            if (currentFont.Italic)
            {
                newFontStyle = currentFont.Style & ~FontStyle.Italic;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newFontStyle;
            if (currentFont.Underline) 
            {
                newFontStyle = currentFont.Style & ~FontStyle.Underline;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newFontStyle = currentFont.Style & ~(FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Right)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Left)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
    }
}
