using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerHankUsers
{
	class Program
	{
		static void Main(string[] args)
		{
			var usernames = new UsernameRepository().obterUsernames(1);

			foreach (var item in usernames)
			{
				Console.WriteLine(item);
			}
		}
	}
}
