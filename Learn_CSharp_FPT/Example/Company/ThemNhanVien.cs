using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Company
{
    class ThemNhanVien
    {
        //tao cac truong(field) cho class
        private string ten;
        private string gioiTinh;
        private string ngaySinh;
        private string bangCap;

        //tao Constructor
        public ThemNhanVien(string ten, string gioiTinh, string ngaySinh, string bangCap)
        {
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.bangCap = bangCap;
        }

        //tao set, get
        public string Ten
        {
            get; set;
        }
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                if() ;
            }
        }
        public string NgaySinh
        {
            get; set;
        }
        public string BangCap
        {
            get; set;
        }

    }
}
