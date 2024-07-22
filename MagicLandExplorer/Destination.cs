using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
       // public int DurationTime { get; set; }   

        public int GetValueFromDuration()
        {
          // return DurationTime = !string.IsNullOrEmpty(Duration)? int.Parse(Duration.Split(' ')[0]) : default;
            if (int.TryParse(Duration.Split(' ')[0], out var minutes)) return minutes;
            return 0;
        }

        public override string ToString()
        {
            return $"{Name} | {Duration}";
        }

        public static void Print<T>(List<T> list, string title)
        {
            Console.WriteLine();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘");
            Console.WriteLine();
            int i = 0;
            foreach (var index in list)
            {
                i++;
                Console.WriteLine($"{i}) {index} ");
            }
            Console.WriteLine();
        }
    }
}
