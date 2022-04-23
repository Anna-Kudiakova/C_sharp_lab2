using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Lab02.Tools.Exceptions
{
    internal class OveragedPersonException : Exception
    {

        public OveragedPersonException(DateTime birth) : base($"The person with birth date [{birth.ToShortDateString()}] is more than 135 years")
        {

        }
    }
}
