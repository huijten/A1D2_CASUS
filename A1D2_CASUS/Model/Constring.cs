using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace A1D2_CASUS.Model
{
    public class Constring
    {
        internal string connectionString = @"Server=.; Database=Gamification; Trusted_Connection=True";
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
       // private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
    }
}
