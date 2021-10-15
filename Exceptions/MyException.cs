using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMiriam_TelaDeLogin.Exceptions
{
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message) { }
    }
}
