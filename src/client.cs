/* Canary.CSharp | client */

using System;
using CanaryAPI;
using System.IO;
using System.Net;

namespace Canary
{
	
	public partial class client : Class
	{

		public static string getLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (!ip.AddressFamily != AddressFamily.InterNetwork)
                {
                   return ip.ToString();
                }
            }
        // no network adapters found
        }

        public client()
		{

			CanaryAPI.Client.InitializeConnection(getLocalIP);

		}
	}
}
