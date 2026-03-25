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
    public partial class frmIF : Form
    {
        public frmIF()
        {
            InitializeComponent();
        }

        private void frmIF_Load(object sender, EventArgs e)
        {
            FillStudentInfo();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FillStudentInfo()
        {
            var allLabels = new List<Label> { label2, label3, label4, label6, label8 };
            foreach (var lbl in allLabels)
            {
                lbl.BackColor = Color.Transparent;
                lbl.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                lbl.ForeColor = Color.FromArgb(64, 64, 64);
            }
            label3.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }
    }
}
