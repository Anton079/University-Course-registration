using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    public interface IActions
    {
        void Register(String course);

        void ReturnRegister(String course);

        void AfisareCourses(String Crouse);
        
    }
}
