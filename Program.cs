using System;

namespace vn_mode_csharp_dz07
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople;
            int waitingTime = 10;
            int allTime;
            int countHours;
            int countMinutes;

            Console.Write("Введите количество людей в очереди: ");
            countPeople = Convert.ToInt32(Console.ReadLine());

            allTime = countPeople * waitingTime;
            countHours = allTime / 60;
            countMinutes = allTime % 60;

            Console.WriteLine($"Вам придётся простоять в очереди {countHours} часов и {countMinutes} минут.");
        }
    }
}
