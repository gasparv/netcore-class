using Ex_9_RazorDirectives.Services.Definitions;
using System;

namespace Ex_9_RazorDirectives.Services.Implementations
{
    public class CurrentDateTime : ICurrentDateTimeFormatter
    {

        public string GetCurrentDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        public string GetCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
