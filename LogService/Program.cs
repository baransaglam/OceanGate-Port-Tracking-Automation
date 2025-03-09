using System.ServiceProcess;

namespace LogService
{
    internal static class Program
    {
        static void Main()
        {
            ServiceBase.Run(new Service1());  // Servisi başlatır
        }
    }
}
