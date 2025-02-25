using System;
class two
{
	public static void Main(String[]args)
	{
		int v=Convert.ToInt32(Console.ReadLine());
		int k=Convert.ToInt32(Console.ReadLine());
		
		int[,]a=new int[v,k];
		
		
		for(int i=0;i<a.GetLength(0);i++)
		{
			for(int j=0;j<a.GetLength(0);j++)
			{
				a[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		
		for(int i=0;i<a.GetLength(0);i++)
		{
			for(int j=0;j<a.GetLength(0);j++)
			{
				Console.WriteLine("a[{0},{1}]={2}",i,j,a[i,j]);
			}
		}
		
	}
}