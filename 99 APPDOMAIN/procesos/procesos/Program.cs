using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace procesos
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Process> procesos = from proceso in Process.GetProcesses() orderby proceso.Id select proceso;
            foreach (var proceso in procesos)
            {
                Console.WriteLine("ID : {0}, NOMBRE {1}", proceso.Id, proceso.ProcessName);
            }
            
            Process process = null;
            try
            {
                process = Process.Start("chrome.exe", "www.youtube.com");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                
            }
            Console.ReadKey();
            try
            {
                process.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);

            }
            Console.ReadKey();
        }
    }
}
