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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DA2
{
    public partial class ViewHoaDon : Form
    {
        XuLyHoaDon xulyhoadon;
        XuLySanPham xuLySanPham;
        SanPham sphientai=new SanPham();
        private bool dangtimngay = false;
        public ViewHoaDon()
        {
            InitializeComponent();
            xulyhoadon = new XuLyHoaDon();
            xuLySanPham=new XuLySanPham();
            showds();
            showdsHD();
            lid.Text = "HD" + (xulyhoadon.GetDS().Count()+1).ToString("000");
           
        }
        private void showds()
        {
            cleards();
            int count = 0;
            foreach (SanPham sp in xuLySanPham.GetDS())
            {
                DGVSanPham.Rows.Add(sp.ID, sp.Ten, sp.Gia, sp.Soluong, sp.HSD);
                if (sp.chkngaysd())
                {
                    DGVSanPham.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                    DGVSanPham.Rows[count].DefaultCellStyle.SelectionBackColor = Color.Red;
                }
                count++;
            }
        }
        private void showdsHD()
        {
            cleardsHD();
            foreach (Hoadon hd in xulyhoadon.GetDS())
            {
                DGVDSHoaDon.Rows.Add(hd.ID,hd.Ten,hd.NgayDat);
            }
            DGVDSSanPhamMua.Rows.Clear();
            DGVDSSanPhamMua.Refresh();
        }
        private void cleards()
        {
            DGVSanPham.Rows.Clear();
            DGVSanPham.Refresh();
        }
        private void cleardsHD()
        {
            DGVDSHoaDon.Rows.Clear();
            DGVDSHoaDon.Refresh();
        }
        private void bchon_Click(object sender, EventArgs e)
        {
            try
            {
                if (xuLySanPham.Tim_theo_Id(DGVSanPham.SelectedRows[0].Cells[0].Value.ToString()).Value.chkngaysd())
                {
                    MessageBox.Show("Sản phẩm đã hết hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(tsl.Text) <= sphientai.Soluong)
                {
                    float tong = 0;
                    if (DGVHoaDon.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow row in DGVHoaDon.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == sphientai.ID)
                            {
                                row.Cells[2].Value = int.Parse(tsl.Text) + int.Parse(row.Cells[2].Value.ToString());
                                sphientai.Soluong -= int.Parse(tsl.Text);
                                foreach (DataGridViewRow rows in DGVHoaDon.Rows)
                                {
                                    tong += float.Parse(rows.Cells[3].Value.ToString()) * int.Parse(rows.Cells[2].Value.ToString());
                                }
                                lgtm.Text = "Tổng giá trị hóa đơn : " + tong.ToString("0,00") + " VNĐ";
                                showds();
                                return;
                            }
                        }
                    }
                    DGVHoaDon.Rows.Add(sphientai.ID, sphientai.Ten, tsl.Text, sphientai.Gia);
                    sphientai.Soluong -= int.Parse(tsl.Text);
                    foreach (DataGridViewRow row in DGVHoaDon.Rows)
                    {
                        tong += float.Parse(row.Cells[3].Value.ToString())* int.Parse(row.Cells[2].Value.ToString());
                    }
                    lgtm.Text = "Tổng giá trị hóa đơn : " + tong.ToString("0,00") + " VNĐ";
                    tsearchsp.Clear();
                    showds();
                    
                }
                else
                    MessageBox.Show("Không còn đủ số lượng của sản phẩm để lấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi Format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DGVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sphientai = xuLySanPham.Tim_theo_Id(DGVSanPham.SelectedRows[0].Cells[0].Value.ToString()).Value;
            lsp.Text ="Sản phẩm chọn: "+ sphientai.Ten;
            tsl.Text = "1";
            tsl.Focus();
        }

        private void bxoasp_Click(object sender, EventArgs e)
        {
            try
            {
                LinkedListNode<SanPham> f = xuLySanPham.Tim_theo_Id(DGVHoaDon.SelectedRows[0].Cells[0].Value.ToString());
                f.Value.Soluong += int.Parse(DGVHoaDon.SelectedRows[0].Cells[2].Value.ToString());
                DGVHoaDon.Rows.Remove(DGVHoaDon.SelectedRows[0]);

                
                if (DGVHoaDon.Rows.Count != 0)
                {
                    float tong = 0;
                    foreach (DataGridViewRow row in DGVHoaDon.Rows)
                    {
                        tong += float.Parse(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[2].Value.ToString());
                    }
                    lgtm.Text = "Tổng giá trị hóa đơn : " + tong.ToString("0,00") + " VNĐ";
                }
                else
                    lgtm.Text = "Tổng giá trị hóa đơn : " ;


                showds();
            }
            catch(Exception ex) { }
        }

        private void blaphoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (tten.Text.Length == 0)
                {
                    MessageBox.Show("Xin hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                if (DGVHoaDon.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    Hoadon tem = new Hoadon();
                foreach (DataGridViewRow row in DGVHoaDon.Rows)
                {
                    SanPham a = new SanPham();
                    a.ID = row.Cells[0].Value.ToString();
                    a.Ten = row.Cells[1].Value.ToString();
                    a.Soluong = int.Parse(row.Cells[2].Value.ToString());
                    a.Gia = float.Parse(row.Cells[3].Value.ToString());
                    tem.SanPhamMua.AddLast(a);
                }
                tem.ID = lid.Text;
                tem.Ten = tten.Text;
                xulyhoadon.Add(tem);
                TruyCapDuLieu.Save(xulyhoadon.GetDS(), "../../database/HoaDon.dat");
                TruyCapDuLieu.Save(xuLySanPham.GetDS(), "../../database/SanPham.dat");
                ltg.Text = "Tổng giá trị hóa đơn :";
                DGVHoaDon.Rows.Clear();
                DGVHoaDon.Refresh();
                lid.Text = "HD" + (xulyhoadon.GetDS().Count() + 1).ToString("000");
                lgtm.Text = "Tổng giá trị hóa đơn : ";
                tten.Clear();
                tten.Focus();
                bresetview_Click(sender, e);
                MessageBox.Show("Hóa đơn ID tạo ra : "+tem.ID, "Thông báo", MessageBoxButtons.OK);
            }
            catch(Exception ex) { }
        }

        private void DGVDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVDSSanPhamMua.Rows.Clear();
            DGVDSSanPhamMua.Refresh();
            LinkedListNode<Hoadon> tem = xulyhoadon.Tim_theo_Id(DGVDSHoaDon.SelectedRows[0].Cells[0].Value.ToString());
            foreach(SanPham sp in tem.Value.SanPhamMua)
            {
                DGVDSSanPhamMua.Rows.Add(sp.ID, sp.Ten, sp.Gia, sp.Soluong);
            }
            ltg.Text = "Tổng giá trị hóa đơn : " +tem.Value.TongGiatri.ToString("0,00")+" VNĐ";
        }
       
        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            cleardsHD();
            if (dangtimngay) { 
                foreach (Hoadon hd in xulyhoadon.Duyet_theo_khoang_thoi_gian(xulyhoadon.Duyet_theo_ten(tsearchhd.Text), dbatdau.Value, dketthuc.Value)) 
                {
                    DGVDSHoaDon.Rows.Add(hd.ID, hd.Ten, hd.NgayDat);
                }
            }
            else
            {
                foreach (Hoadon hd in xulyhoadon.Duyet_theo_ten(tsearchhd.Text))
                {
                    DGVDSHoaDon.Rows.Add(hd.ID, hd.Ten, hd.NgayDat);
                }
            }
        }
       
        private void tsearchin_TextChanged(object sender, EventArgs e)
        {
            cleards();
            int count = 0;
            foreach (SanPham sp in xuLySanPham.Duyet_theo_ten(tsearchsp.Text))
            {
                DGVSanPham.Rows.Add(sp.ID, sp.Ten, sp.Gia, sp.Soluong, sp.HSD);
                if (sp.chkngaysd())
                {
                    DGVSanPham.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                    DGVSanPham.Rows[count].DefaultCellStyle.SelectionBackColor = Color.Red;
                }
                count++;
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

        private void lthoat1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát ra", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                lthoat_Click(sender, e);
            }
            if (e.Alt)
            {
                if (quanlyhoadontab.SelectedTab == viewlaphd)
                    quanlyhoadontab.SelectedTab = viewdshoadon;
                else
                    quanlyhoadontab.SelectedTab = viewlaphd;
            }
            if(e.Control && e.KeyCode == Keys.R)
            {
                bresetview_Click(sender, e);    
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
               bxoasp_Click(sender, e);
            }
        }

        private void btimsesearch_Click(object sender, EventArgs e)
        {
            cleardsHD();
            dangtimngay = true;
            foreach (Hoadon hd in xulyhoadon.Duyet_theo_khoang_thoi_gian(dbatdau.Value,dketthuc.Value))
            {
                DGVDSHoaDon.Rows.Add(hd.ID, hd.Ten, hd.NgayDat);
            }
            tsearchhd.Clear();
        }

        private void bresetview_Click(object sender, EventArgs e)
        {
            dangtimngay = false;
            showdsHD();
            tsearchhd.Clear();
            dbatdau.Value = DateTime.Now;
            dketthuc.Value = DateTime.Now;
            ltg.Text = "Tổng giá trị hóa đơn:";
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa hết hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                xulyhoadon.clear();
                TruyCapDuLieu.Save(xulyhoadon.GetDS(), "../../database/HoaDon.dat");
                bresetview_Click(sender, e);
            }
        }

        private void dbatdau_ValueChanged(object sender, EventArgs e)
        {
            if(dketthuc.Value.Date<dbatdau.Value.Date)
            {
                dketthuc.Value=dbatdau.Value;
            }
        }

        private void dketthuc_ValueChanged(object sender, EventArgs e)
        {

            if (dbatdau.Value.Date>dketthuc.Value.Date)
            {
              dbatdau.Value=dketthuc.Value;
            }
        }

        private void tten_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { 
            blaphoadon_Click(sender, e);
            }
        }

        private void tsl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                bchon_Click(sender, e);
            }
        }

        private void dketthuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btimsesearch_Click(sender, e);
            }
        }
    }
    
}
