using System;
namespace Class
{
	public class Account
	{
		public void Login(string username, string password)
		{
			if (username == "cavid123" && password == "Cavid1993")
			{
				Console.WriteLine("Login completed successfully");
			}

			else
			{
				Console.WriteLine("Username or password is wrong");
			}
		}
	}
}

