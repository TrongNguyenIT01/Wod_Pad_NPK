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
    public partial class FindAndReplace : Form
    {
        public FindAndReplace()
        {
            InitializeComponent();
        }

        private RichTextBox _editor;
        private int _lastIndex = 0;

        public FindAndReplace(RichTextBox rtb)
        {
            InitializeComponent();
            _editor = rtb;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (string.IsNullOrEmpty(searchText)) return;

            // Tìm từ vị trí hiện tại
            int index = _editor.Find(searchText, _lastIndex, RichTextBoxFinds.None);

            if (index != -1)
            {
                _editor.Select(index, searchText.Length);
                _editor.Focus(); // Để người dùng thấy vùng bôi đen
                _lastIndex = index + searchText.Length;
            }
            else
            {
                MessageBox.Show("Đã tìm hết văn bản!", "Thông báo");
                _lastIndex = 0; // Reset về đầu
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (_editor.SelectedText.Trim().ToLower() == txtSearch.Text.Trim().ToLower())
            {
                // Thay thế vùng đang chọn bằng nội dung trong ô Thay thế
                _editor.SelectedText = txtThayThe.Text;
            }

            // Sau khi thay xong, tự động gọi nút Tìm để nhảy đến vị trí tiếp theo
            btnFind_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
