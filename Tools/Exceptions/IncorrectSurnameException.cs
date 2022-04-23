using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Lab02.Tools.Exceptions
{
    internal class IncorrectSurnameException : Exception
    {
        public IncorrectSurnameException(string name) : base($"Input username {name} is incorrect. A-Z a-z letters only allowed")
        {

        }
    }
}
