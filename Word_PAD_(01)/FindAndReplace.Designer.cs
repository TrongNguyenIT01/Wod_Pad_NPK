namespace Word_PAD__01_
{
    partial class FindAndReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThayThe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(167, 147);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Find";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThayThe
            // 
            this.btnThayThe.Location = new System.Drawing.Point(248, 147);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(75, 23);
            this.btnThayThe.TabIndex = 4;
            this.btnThayThe.Text = "Replace";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // txtThayThe
            // 
            this.txtThayThe.Location = new System.Drawing.Point(123, 69);
            this.txtThayThe.Name = "txtThayThe";
            this.txtThayThe.Size = new System.Drawing.Size(281, 22);
            this.txtThayThe.TabIndex = 6;
            // 
            // FindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 182);
            this.Controls.Add(this.txtThayThe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThayThe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FindAndReplace";
            this.Text = "FindAndReplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThayThe;
    }
}