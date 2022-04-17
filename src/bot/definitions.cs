/* Canary.CSharp | Definitions */


using System;
using CanaryAPI;
using System.IO;
using System.Security.Cryptography;

namespace Canary
{
	
	public partial class Definitions : Class
	{

		public Definitions()
		{

			// libDefinitions
			
			//sendMessage
			//kickMember
			//banMember
			
			
			CheckForIllegalCrossThreadCalls = false;

		}

		public void sendMessage(string message, string channelID, string messageType) 
		{

			CanaryAPI.sendServerDataAsMessage(message, channelID, messageType);

		}

		public void kickMember(string memberUsername, string timeKicked = null)
		{

			CanaryAPI.kickServerMember(memberUsername, timeKicked);

		}

		public void banMember(string memberUsername, string timeBanned = null)
		{

			CanaryAPI.banServerMember(memberUsername, timeBanned);

		}
	}

}
