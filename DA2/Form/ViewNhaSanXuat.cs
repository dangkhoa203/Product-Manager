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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DA2
{
    public partial class ViewNhaSanXuat : Form
    {
        private XuLyNhaSanXuat xuly;
        public ViewNhaSanXuat()
        {
            InitializeComponent();
            xuly = new XuLyNhaSanXuat();
            showds();
           
        }
        private void showds()
        {
            cleards();
            foreach(NhaSanXuat nsx in xuly.GetDS())
            {
                DGVNhasanxuat.Rows.Add(nsx.ID,nsx.Ten,nsx.SoDienThoai,nsx.Email,nsx.DiaChi);
            }
        }
        private void cleards()
        {
            DGVNhasanxuat.Rows.Clear();
            DGVNhasanxuat.Refresh();
        }
        private void Bthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text.Length == 0 || tten.Text.Length == 0 || tsdt.Text.Length == 0 || temail.Text.Length == 0 || tdiachi.Text.Length == 0)
                {
                    MessageBox.Show("Xin hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (xuly.Kiem_tra_trung(tID.Text) == true)
                {
                    MessageBox.Show("Đã có ID trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhaSanXuat nhaSanXuat = new NhaSanXuat(tID.Text, tten.Text, tsdt.Text, temail.Text, tdiachi.Text);
                xuly.Add(nhaSanXuat);
                showds();
                tID.Focus();
                tID.Clear();
                tten.Clear();
                tsdt.Clear();
                temail.Clear();
                tdiachi.Clear();
                tsearch.Clear();
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi Format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Bsave_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.Save(xuly.GetDS(), "../../database/NhaSanXuat.dat");
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa nhà sản xuất : "+ DGVNhasanxuat.SelectedRows[0].Cells[0].Value.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                xuly.Remove(xuly.Tim_theo_Id(DGVNhasanxuat.SelectedRows[0].Cells[0].Value.ToString()));
                showds();
            }
        }

        private void Bsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text.Length == 0 || tten.Text.Length == 0 || tsdt.Text.Length == 0 || temail.Text.Length == 0 || tdiachi.Text.Length == 0)
                {
                    MessageBox.Show("Xin hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (xuly.Kiem_tra_trung(tID.Text) == true && tID.Text != DGVNhasanxuat.SelectedRows[0].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Đã có ID trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhaSanXuat nhaSanXuat = new NhaSanXuat(tID.Text, tten.Text, tsdt.Text, temail.Text, tdiachi.Text);
                xuly.Update(nhaSanXuat, xuly.Tim_theo_Id(DGVNhasanxuat.SelectedRows[0].Cells[0].Value.ToString()));
                DataGridViewRow row = DGVNhasanxuat.SelectedRows[0];
                row.Cells[0].Value = tID.Text;
                row.Cells[1].Value = tten.Text;
                row.Cells[2].Value = tsdt.Text;
                row.Cells[3].Value = temail.Text;
                row.Cells[4].Value = tdiachi.Text;
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi Format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DGVNhasanxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVNhasanxuat.SelectedRows[0];
            tID.Text = row.Cells[0].Value.ToString();
            tten.Text = row.Cells[1].Value.ToString();
            tsdt.Text = row.Cells[2].Value.ToString();
            temail.Text = row.Cells[3].Value.ToString();
            tdiachi.Text = row.Cells[4].Value.ToString();
            tID.Focus();
        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            cleards();
            foreach (NhaSanXuat nsx in xuly.Duyet_theo_ten(tsearch.Text))
            {
                DGVNhasanxuat.Rows.Add(nsx.ID,nsx.Ten,nsx.SoDienThoai,nsx.Email,nsx.DiaChi);
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

        private void FrmNhaSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
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
            if (xuly.Kiem_tra_trung(tID.Text) == true)
            {
                if (tID.Text == DGVNhasanxuat.SelectedRows[0].Cells[0].Value.ToString())
                {
                    lw.Text = "(Không thể thêm bằng ID này)";
                }
                else
                    lw.Text = "(Không thể thêm hoặc sửa bằng ID này)";
            }
            else
                lw.Text = "";
        }

        private void tdiachi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Bthem_Click(sender, e);
            }
        }
    }
}
