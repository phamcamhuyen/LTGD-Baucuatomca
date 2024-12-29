using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace BauCuaTomCa
{
    public partial class FormBCTC_80_huyen_n1_t3 : Form
    {
        public FormBCTC_80_huyen_n1_t3()
        {
            InitializeComponent();
            btnSpin_80_huyen_n1_t3.Enabled = false;
        }
        int demsolanchoi_80_huyen_n1_t3 = 0;
        private void pictureBox_80_Huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }
        private void btnNaptien_80_huyen_N1_T3_Click_1(object sender, EventArgs e)
        {
            FormNaptien_80_Huyen_N1_t3 f1 = new FormNaptien_80_Huyen_N1_t3();
            f1.ShowDialog();
            int tien_hien_tai_80_huyen_n1_t3 = int.Parse(Textbox_TienHienTai_80_huyen_n1_t3.Text);
            int tien_nap_80_huyen_n1_t3 = f1.SoLuongTienNap();
            Textbox_TienHienTai_80_huyen_n1_t3.Text = (tien_hien_tai_80_huyen_n1_t3 + tien_nap_80_huyen_n1_t3).ToString();
            listBox_Lichsu_80_huyen_n1_t3.Items.Add(DateTime.Now.ToString() + "  | Nạp: " + string.Format("{0:N0}", f1.SoLuongTienNap()));
            btnSpin_80_huyen_n1_t3.Enabled = true;
            if (tien_hien_tai_80_huyen_n1_t3 >= 0)
                btnSpin_80_huyen_n1_t3.Enabled = true;
            else
            {
                btnSpin_80_huyen_n1_t3.Enabled = false;
            }
        }
        private void comboboxChon_80_huyen_N1_T3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbTiencuoc_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
        private void combobox_tienCuoc_80_huyen_n1_t3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAllin_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {
            combobox_tienCuoc_80_huyen_n1_t3.Text = Textbox_TienHienTai_80_huyen_n1_t3.Text;
        }

        private void lbLichsu_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Ketqua_80_huyen_n1_T3_Enter(object sender, EventArgs e)
        {

        }
        private void lbTienhientai_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
        private void listBox_Lichsu_80_huyen_n1_t3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSpin_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {
            pictureBox1_80_huyen_n1_t3.Visible = true;
            pictureBox2_80_huyen_n1_T3.Visible = true;
            pictureBox3_80_huyen_n1_t3.Visible = true;
            demsolanchoi_80_huyen_n1_t3++;
            lb7_80_huyen_N1_t3.Text = demsolanchoi_80_huyen_n1_t3.ToString();
            int tiencuoc_80_huyen_n1_t3 = 0;
            int tong_80_huyen_n1_t3 = 0;
            tong_80_huyen_n1_t3 = int.Parse(Textbox_TienHienTai_80_huyen_n1_t3.Text);
            lbTienhientai_80_huyen_n1_t3.Show();
            int count = 0;
            // kiểm tra chọn vật
            if (comboboxChon_80_huyen_N1_T3.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn vui lòng chọn con vật để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboboxChon_80_huyen_N1_T3.SelectedIndex = 0;
                return;
            }
            //kiểm tra tiền cược
            if (combobox_tienCuoc_80_huyen_n1_t3.Text == "")
            {
                MessageBox.Show("Mời bạn vui lòng đặt tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combobox_tienCuoc_80_huyen_n1_t3.Focus();
                return;
            }
            tiencuoc_80_huyen_n1_t3 = int.Parse(combobox_tienCuoc_80_huyen_n1_t3.Text);
            int tienhientai_80_huyen_n1_t3 = int.Parse(Textbox_TienHienTai_80_huyen_n1_t3.Text);
            //kiểm tra số tiền  
            if (tienhientai_80_huyen_n1_t3 <= 0)
            {
                MessageBox.Show("Bạn đã hết tiền, vui lòng nạp thêm tiền để tiếp tục chơi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSpin_80_huyen_n1_t3.Enabled = false;
                Textbox_TienHienTai_80_huyen_n1_t3.Text = "0";
                tienhientai_80_huyen_n1_t3 = 0;
                return;
            }
            Random r_80_huyen_n1_t3 = new Random();
            Random r1_80_huyen_n1_t3 = new Random();
            Random r2_80_huyen_n1_t3 = new Random();
            var tieude = new List<string> {
                // cac duong dan tuyet doi toi cac tep hinh anh trong thu muc "Resources" trong du an BCTC
              @"D:\80_Huyen_N1_T3_BauCuaTomCa\BauCuaTomCa\Resources\bau.png",
              @"D:\80_Huyen_N1_T3_BauCuaTomCa\BauCuaTomCa\Resources\cua.png",
              @"D:\\80_Huyen_N1_T3_BauCuaTomCa\\BauCuaTomCa\\Resources\\tom.png",
              @"D:\80_Huyen_N1_T3_BauCuaTomCa\BauCuaTomCa\Resources\ca.png",
              @"D:\80_Huyen_N1_T3_BauCuaTomCa\BauCuaTomCa\Resources\ga.png",
              @"D:\80_Huyen_N1_T3_BauCuaTomCa\BauCuaTomCa\Resources\huou.png"
            };
            int i_tieude_80_huyen_n1_t3 = r_80_huyen_n1_t3.Next(tieude.Count);
            int i_tieude1_80_huyen_n1_t3 = r1_80_huyen_n1_t3.Next(tieude.Count);
            int i_tieude2_80_huyen_n1_t3 = r2_80_huyen_n1_t3.Next(tieude.Count);
            pictureBox1_80_huyen_n1_t3.ImageLocation = tieude[i_tieude_80_huyen_n1_t3];
            pictureBox2_80_huyen_n1_T3.ImageLocation = tieude[i_tieude1_80_huyen_n1_t3];
            pictureBox3_80_huyen_n1_t3.ImageLocation = tieude[i_tieude2_80_huyen_n1_t3];
            for (int i = 0; i < 6; i++)
            {
                if (comboboxChon_80_huyen_N1_T3.SelectedIndex == i)
                {
                    if (pictureBox1_80_huyen_n1_t3.ImageLocation == tieude[i])
                        count++;
                    if (pictureBox2_80_huyen_n1_T3.ImageLocation == tieude[i])
                        count++;
                    if (pictureBox3_80_huyen_n1_t3.ImageLocation == tieude[i])
                        count++;
                    if (count == 0)
                    {
                        if (tienhientai_80_huyen_n1_t3 <= 0)
                        {
                            Textbox_TienHienTai_80_huyen_n1_t3.Text = "0";
                            lbTienhientai_80_huyen_n1_t3.Text = "0";
                        }
                        else
                        {
                            Textbox_TienHienTai_80_huyen_n1_t3.Text = (tong_80_huyen_n1_t3 - tiencuoc_80_huyen_n1_t3).ToString();
                            lbTienhientai_80_huyen_n1_t3.Text = (count - tiencuoc_80_huyen_n1_t3).ToString();
                        }
                    }
                    else
                    {
                        Textbox_TienHienTai_80_huyen_n1_t3.Text = (tong_80_huyen_n1_t3 + tiencuoc_80_huyen_n1_t3 * count).ToString();
                        lbTienhientai_80_huyen_n1_t3.Text = "+" + (tiencuoc_80_huyen_n1_t3 * count).ToString();
                    }
                }
            }
            lbLichsu_80_huyen_n1_t3.Show();
            listBox_Lichsu_80_huyen_n1_t3.Items.Add(DateTime.Now.ToString() + "  | " + lbTienhientai_80_huyen_n1_t3.Text + " [" + comboboxChon_80_huyen_N1_T3.Text + "]  ×" + count);
        }
        private void lb7_80_huyen_N1_t3_Click(object sender, EventArgs e)
        {

        }
        private void btnRuttien_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {
            FormCK_80_Huyen_N1_T3 f1 = new FormCK_80_Huyen_N1_T3(int.Parse(Textbox_TienHienTai_80_huyen_n1_t3.Text));
            f1.ShowDialog();
            if (f1.giaodichthanhcong())
            {
                Textbox_TienHienTai_80_huyen_n1_t3.Text = f1.sotiendu_80_huyen_n1_t3().ToString();
                listBox_Lichsu_80_huyen_n1_t3.Items.Add(DateTime.Now.ToString() + "  | Rút: " + string.Format("{0:N0}", f1.sotienduocrut_80_huyen_n1_t3()));
                return;
            }
           
        }
        private void Textbox_TienHienTai_80_huyen_n1_t3_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbKetqua_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_80_huyen_n1_t3_Click(object sender, EventArgs e)
        {

        }
        private void lbSolanchoi_80_huyen_N1_T3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
    

