using PIDevGuru.PIWebApiClient;
using PIDevGuru.PIWebApiClient.Models;

namespace LibraryTestNET6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PIWebAPI client = new PIWebAPI("https://marc-pi2018.marc.net/piwebapi/");
            client.SetBasicAuth("marc.adm", "1");
            PWADataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2018");
        }
    }
}
