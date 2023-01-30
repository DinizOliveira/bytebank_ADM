using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Employees;

namespace bytebank_ADM.Utilitary
{
    public class ManagerBonus
    {
        public double GeneralBonus { get; private set; }

        public void Register (Employee employee)
        {
            this.GeneralBonus += employee.GetBonus();
        }

    }
}
