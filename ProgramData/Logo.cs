using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramData
{
    internal class Logo
    {
        public void DisplayLogo(string logo)
        {
            Console.WriteLine(logo);   
            // Display a simple logo or message
            Console.WriteLine(@"  ___           _            ___                _     
 | __|_ _  __ _(_)_ _  ___  | _ \___ _ __  __ _(_)_ _ 
 | _|| ' \/ _` | | ' \/ -_) |   / -_) '_ \/ _` | | '_|
 |___|_||_\__, |_|_||_\___| |_|_\___| .__/\__,_|_|_|  
          |___/                     |_|               ");
        }
    }
}