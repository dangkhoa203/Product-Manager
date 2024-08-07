using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA2
{
    public partial class ViewMain : Form
    {
        public ViewMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewNhaSanXuat fnsx = new ViewNhaSanXuat();
            fnsx.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewSanPham fsp=new ViewSanPham();
            fsp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewHoaDon fhd=new ViewHoaDon();
            fhd.ShowDialog();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyValue=='1') {
            button1_Click(sender, e);
            }
            if (e.KeyValue == '2')
            {
                button2_Click(sender, e);
            }
            if (e.KeyValue == '3')
            {
                button3_Click(sender, e);
            }
        }
    }
}
