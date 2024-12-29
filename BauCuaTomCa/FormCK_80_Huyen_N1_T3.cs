using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BauCuaTomCa
{
    public partial class FormCK_80_Huyen_N1_T3 : Form
    {
        public FormCK_80_Huyen_N1_T3(int Hien_co)
        {
            InitializeComponent();
            hienco_80_huyen_N1_T3.Text = Hien_co.ToString();
        }
        private void lbHienco_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }
        private void hienco_80_huyen_N1_T3_TextChanged(object sender, EventArgs e)
        {

        }
        int a;
        bool success = true;
        private void btnRut_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_STK_80_huyen_N1_T3.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox_soTien_80_huyen_n1_t3.Text == "" || comboBox_soTien_80_huyen_n1_t3.Text == "")
                MessageBox.Show("Vui lòng không bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 0)
                    a = 10000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 1)
                    a = 20000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 2)
                    a = 50000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 3)
                    a = 100000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 4)
                    a = 200000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 5)
                    a = 500000;
                if (comboBox_soTien_80_huyen_n1_t3.SelectedIndex == 6)
                    a = 1000000;
                if (a > int.Parse(hienco_80_huyen_N1_T3.Text))
                {
                    MessageBox.Show("Không đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    success = false;
                }
                else
                {
                    MessageBox.Show("Bạn đã rút tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        public bool giaodichthanhcong()
        {
            return success;
        }
        public int sotienduocrut_80_huyen_n1_t3()
        {
            return a;
        }
        public int sotiendu_80_huyen_n1_t3()
        {
            return int.Parse(hienco_80_huyen_N1_T3.Text) - a;
        }
        private void textBox_STK_80_huyen_N1_T3_TextChanged(object sender, EventArgs e)
        {

        }       
        private void comboBox_soTien_80_huyen_n1_t3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lb1_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }
        private void lb2_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }
        private void lb3_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_STK_80_huyen_N1_T3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
