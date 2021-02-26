using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string ServiceName = "MyWindowsService";

            ServiceController sc = new ServiceController(ServiceName);

            Console.WriteLine("Aktualny status uslugi: " + WindowsServiceHelper.CheckStatus(sc));
            Console.WriteLine("Zatrzymuję usługę...");
            WindowsServiceHelper.StopWindowsService(sc);
            Console.WriteLine("Aktualny status uslugi: " + WindowsServiceHelper.CheckStatus(sc));
            Console.WriteLine("Ponownie uruchamiam usługę...");
            WindowsServiceHelper.StartOrRestartWindowsService(sc);
            Console.WriteLine("Aktualny status uslugi: " + WindowsServiceHelper.CheckStatus(sc));
            Console.ReadLine();
        }
    }
}
