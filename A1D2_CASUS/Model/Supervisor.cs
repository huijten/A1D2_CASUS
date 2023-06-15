using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Supervisor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkNumber { get; set; }
        public string Password { get; set; }

        public Supervisor(int id, string name, string workNumber, string password)
        {
            Id = id;
            Name = name;
            WorkNumber = workNumber;
            Password = password;
        }
    }
}
