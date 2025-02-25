
using System;
class two_jagged
{
	public static void Main()
	{
		Console.Write("Enter size of rows:");
		int row=Convert.ToInt32(Console.ReadLine());
		int [][]arr=new int [row][];
		
		for(int s=0; s<row; s++)
		{
			Console.Write("Enter size of columns on {0}'s index:",s);
			int column=Convert.ToInt32(Console.ReadLine());
			arr[s]=new int[column];
		}
		
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine("Enter value of {0}'s index:",i);
			for(int j=0;j<arr[i].Length;j++)
			{
				arr[i][j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		for(int i=0;i<arr.Length;i++)
		{
			
			for(int j=0;j<arr[i].Length;j++)
			{
				Console.WriteLine("arr[{0}][{1}]={2}",i,j,arr[i][j]);
			}
		}
		Console.WriteLine("SUM:-");
		Console.WriteLine();

		for (int i = 0; i < arr.Length; i++)
        {
			int sum=0;
            for (int j = 0; j < arr[i].Length; j++)
            {
				sum+=arr[i][j];
            }
			
				Console.WriteLine("sum of {0} Row :{1}",i,sum);
        }
	}
}