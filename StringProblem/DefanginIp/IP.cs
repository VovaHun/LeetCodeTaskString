using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    public class IP
    {
        public string DefangIPaddr(string address)
        {

            return address.Replace(".", "[.]");
        }
    }
}
