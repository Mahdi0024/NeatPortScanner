using System.Net;

namespace PortScannerLib.Events
{
    public struct PortScannerProgressReport
    {
        public IPAddress Ip { get; init; }
        public bool IsAlive { get; init; }
    }
}