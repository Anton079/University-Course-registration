using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    public class Instructor : IActions
    {
        private Registration registration;

        public Instructor()
        {
            registration = new Registration();
        }

        public void EditAvailable(Course c)
        {
            if(c.Schedule < 1)
            {
                c.Available = false;
            }
            else if(c.Schedule > 0)
            {
                c.Available = true;
            }
        }

        public bool CheckAvailable(Course c)
        {
            if(c.Schedule < 1)
            {
                return false;
            }
            return true;
        }

        //=======IAcions=========
        public void Register(string courseName)
        {
            Course c = registration.SearchCourse(courseName);

            if (c != null && CheckAvailable(c))
            {
                c.Schedule -= 1;
                EditAvailable(c);
                Console.WriteLine($"Instructorul a fost inregistrat la cursul {courseName}");
            }
            else
            {
                Console.WriteLine("Cursul nu a fost gasit sau nu mai sunt locuri libere!");
            }
        }

        public void ReturnRegister(string courseName)
        {
            Course c = registration.SearchCourse(courseName);

            if (c != null)
            {
                c.Schedule += 1;
                EditAvailable(c);
                Console.WriteLine($"Instructorul a fost dezînregistrat de la cursul {courseName}");
            }
            else
            {
                Console.WriteLine("Cursul nu a fost gasit!");
            }
        }

        public void AfisareCourses(string unused)
        {
            
            Console.WriteLine("Cursurile disponibile:");
            Registration registration = new Registration();
            registration.AfisareCourses();
        }

    }
}
