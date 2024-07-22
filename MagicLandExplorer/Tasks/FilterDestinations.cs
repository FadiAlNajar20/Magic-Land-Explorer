using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        // Find all destinations name with a duration less than 100 minutes.
        public static void DestinationsName(List<Category> categories)
        {
            var filtered = categories.SelectMany(c => c.Destinations)
                             .Where(d =>
                             {
                                 if (string.IsNullOrEmpty(d.Duration)) return false;
                                 return d.GetValueFromDuration() < 100;
                             })
                             .ToList();

            Destination.Print(filtered, "Destinations with duration less than 100 minutes:");
        }
    }
}
