using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        string[] stringNumbers = input.Split(' ');
        long[] numbers = Array.ConvertAll(stringNumbers, long.Parse);
        long sum = 0;
        
        sum = numbers[0] + numbers[1] + numbers[2]; // 입력값이 3개로 정해져 있기 때문에 예외는 처리하지 않음

        Console.WriteLine(sum);
    }
}