﻿using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Supervisor
    {
        SupervisorDAO db = new SupervisorDAO();
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkNumber { get; set; }
        public string Password { get; set; }

        public Supervisor() { }

        public Supervisor(int id, string name, string workNumber, string password)
        {
            Id = id;
            Name = name;
            WorkNumber = workNumber;
            Password = password;
        }

        public DataTable GetSupervisors()
        {
            return db.GetSupervisorsFromDatabase();
        }
        public bool validatesupervisor(string WorkNumber, string Password)
        {
            return db.Validatecred(WorkNumber, Password);
        }

        public Supervisor Search(int SupervisorId)
        {
            return db.Search(SupervisorId);
        }
    }
}
