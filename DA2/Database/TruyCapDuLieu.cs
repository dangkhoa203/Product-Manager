using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA2.Model;
namespace DA2.Database
{
    public class TruyCapDuLieu
    {
        private static TruyCapDuLieu instance=null;
        public static TruyCapDuLieu khoitao()
        {
            if(instance==null)
                instance=new TruyCapDuLieu();
            return instance;
        }
        public LinkedList<NhaSanXuat> DocFileNSX(string address)
        {
            LinkedList<NhaSanXuat> ds = new LinkedList<NhaSanXuat>();
            try
            {

                FileStream fs = new FileStream(address, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = (LinkedList<NhaSanXuat>)bf.Deserialize(fs);
                fs.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public LinkedList<SanPham> DocFileSP(string address)
        {

            LinkedList<SanPham> ds = new LinkedList<SanPham>();
            try
            {

                FileStream fs = new FileStream(address, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = (LinkedList<SanPham>)bf.Deserialize(fs);
                fs.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public LinkedList<Hoadon> DocFileHD(string address)
        {

            LinkedList<Hoadon> ds = new LinkedList<Hoadon>();
            try
            {

                FileStream fs = new FileStream(address, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = (LinkedList<Hoadon>)bf.Deserialize(fs);
                fs.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Save(LinkedList<SanPham> ds, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ds);
            fs.Close();
        }
        public static void Save(LinkedList<NhaSanXuat> ds, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ds);
            fs.Close();
        }
        public static void Save(LinkedList<Hoadon> ds, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ds);
            fs.Close();
        }
        
        
    }

}
