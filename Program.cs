using System.Threading;
using System.Timers;

namespace Sorting_Algorithms_AWESOME
{
    class Program
    {
        static void Main(string[] args)
        {
            Visualization.Initialize();
            Sorting.Initialize();
            //Visualization.SijmenIsTheBest();
            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }

    public class Candle
    {
        int X        { get; set; }
        int Y        { get; set; }
        int value    { get; set; }
        string state { get; set; }
    }
}
