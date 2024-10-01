using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    public class Registration
    {
        private List<Course> _course;
        private List<Student> _students;

        public Registration()
        {
            _course = new List<Course>();
            _students = new List<Student>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        _students.Add(new Student(line));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "Courses");

            return file;
        }

        public string ToSaveAll()
        {
            string save = "";

            for (int i = 0; i < _course.Count; i++)
            {
                save += _course[i].ToSave();

                if (i < _course.Count - 1)
                {
                    save += "\n";
                }
            }

            return save;
        }

        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    sw.WriteLine(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //CRUD

        public void AfisareCourses()
        {
            foreach(Course x in _course)
            {
                Console.WriteLine(x.CourseInfo());
            }
        }

        public Course SearchCourse(string courseName)
        {
            foreach(Course x in _course)
            {
                if (x.Schedule.Equals(courseName))
                {
                    return x;
                }
            }
            return null;
        }
    }
}
