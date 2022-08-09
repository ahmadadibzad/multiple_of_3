using System;
					
public class Program
{
	public static void Main()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		string str = "";
		for(int x = 1; x <= number; x++)
		{
			if(x % 3 == 0)
			{
				str += "*";
			}
			else
			{
				str += x;	
			}
		}
		Console.WriteLine(str);
	}
}