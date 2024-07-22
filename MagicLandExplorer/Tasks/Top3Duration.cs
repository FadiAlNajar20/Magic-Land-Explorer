using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        // Find the top three longest-duration destinations and show their names and durations.
        public static void FindTop3LongestDuration(List<Category> categories)
        {
            var filterd = categories
               .SelectMany(c => c.Destinations)
               .Where(d =>
               {
                   if (string.IsNullOrEmpty(d.Duration)) return false;
                   return d.GetValueFromDuration() > 0;
               })
               .OrderByDescending(d => d.GetValueFromDuration())
               .Take(3)
               .ToList();

            Destination.Print(filterd, "Top 3 Destinations By Longest Duration:");

        }
    }
}
