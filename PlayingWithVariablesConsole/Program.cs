using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayingWithVariablesConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			int age;
			string name;

			bool isAlive;

			age = 23;

			name = "Brianna";

			isAlive = true;

			Console.WriteLine($"({name} {age} is she alive: {isAlive}"); 
		}
	}
}
