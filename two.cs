
using System;

class Two
{
    public static void Main(string[] args)
    {
		Console.Write("Enter size of rows:");
		int v = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter size of col:");
		int k = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[v, k];

        Console.WriteLine("Array dimensions: {0} x {1}", v, k);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                Console.Write("Enter value for a[{0},{1}]:", i, j);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
			Console.WriteLine();

        }

        // Print the values in the array
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("a[{0},{1}]={2}|", i, j, array[i, j]);
            }
						Console.WriteLine();

        }
		Console.WriteLine("SUM:-");
		Console.WriteLine();

		for (int i = 0; i < array.GetLength(0); i++)
        {
			int sum=0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
				sum+=array[i,j];
            }
			
				Console.WriteLine("sum of {0} Row :{1}",i,sum);
        }
    }
}