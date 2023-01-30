using bytebank_ADM.Employees;
using bytebank_ADM.MainSystem;
using bytebank_ADM.Partnership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class MainSystem
    {
        public bool Logon(IAuthenticated employee, string password)
        {
            bool authentication = employee.Authentication(password);
            if (authentication)
            {
                Console.WriteLine("Boas vindas ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
