using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunScreenSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("cmd.exe", "/c c:\\windows\\system32\\scrnsave.scr /s");
            //Process.Start("C:\\Windows\\System32\\scrnsave.scr /s");

            
        }
    }
}
