using System;

class Program
{
    static void Main()
    {
        // 첫 번째 입력: 총액(total)
        string totalInput = Console.ReadLine();
        long total = long.Parse(totalInput); 
        
        // 두 번째 입력: 개수(count)
        string countInput = Console.ReadLine();
        int count = int.Parse(countInput); 

        long sum = 0;

        // 반복문으로 count개의 입력 처리
        for (int i = 0; i < count; i++)
        {
            string productInput = Console.ReadLine();
            string[] stringNumbers = productInput.Split(' ');
            long[] numbers = Array.ConvertAll(stringNumbers, long.Parse);

            sum += numbers[0] * numbers[1];
        }

        // 총합 비교
        if (sum == total)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}