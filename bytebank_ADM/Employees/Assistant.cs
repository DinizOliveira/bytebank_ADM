using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    internal class Assistant:Employee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.2;
        }

        public Assistant(string cpf) : base(cpf, 2000)
        {

        }

        public override void IncreaseSalary()
        {
            this.Salary *= 1.1;
        }
    }
}
