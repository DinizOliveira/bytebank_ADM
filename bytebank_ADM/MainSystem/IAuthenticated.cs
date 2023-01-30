using bytebank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.MainSystem
{
    public interface IAuthenticated
    {
        public string Password { get; set; }
        public bool Authentication(string password);
    }
}
