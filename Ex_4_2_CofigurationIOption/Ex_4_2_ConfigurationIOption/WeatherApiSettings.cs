using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_4_2_ConfigurationIOption
{
    public class WeatherApiSettings
    {
        public WeatherApiSettings()
        {

        }
        public int WeatherApiVersion { get; set; }
        public string WeatherApiKey { get; set; } = "$3cR3+_k3y";
    }
}
