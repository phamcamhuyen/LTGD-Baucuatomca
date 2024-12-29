using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BauCuaTomCa
{
    public partial class FormNaptien_80_Huyen_N1_t3 : Form
    {
        public FormNaptien_80_Huyen_N1_t3()
        {
            InitializeComponent();
        }
        private void lbChontien_80_huyen_N1_t3_Click(object sender, EventArgs e)
        {

        }
        string a;
        private void btnDongy_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {
            if (comboBox_chonTien_80_huyen_n1_t3.Text == "" || comboBox_chonTien_80_huyen_n1_t3.Text == "")
                MessageBox.Show("Vui lòng không bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 0)
                    a = "10000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 1)
                    a = "20000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 2)
                    a = "50000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 3)
                    a = "100000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 4)
                    a = "200000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 5)
                    a = "500000";
                if (comboBox_chonTien_80_huyen_n1_t3.SelectedIndex == 6)
                    a = "1000000";
                this.Close();
            }
        }
        public int SoLuongTienNap()
        {
            return int.Parse(a);
        }
        private void comboBox_chonTien_80_huyen_n1_t3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbNaptien_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
    }
}
