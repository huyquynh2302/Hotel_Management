using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_DangKi
    {
        private int _DANGKI_ID;
        private string _DANGKI_TK;
        private string _DANGKI_MK;
        private string _DANGKI_NAME;
        private string _DANGKI_EMAIL;
        private string _DANGKI_PHONENUMBER;
        private string _DANGKI_DIACHI;

        public int DANGKI_ID
        {
            get
            {
                return _DANGKI_ID;
            }
            set
            {
                _DANGKI_ID = value;
            }
        }
        public string DANGKI_TK
        {
            get
            {
                return _DANGKI_TK;
            }
            set
            {
                _DANGKI_TK = value;
            }
        }
        public string DANGKI_MK
        {
            get
            {
                return _DANGKI_MK;
            }
            set
            {
                _DANGKI_MK = value;
            }
        }
        public string DANGKI_NAME
        {
            get
            {
                return _DANGKI_NAME;
            }
            set
            {
                _DANGKI_NAME = value;
            }
        }
        public string DANGKI_EMAIL
        {
            get
            {
                return _DANGKI_EMAIL;
            }
            set
            {
                _DANGKI_EMAIL = value;
            }
        }
        public string DANGKI_PHONENUMBER
        {
            get
            {
                return _DANGKI_PHONENUMBER;
            }
            set
            {
                _DANGKI_PHONENUMBER = value;
            }
        }
        public string DANGKI_DIACHI
        {
            get
            {
                return _DANGKI_DIACHI;
            }
            set
            {
                _DANGKI_DIACHI = value;
            }
        }

        public DTO_DangKi() 
        {

        }
        public DTO_DangKi( string tk, string mk , string name = null, string email = null, string phonenumber = null, string diachi = null)
        {
       
            this.DANGKI_TK = tk;
            this.DANGKI_MK = mk;
            this.DANGKI_NAME = name;
            this.DANGKI_EMAIL = email;
            this.DANGKI_PHONENUMBER = phonenumber;
            this.DANGKI_DIACHI = diachi;
        }
    }
}
