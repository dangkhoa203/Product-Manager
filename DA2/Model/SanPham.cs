using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Model
{
    [Serializable]
    public class SanPham : common
    {

        private float _gia;
        private int _soluong;
        private DateTime _hsd;
        private NhaSanXuat _nsx;
        public SanPham(string id, string ten,float gia, int soluong,DateTime hsd, NhaSanXuat nsx) : base(id, ten)
        {
            _gia = gia;
            _soluong = soluong;
            _hsd = hsd;
            _nsx = nsx;
        }
        public SanPham()
        {
            ID = "";
            Ten = "";
            _gia = 0;
            _soluong = 0;
            _hsd=DateTime.Now;
            _nsx=new NhaSanXuat();
           
        }
        public float Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public DateTime HSD
        {
            get { return _hsd; }
            set { _hsd = value; }
        }
        public NhaSanXuat NhaSanXuat { 
            get { return _nsx; }
            set { _nsx = value; }
        }
        public bool chkngaysd()
        {
            if (DateTime.Compare(_hsd, DateTime.Now) >= 0)
            {
                return false;//Con su dung
            }
            return true;
        }
    }
}
