using System;

class Program
{
    static void Main()
    {
        int[] denominations = { 100, 200, 500, 1000, 2000, 5000 };
        Console.WriteLine("Введите сумму (кратную 100 руб. и не превышающую 50 000 руб.):");

        int amount = int.Parse(Console.ReadLine());

        if (amount % 100 == 0 && amount <= 50000)
        {
            int ways = CountWaysToDispense(denominations, amount);
            Console.WriteLine($"Количество способов выдачи суммы: {ways}");
        }
        else
        {
            Console.WriteLine("Неверная сумма. Пожалуйста, введите корректную сумму.");
        }

        Console.ReadLine();
    }

    static int CountWaysToDispense(int[] denominations, int amount)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;

        foreach (int denom in denominations)
        {
            for (int i = denom; i <= amount; i++)
            {
                dp[i] += dp[i - denom];
            }
        }

        return dp[amount];
    }
}
