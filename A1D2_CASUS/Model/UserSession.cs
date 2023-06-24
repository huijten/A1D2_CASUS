using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class UserSession
    {
        static Student Student;

        public static Student Session
        {
            get => Student;
            set => Student = value;
        }
    }
}
