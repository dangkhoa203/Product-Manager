using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Model
{
    [Serializable]
    public class NhaSanXuat : common
    {
        private string diachi;
        private string sdt;
        private string email;
        public NhaSanXuat()
        {
            ID = string.Empty;
            Ten = string.Empty;
            sdt = string.Empty;
            email = string.Empty;
            diachi = string.Empty;
        }
        public NhaSanXuat(string _id, string _ten, string _sdt, string _email, string _diachi) : base(_id, _ten)
        {
            diachi = _diachi;
            email = _email;
            sdt = _sdt;
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string SoDienThoai
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
