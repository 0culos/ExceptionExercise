using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExercise.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {
        }
    }
}
