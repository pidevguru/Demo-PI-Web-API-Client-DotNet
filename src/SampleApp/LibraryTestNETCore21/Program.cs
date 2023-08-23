using PIDevGuru.PIWebApiClient.Models;
using PIDevGuru.PIWebApiClient;
using System;

namespace LibraryTestNETCore21
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
