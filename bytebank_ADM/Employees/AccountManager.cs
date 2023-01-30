using bytebank_ADM.MainSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class AccountManager: EmployeeAuthenticated
    {
        public override double GetBonus()
        {
            return this.Salary * 0.25;
        }

        public AccountManager(string cpf) : base(cpf, 4000)
        {

        }

        public override void IncreaseSalary()
        {
            this.Salary *= 1.05;
        }
    }
}
