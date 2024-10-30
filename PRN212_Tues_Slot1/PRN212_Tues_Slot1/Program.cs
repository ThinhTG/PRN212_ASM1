using System.Runtime.CompilerServices;

internal class program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 2, 4, 6, 12 , 28};
        // for(int i=0 ; i< number.Length ;   ){

        //}
        // Hay dem va tinh tong cac so hoan hao co trong mang

       Console.WriteLine(sumBestNumber(numbers));
    }


    private static int sumBestNumber(int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            if (isBestNumber(i))
            {
                sum += i;
            }
        }
        return sum;
    }

    private static bool isBestNumber(int number) { 
        
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return (sum == number);
    }

    }

