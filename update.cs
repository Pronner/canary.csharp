using System;
using CanaryAPI;
using System.IO;
using System.Net;

namespace Canary
{
	
	public partial class update : Class
	{

		public update()
		{

			WebClient updateClient = new WebClient();

			if (!updateClient.DownloadString(CanaryAPI.stringUpdURI).Contains("x10.1"))
			{

				updateClient.DownloadFile(CanaryAPI.stringDownloadURI, @"C:\Desktop");
				return;

			}

			// finish
			try
			{

				this.Close();

			}
			catch 
			{

				try
				{

					Application.Exit();

				}
				catch
				{

					// oops
					string oopsie = "uhh we can't exit";

					Console.WriteLine(oopsie);

				}

			}

		}

	}

}
