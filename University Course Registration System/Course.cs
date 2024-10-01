using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    public class Course
    {
        private string _name;
        private int _code;
        private int _schedule;
        private string _instructor;
        private bool _available;

        public Course(string nameToken, int codeToken, int scheduleToken, string instructorToken, bool available)
        {
            _name = nameToken;
            _code = codeToken;
            _schedule = scheduleToken;
            _instructor = instructorToken;
            _available = available;
        }

        public Course(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _name = token[0];
            _code = Int32.Parse(token[1]);
            _schedule = Int32.Parse(token[2]);
            _instructor = token[3];
            _available = Boolean.Parse(token[4]);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public int Schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }

        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }

        public string CourseInfo()
        {
            string text = " ";

            text += "Name " + Name + "\n";
            text += "Code " + Code + "\n";
            text += "Shedule " + Schedule + "\n";
            text += "Instructor " + Instructor + "\n";
            text += "Available " + Available + "\n";
            return text;
        }

        public string ToSave()
        {
            return Name +"," + Code + "," + Schedule + "," + Instructor + "," + Available;
        }
    }
}
