using DA2.Database;
using DA2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Service
{
    public class XuLySanPham : IListUse<SanPham>
    {
        private LinkedList<SanPham> _dsSanPham=new LinkedList<SanPham>();

        public XuLySanPham()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoitao();
            _dsSanPham = dulieu.DocFileSP("../../database/SanPham.dat");
        }
        public void Add(SanPham item)
        {
           _dsSanPham.AddLast(item);
        }
        public void Remove(LinkedListNode<SanPham> node)
        {
            _dsSanPham.Remove(node);
        }

        public void Update(SanPham item, LinkedListNode<SanPham> node)
        {

            node.Value.ID = item.ID;
            node.Value.Ten = item.Ten;
            node.Value.Gia = item.Gia;
            node.Value.Soluong = item.Soluong;
            node.Value.HSD = item.HSD;
            node.Value.NhaSanXuat = item.NhaSanXuat;
        }
        public LinkedList<SanPham> Duyet_theo_ten(string f)
        {

            LinkedList<SanPham> tem = new LinkedList<SanPham>();
            foreach (SanPham ns in _dsSanPham)
            {
                if (ns.Ten.IndexOf(f, StringComparison.OrdinalIgnoreCase) >= 0)
                    tem.AddLast(ns);
            }
            return tem;
        }

        public LinkedList<SanPham> GetDS()
        {
            return _dsSanPham;
        }
 
        public LinkedListNode<SanPham> Tim_theo_Id(string f)
        {
            LinkedList<SanPham> runner = _dsSanPham;

            for (LinkedListNode<SanPham> node = runner.First; node != null; node = node.Next)
            {
                if (node.Value.ID == f) return node;
            }
            return null;
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
