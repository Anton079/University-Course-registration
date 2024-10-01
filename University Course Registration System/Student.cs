using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    public class Student 
    {
        private int _id;
        private string _fullName;
        private string _mailAddress;
        private string _password;

        public Student(int id, string fullName, string mailAddress, string password)
        {
            _id = id;
            _fullName = fullName;
            _mailAddress = mailAddress;
            _password = password;
        }

        public Student(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _id = Int32.Parse(token[0]);
            _fullName = token[1];
            _mailAddress = token[2];
            _password = token[3];
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string MailAddress
        {
            get { return _mailAddress; }
            set { _mailAddress = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string StudentInfo()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "FullName " + FullName + "\n";
            text += "MailAdress " + MailAddress + "\n";
            text += "Password " + Password + "\n";
            return text; 
        }

        public string ToSave()
        {
            return Id + "," + FullName + "," + MailAddress + "," + Password;
        }

        //======Actions========


    }
}
