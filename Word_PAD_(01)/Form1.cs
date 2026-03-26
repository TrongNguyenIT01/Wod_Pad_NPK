using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Word_PAD__01_
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void XuLyOpenClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text files |*txt | My Word| *rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
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

            currentFilePath = ofd.FileName;


        }


        private void XuLySaveAs(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                currentFilePath = sfd.FileName;

                var ext = System.IO.Path.GetExtension(currentFilePath).ToLower();
                if (ext == ".txt")
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                else if (ext == ".rtf")
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
        }
        private void XuLySave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(currentFilePath))
            {
                XuLySaveAs(sender, e); // Gọi hàm Save As ở trên
            }
            else
            {

                var ext = System.IO.Path.GetExtension(currentFilePath).ToLower();
                if (ext == ".txt")
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                else if (ext == ".rtf")
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
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
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }


        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void XuLyUndo(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void XuLyRedo(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }


        private void DoiMauNen(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = richTextBox1.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void XuLyNew(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn lưu file hiện tại không?",
                    "Thông báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    XuLySave(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }

            richTextBox1.Clear();
            currentFilePath = string.Empty;
        }

        private void XuLyChenAnh(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(ofd.FileName);
                        Clipboard.SetImage(img);
                        richTextBox1.Paste();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể chèn ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void XuLyBullet(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void Inf(object sender, EventArgs e)
        {
            frmIF fif = new frmIF();
            fif.ShowDialog();
        }

        private void thutle5pts_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionIndent == 5)
            {
                richTextBox1.SelectionIndent = 0; // thụt lề 20 pixels
            }
            else
            {
                richTextBox1.SelectionIndent = 5; // bỏ thụt lề
            }
        }

        private void thutle10pts_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionIndent == 10)
            {
                richTextBox1.SelectionIndent = 0; // thụt lề 20 pixels
            }
            else
            {
                richTextBox1.SelectionIndent = 10; // bỏ thụt lề
            }
        }

        private void thutle15pts_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionIndent == 15)
            {
                richTextBox1.SelectionIndent = 0; // thụt lề 20 pixels
            }
            else
            {
                richTextBox1.SelectionIndent = 15; // bỏ thụt lề
            }
        }

        private void thutle20pts_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionIndent == 20)
            {
                richTextBox1.SelectionIndent = 0; // thụt lề 20 pixels
            }
            else
            {
                richTextBox1.SelectionIndent = 20; // bỏ thụt lề
            }
        }

        private void nonethutle_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 0; // bỏ thụt lề
        }

        private void selectall_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.5f)
            {
                richTextBox1.ZoomFactor -= 0.2f;
            }
        }

        private void btnzoomin_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 64.0f)
            {
                richTextBox1.ZoomFactor += 0.2f;
            }
        }

        private void TimKiem_click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập từ khóa tìm kiếm
            // tìm kiếm tất cả các vị trí của từ khóa trong văn bản và đánh dấu chúng bằng cách thay đổi màu nền của chúng tạm thời
            string keyword = Interaction.InputBox("Nhập từ khóa tìm kiếm:", "Tìm kiếm", "");
            if (keyword != null)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = richTextBox1.BackColor; // Hoặc Color.White
                richTextBox1.DeselectAll();
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    int index = richTextBox1.Find(keyword, startIndex, RichTextBoxFinds.None);
                    if (index != -1)
                    {
                        richTextBox1.Select(index, keyword.Length);
                        if (richTextBox1.SelectionBackColor == Color.Yellow)
                        {
                            richTextBox1.SelectionBackColor = Color.Green; // Hoặc Color.White
                        }
                        else 
                        { 
                            richTextBox1.SelectionBackColor = Color.Yellow; // Đánh dấu bằng màu vàng
                        }
                        startIndex = index + keyword.Length; // Tiếp tục tìm kiếm từ vị trí sau từ khóa vừa tìm
                    }
                    else
                    {
                        break; // Không tìm thấy nữa, thoát vòng lặp
                    }
                }
            }
        }

        private void replace_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập từ khóa tìm kiếm và từ khóa thay thế
            string keyword = Interaction.InputBox("Nhập từ khóa tìm kiếm:", "Thay thế", "");
            if (keyword != null)
            {
                string replacement = Interaction.InputBox("Nhập từ khóa thay thế:", "Thay thế", "");
                if (replacement != null)
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(keyword, replacement);
                }
            }
        }
    }
}
