/* Canary.CSharp | errorhandler */

using System;
using CanaryAPI;
using System.IO;
using System.Net;

namespace Canary
{

	public partial class errorhandler : Class
	{

		public errorhandler()
		{

			if (CanaryAPI.errorReceived != string.Empty) 
			{

			        CanaryAPI.handleError();

				CanaryAPI.errorReceived.ToString();

				CanaryAPI.showConsoleMessage(errorReceived, CanaryAPI.errorWarningLevel, true);

				return errorReceived;

			}
			else
			{

				CanaryAPI.handleError();

				return;

			}

		}

	}

}
