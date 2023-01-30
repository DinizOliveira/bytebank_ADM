using bytebank_ADM.MainSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public abstract class EmployeeAuthenticated : Employee, IAuthenticated
    {
        protected EmployeeAuthenticated(string cpf, double salary) : base(cpf, salary)
        {
        }

        public string Password { get; set; }

        public bool Authentication(string password)
        {
            return this.Password== password;
        }
    }
}
