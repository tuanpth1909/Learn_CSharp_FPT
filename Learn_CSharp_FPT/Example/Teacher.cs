using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Teacher : Person
    {
        public Teacher(string name, int age, DateTime birth, string sex, int phone, string email, string address, string social)
        {
            this.name = name;
            this.age = age;
            this.birth = birth;
            this.sex = sex;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.social = social;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
            //Console.WriteLine("Toi ten la: {0}", name);
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
            //Console.WriteLine("Toi {0} tuoi", name);
        }
        public DateTime Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
            //Console.WriteLine("Toi sinh ngay {0}", birth);
        }
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
            //Console.WriteLine("Gioi tinh cua toi la: {0}", sex);
        }
        public int Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
            //Console.WriteLine("So dien thoai cua toi la: {0}", phone);
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
            //Console.WriteLine("Email cua toi la: {0}", email);
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
            //Console.WriteLine("Dia chi cua toi {0}", address);
        }
        public string Social
        {
            get
            {
                return social;
            }
            set
            {
                social = value;
            }
            //Console.WriteLine("Ban co the lien he: {0}", social);
        }
    }
}
