using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Lab02.Tools.Exceptions
{
    internal class UnbornPersonException : Exception
    {
        public UnbornPersonException(DateTime birth) : base($"The date {birth.ToShortDateString()} has not yet arrived. The person has not yet been born.")
        {

        }
    }
}
