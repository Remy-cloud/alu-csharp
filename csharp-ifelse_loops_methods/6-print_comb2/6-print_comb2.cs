using System;

class Program
{
	static void Main(string[] args)
	{
		string output = "";
		for (int i = 0; i < 10; i++)
		{
			for (int j = i + 1; j < 10; j++)
			{
				if (i != j)
				{
					if (output != "")
						output += ", ";
					output += i.ToString() + j.ToString();
				}
			}
		}
		Console.Write(output);
		Console.WriteLine();
	}
}