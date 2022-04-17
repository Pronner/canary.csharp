/* Canary.CSharp | auth */

using System;
using CanaryAPI;
using CanaryAPI.Authentication;
using CanaryAPI.Client;
using System.IO;
using System.Net;

namespace Canary
{
	
	public partial class auth : Class
	{

		string client = null;

		public auth()
		{

			client = File.ReadAllLines(CanaryAPI.AuthClient);

			CanaryAPI.StartAuthProcess();
			CanaryAPI.WaitForAuthEnd("3x10s");
			CanaryAPI.Reload(client);

			// end auth

		}
	}
}
