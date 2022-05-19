using System;

namespace vn_mode_csharp_dz07
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople;
            int waitingTime = 10;
            int sumAllMinutes;
            int waitingHours;
            int waitingMinutes;
            int minutesInHour = 60;

            Console.Write("Введите количество людей в очереди: ");
            countPeople = Convert.ToInt32(Console.ReadLine());

            sumAllMinutes = countPeople * waitingTime;
            waitingHours = sumAllMinutes / minutesInHour;
            waitingMinutes = sumAllMinutes % minutesInHour;

            Console.WriteLine($"Вам придётся простоять в очереди {waitingHours} часов и {waitingMinutes} минут.");
        }
    }
}
