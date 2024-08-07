using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2.Model
{
    [Serializable]
    public abstract class common
    {
        private string ten;
        private string id;

        public common()
        {
            ten = string.Empty;
            id = string.Empty;

        }
        public common(string _id, string _ten)
        {
            ten = _ten;
            id = _id;

        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
