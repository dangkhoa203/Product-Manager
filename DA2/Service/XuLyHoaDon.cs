using DA2.Database;
using DA2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Service
{
    internal class XuLyHoaDon : IListUse<Hoadon>
    {
        LinkedList<Hoadon> _dsHoaDon = new LinkedList<Hoadon>();
       
        public XuLyHoaDon()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            _dsHoaDon = duLieu.DocFileHD("../../database/HoaDon.dat");
        }
        public void Add(Hoadon item)
        {
            _dsHoaDon.AddLast(item);
        }
        public void Remove(LinkedListNode<Hoadon> node)
        {
           _dsHoaDon.Remove(node);
        }
        public void Update(Hoadon item, LinkedListNode<Hoadon> node)
        {
            throw new NotImplementedException();
        }
        public LinkedList<Hoadon> GetDS()
        {
            return _dsHoaDon;
        }
        public LinkedList<Hoadon> Duyet_theo_ten(string f)
        {
            LinkedList<Hoadon> tem = new LinkedList<Hoadon>();
            foreach (Hoadon hd in _dsHoaDon)
            {
                if (hd.Ten.IndexOf(f, StringComparison.OrdinalIgnoreCase) >= 0)
                    tem.AddLast(hd);
            }
            return tem;
        }
        public LinkedList<Hoadon> Duyet_theo_khoang_thoi_gian(DateTime batdau,DateTime ketthuc)
        {
            LinkedList<Hoadon> tem = new LinkedList<Hoadon>();
            foreach (Hoadon hd in _dsHoaDon)
            {
                if (hd.NgayDat.Date>=batdau.Date&&hd.NgayDat.Date<=ketthuc.Date)
                    tem.AddLast(hd);
            }
            return tem;
        }
        public LinkedListNode<Hoadon> Tim_theo_Id(string f)
        {
            LinkedList<Hoadon> runner = _dsHoaDon;

            for (LinkedListNode<Hoadon> node = runner.First; node != null; node = node.Next)
            {
                if (node.Value.ID == f) return node;
            }
            return null;
        }
        public void clear()
        {
            _dsHoaDon.Clear();
        }
        public LinkedList<Hoadon> Duyet_theo_khoang_thoi_gian(LinkedList<Hoadon> ds, DateTime batdau, DateTime ketthuc)
        {
            LinkedList<Hoadon> tem = new LinkedList<Hoadon>();
            foreach (Hoadon hd in ds)
            {
                if (hd.NgayDat.Date >= batdau.Date && hd.NgayDat.Date <= ketthuc.Date)
                    tem.AddLast(hd);
            }
            return tem;
        }

        public bool Kiem_tra_trung(string f)
        {
            if (Tim_theo_Id(f) != null)
            {
                return true;
            }
            return false;
        }
    }
}
