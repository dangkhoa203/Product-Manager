using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Model
{
    [Serializable]
    public class Hoadon:common
    {
         private LinkedList<SanPham> _sanphammua;
         private DateTime _ngaydat=DateTime.Now;
        public float TongGiatri
        {
            get
            {
                float tong=0;
                foreach(SanPham sp in _sanphammua)
                {
                    tong += sp.Gia * sp.Soluong;
                }
                return tong;
            }
        }
        public LinkedList<SanPham> SanPhamMua
        {
            get { return _sanphammua; }
            set { _sanphammua = value;}
        }
        public DateTime NgayDat
        {
            get { return _ngaydat; }
            set {  _ngaydat = value; }
        }
        public Hoadon()
        {
            ID=string.Empty;
            Ten=string.Empty;
            _sanphammua=new LinkedList<SanPham>();
        }
        public Hoadon(string _id,string _ten,LinkedList<SanPham> _spmua):base(_id,_ten)
        {
            _sanphammua = _spmua;
        }
    }
}
