using bytebank_ADM.MainSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class Director:EmployeeAuthenticated
    {
        public override double GetBonus()
        {
            return this.Salary * 0.5;
        }

        public Director(string cpf):base(cpf, 5000)
        {

        }

        public override void IncreaseSalary()
        {
            this.Salary *= 1.15;
        }
    }
}
