using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA2.Database;
using DA2.Model;
namespace DA2.Service
{
    public class XuLyNhaSanXuat:IListUse<NhaSanXuat>
    {
        private LinkedList<NhaSanXuat> _dsNhaSanXuat=new LinkedList<NhaSanXuat>();
        public XuLyNhaSanXuat() {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            _dsNhaSanXuat = duLieu.DocFileNSX("../../database/NhaSanXuat.dat");
        }

        public void Add(NhaSanXuat item)
        {
            _dsNhaSanXuat.AddLast(item);
        }
        public void Remove(LinkedListNode<NhaSanXuat> node)
        {
            _dsNhaSanXuat.Remove(node);
        }
        public void Update(NhaSanXuat item, LinkedListNode<NhaSanXuat> node)
        {
            node.Value.ID = item.ID;
            node.Value.Ten = item.Ten;
            node.Value.SoDienThoai = item.SoDienThoai;
            node.Value.Email = item.Email;
            node.Value.DiaChi = item.DiaChi;
        }
        public LinkedList<NhaSanXuat> Duyet_theo_ten(string f)
        {
            LinkedList<NhaSanXuat> tem=new LinkedList<NhaSanXuat>();
            foreach(NhaSanXuat ns in _dsNhaSanXuat)
            {
                if(ns.Ten.IndexOf(f, StringComparison.OrdinalIgnoreCase) >= 0)
                    tem.AddLast(ns);
            }
            return tem;
        }

        public LinkedList<NhaSanXuat> GetDS()
        {
            return _dsNhaSanXuat;
        }

        

        public LinkedListNode<NhaSanXuat> Tim_theo_Id(string f)
        {
            LinkedList<NhaSanXuat> runner = _dsNhaSanXuat;

            for (LinkedListNode<NhaSanXuat> node = runner.First; node != null; node = node.Next)
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
