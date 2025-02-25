using System;
class array
{
	public static void Main(String []args)
	{
		Console.WriteLine("Enter size of String array:");
		int v=Convert.ToInt32(Console.ReadLine());
		
				string[]a=new string[v];
				
				for(int i=0;i<v;i++)
				{
					Console.WriteLine("Enter value of data[{0}]:",i);
					a[i]=Console.ReadLine();
				}
				for(int i=0;i<v;i++)
				{
					Console.WriteLine("value of data[{0}]:{1}",i,a[i]);
		
				}
	}
}


