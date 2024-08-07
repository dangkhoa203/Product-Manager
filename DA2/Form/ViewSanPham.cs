using DA2.Database;
using DA2.Model;
using DA2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DA2
{
    public partial class ViewSanPham : Form
    {
        XuLySanPham xulySanPham;
        XuLyNhaSanXuat xulyNhaSanXuat;
        public ViewSanPham()
        {
            InitializeComponent();
            xulySanPham = new XuLySanPham();
            xulyNhaSanXuat=new XuLyNhaSanXuat();
            hienthicombobox(comboBox1, xulyNhaSanXuat.GetDS());
            showds();
        }
        private void showds()
        {
            cleards();
            foreach (SanPham sp in xulySanPham.GetDS())
            {
                DGVSanPham.Rows.Add(sp.ID, sp.Ten, sp.Gia, sp.Soluong, sp.HSD, sp.NhaSanXuat.ID);
            }
        }
        private void cleards()
        {
            DGVSanPham.Rows.Clear();
            DGVSanPham.Refresh();
        }
        private void loadcombobox()
        {
            foreach (NhaSanXuat nsx in xulyNhaSanXuat.GetDS())
            {
                comboBox1.Items.Add(nsx.ID);
            }
        }
        private void Bthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (xulySanPham.Kiem_tra_trung(tID.Text) == true)
                {
                    MessageBox.Show("Đã có ID trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tID.Text.Length == 0 || tten.Text.Length == 0 || tsl.Text.Length == 0 || tgia.Text.Length == 0)
                {
                    MessageBox.Show("Xin hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (float.Parse(tgia.Text) < 0 || float.Parse(tsl.Text) < 0)
                {

                    MessageBox.Show("Giá hoặc số lượng là âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhaSanXuat tem = new NhaSanXuat();
                tem.Ten = comboBox1.Text;
                tem.ID = comboBox1.SelectedValue.ToString();

                SanPham m = new SanPham(tID.Text, tten.Text, float.Parse(tgia.Text), int.Parse(tsl.Text), phsd.Value, tem);
                xulySanPham.Add(m);
                showds();
                tID.Focus();
                tID.Clear();
                tten.Clear();
                tgia.Clear();
                tsl.Clear();
                tsearch.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi Format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm : "+ DGVSanPham.SelectedRows[0].Cells[0].Value.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                xulySanPham.Remove(xulySanPham.Tim_theo_Id(DGVSanPham.SelectedRows[0].Cells[0].Value.ToString()));
                showds();
            }
        }

        private void Bsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text.Length == 0 || tten.Text.Length == 0 || tsl.Text.Length == 0 || tgia.Text.Length == 0)
                {
                    MessageBox.Show("Xin hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (xulySanPham.Kiem_tra_trung(tID.Text) == true && tID.Text != DGVSanPham.SelectedRows[0].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Đã có ID trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.Parse(tgia.Text) < 0 || float.Parse(tsl.Text) < 0)
                {

                    MessageBox.Show("Giá hoặc số lượng là âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhaSanXuat tem = new NhaSanXuat();
                tem.Ten = comboBox1.Text;
                tem.ID = comboBox1.SelectedValue.ToString();
                SanPham m = new SanPham(tID.Text, tten.Text, float.Parse(tgia.Text), int.Parse(tsl.Text), phsd.Value, tem);
                xulySanPham.Update(m, xulySanPham.Tim_theo_Id(DGVSanPham.SelectedRows[0].Cells[0].Value.ToString()));
                DataGridViewRow row = DGVSanPham.SelectedRows[0];
                row.Cells[0].Value = tID.Text;
                row.Cells[1].Value = tten.Text;
                row.Cells[2].Value = float.Parse(tgia.Text);
                row.Cells[3].Value = int.Parse(tsl.Text);
                row.Cells[4].Value = phsd.Value;
                row.Cells[5].Value = comboBox1.SelectedValue.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi Format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void hienthicombobox(ComboBox com, LinkedList<NhaSanXuat> ls)
        {
            com.DisplayMember = "Ten";
            com.ValueMember = "ID";
            com.DataSource = ls.ToList();
        }

        private void Bsave_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.Save(xulySanPham.GetDS(), "../../database/SanPham.dat");
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void DGVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVSanPham.SelectedRows[0];
            tID.Text = row.Cells[0].Value.ToString();
            tten.Text = row.Cells[1].Value.ToString();
            tgia.Text = row.Cells[2].Value.ToString();
            tsl.Text = row.Cells[3].Value.ToString();
            phsd.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            tID.Focus();
        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            cleards();
            foreach (SanPham sp in xulySanPham.Duyet_theo_ten(tsearch.Text))
            {
                DGVSanPham.Rows.Add(sp.ID, sp.Ten, sp.Gia, sp.Soluong, sp.HSD, sp.NhaSanXuat.ID);
            }
           
        }

        private void lthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát ra", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                lthoat_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Bsave_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                Bthem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                Bxoa_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                Bsua_Click(sender, e);
            }
        }

        private void tID_TextChanged(object sender, EventArgs e)
        {
            if (xulySanPham.Kiem_tra_trung(tID.Text) == true)
            {
                if (tID.Text == DGVSanPham.SelectedRows[0].Cells[0].Value.ToString())
                {
                    lw.Text = "(Không thể thêm bằng ID này)";
                }
                else
                    lw.Text = "(Không thể thêm hoặc sửa bằng ID này)";
            }
            else
                lw.Text = "";
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Bthem_Click(sender, e);
            }
        }
    }
    
}
