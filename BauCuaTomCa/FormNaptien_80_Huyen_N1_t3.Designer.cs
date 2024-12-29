namespace BauCuaTomCa
{
    partial class FormNaptien_80_Huyen_N1_t3
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
            lbNaptien_80_huyen_n1_t3 = new Label();
            lbChontien_80_huyen_N1_t3 = new Label();
            comboBox_chonTien_80_huyen_n1_t3 = new ComboBox();
            btnDongy_80_huyen_N1_T3 = new Button();
            SuspendLayout();
            // 
            // lbNaptien_80_huyen_n1_t3
            // 
            lbNaptien_80_huyen_n1_t3.AutoSize = true;
            lbNaptien_80_huyen_n1_t3.BackColor = SystemColors.ButtonHighlight;
            lbNaptien_80_huyen_n1_t3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbNaptien_80_huyen_n1_t3.Location = new Point(111, 61);
            lbNaptien_80_huyen_n1_t3.Name = "lbNaptien_80_huyen_n1_t3";
            lbNaptien_80_huyen_n1_t3.Size = new Size(177, 46);
            lbNaptien_80_huyen_n1_t3.TabIndex = 0;
            lbNaptien_80_huyen_n1_t3.Text = "NẠP TIỀN";
            lbNaptien_80_huyen_n1_t3.Click += lbNaptien_80_huyen_n1_t3_Click;
            // 
            // lbChontien_80_huyen_N1_t3
            // 
            lbChontien_80_huyen_N1_t3.AutoSize = true;
            lbChontien_80_huyen_N1_t3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbChontien_80_huyen_N1_t3.Location = new Point(32, 141);
            lbChontien_80_huyen_N1_t3.Name = "lbChontien_80_huyen_N1_t3";
            lbChontien_80_huyen_N1_t3.Size = new Size(135, 28);
            lbChontien_80_huyen_N1_t3.TabIndex = 2;
            lbChontien_80_huyen_N1_t3.Text = "Chọn số tiền:";
            lbChontien_80_huyen_N1_t3.Click += lbChontien_80_huyen_N1_t3_Click;
            // 
            // comboBox_chonTien_80_huyen_n1_t3
            // 
            comboBox_chonTien_80_huyen_n1_t3.BackColor = Color.Khaki;
            comboBox_chonTien_80_huyen_n1_t3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_chonTien_80_huyen_n1_t3.FormattingEnabled = true;
            comboBox_chonTien_80_huyen_n1_t3.Items.AddRange(new object[] { "10.000 VND", "20.000 VND", "50.000 VND", "100.000 VND", "200.000 VND", "500.000 VND", "1.000.000 VND", "" });
            comboBox_chonTien_80_huyen_n1_t3.Location = new Point(32, 173);
            comboBox_chonTien_80_huyen_n1_t3.Margin = new Padding(3, 4, 3, 4);
            comboBox_chonTien_80_huyen_n1_t3.Name = "comboBox_chonTien_80_huyen_n1_t3";
            comboBox_chonTien_80_huyen_n1_t3.Size = new Size(310, 28);
            comboBox_chonTien_80_huyen_n1_t3.TabIndex = 3;
            comboBox_chonTien_80_huyen_n1_t3.SelectedIndexChanged += comboBox_chonTien_80_huyen_n1_t3_SelectedIndexChanged;
            // 
            // btnDongy_80_huyen_N1_T3
            // 
            btnDongy_80_huyen_N1_T3.BackColor = Color.FromArgb(0, 192, 0);
            btnDongy_80_huyen_N1_T3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDongy_80_huyen_N1_T3.Location = new Point(111, 327);
            btnDongy_80_huyen_N1_T3.Margin = new Padding(3, 4, 3, 4);
            btnDongy_80_huyen_N1_T3.Name = "btnDongy_80_huyen_N1_T3";
            btnDongy_80_huyen_N1_T3.Size = new Size(161, 88);
            btnDongy_80_huyen_N1_T3.TabIndex = 4;
            btnDongy_80_huyen_N1_T3.Text = "ĐỒNG Ý";
            btnDongy_80_huyen_N1_T3.UseVisualStyleBackColor = false;
            btnDongy_80_huyen_N1_T3.Click += btnDongy_80_huyen_N1_T3_Click;
            // 
            // FormNaptien_80_Huyen_N1_t3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 491);
            Controls.Add(btnDongy_80_huyen_N1_T3);
            Controls.Add(comboBox_chonTien_80_huyen_n1_t3);
            Controls.Add(lbChontien_80_huyen_N1_t3);
            Controls.Add(lbNaptien_80_huyen_n1_t3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNaptien_80_Huyen_N1_t3";
            Text = "Nạp tiền";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNaptien_80_huyen_n1_t3;
        private Label lbChontien_80_huyen_N1_t3;
        private ComboBox comboBox_chonTien_80_huyen_n1_t3;
        private Button btnDongy_80_huyen_N1_T3;
    }
}