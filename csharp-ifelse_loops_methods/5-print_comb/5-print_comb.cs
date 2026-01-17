using System;

class Program
{
	static void Main(string[] args)
	{
		string output = "";
		for (int i = 0; i <= 99; i++)
		{
			if (i < 99)
				output += i.ToString("D2") + ", ";
			else
				output += i.ToString("D2");
		}
		Console.Write(output);
		Console.Write("\n");
	}
}