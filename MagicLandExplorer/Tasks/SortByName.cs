using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        // Sort destinations alphabetically by their name.
        public static void SortDestinations(List<Category> categories)
        {
            var sortByName = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(n => n.Name)
                .ToList();

            Destination.Print(sortByName, "Sort Destinations By Name: ");
                                
        }
    }
}
