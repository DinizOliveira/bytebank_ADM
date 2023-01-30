using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    internal class Designer:Employee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.17;
        }

        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override void IncreaseSalary()
        {
            this.Salary *= 1.11;
        }
    }
}
