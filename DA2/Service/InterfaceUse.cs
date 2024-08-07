using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Service
{
    interface IListUse<T>
    {
        LinkedList<T> GetDS();
        void Add(T item);
        void Remove(LinkedListNode<T> node);
        void Update(T item, LinkedListNode<T> node);
        LinkedListNode<T> Tim_theo_Id(string f);
        LinkedList<T> Duyet_theo_ten(string f);
         
        bool Kiem_tra_trung(string f);
    }
}
