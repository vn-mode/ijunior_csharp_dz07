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
            int waitingHours;
            int waitingMinutes;
            int oneHour = 60;

            Console.Write("Введите количество людей в очереди: ");
            countPeople = Convert.ToInt32(Console.ReadLine());

            allTime = countPeople * waitingTime;
            waitingHours = allTime / oneHour;
            waitingMinutes = allTime % oneHour;

            Console.WriteLine($"Вам придётся простоять в очереди {waitingHours} часов и {waitingMinutes} минут.");
        }
    }
}
