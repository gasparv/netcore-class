using System;

namespace Ex_1_NetStandard
{
    public class InconsistentListSizeException : Exception
    {
        public InconsistentListSizeException()
        {
        }

        public InconsistentListSizeException(string message)
            : base(message)
        {
        }

        public InconsistentListSizeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
