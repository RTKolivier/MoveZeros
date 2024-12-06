using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

      
        int nonZeroIndex = 0;

       
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[nonZeroIndex];
                nums[nonZeroIndex] = nums[i];
                nums[i] = temp;
                nonZeroIndex++;
            }
        }

        
        Console.WriteLine(string.Join(",", nums));
    }
}
