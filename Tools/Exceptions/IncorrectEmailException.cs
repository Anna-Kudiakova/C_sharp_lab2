using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Lab02.Tools.Exceptions
{
    internal class IncorrectEmailException : Exception
    {
        public IncorrectEmailException(string email) : base($"Input email [{email}] is incorrect")
        {

        }
    }
}
