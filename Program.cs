using System;

namespace RW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SessionInterface iface = new SessionInterface();

            iface.BeginLoop();
        }
    }
}
