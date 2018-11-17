using System;
using System.Numerics;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTimeSecs = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploatedTime = long.Parse(Console.ReadLine());

            long totalFilterTime = filterTimeSecs * picturesTaken;
            long goodPic = (long)(Math.Ceiling(picturesTaken * filterFactor / 100d));
            long totalUploadTime = goodPic * uploatedTime;
            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine($"{projectTime.Days:d1}:{projectTime.Hours:d2}:{projectTime.Minutes:d2}:{projectTime.Seconds:d2}");

        }
    }
}