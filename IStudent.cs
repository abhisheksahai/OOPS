using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface IStudent
    {
        public string GetTime()
        {
            var str = System.DateTime.Now.ToString("yyyy-MM-dd");
            return str;
        }

        string GreetingsMessage();
    }
}
