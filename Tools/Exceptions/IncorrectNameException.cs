using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Lab02.Tools.Exceptions
{
    internal class IncorrectNameException : Exception
    {
        public IncorrectNameException(string name) : base($"Input name {name} is incorrect. A-Z a-z letters only allowed")
        {

        }
    }
}
