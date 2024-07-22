using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        // Write a LINQ query to find and display name of the destination with the
        // longest duration among all categories.

        public static void FindLongestDuration(List<Category> categories)
        {
             var filterd = categories
                .SelectMany(c => c.Destinations)
                .Where(d =>
                {
                    if (string.IsNullOrEmpty(d.Duration)) return false;
                    return d.GetValueFromDuration() > 0;
                })
                .OrderByDescending(d => d.GetValueFromDuration())
                .Take(1)
                .ToList();

            Destination.Print(filterd, "Name Of The Destination With The Longest Duration:");

        }
    }
}
