using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class CategoriesSharedLocation
    {
        public static void SharedLocation(List<Category> categories)
        {
            //Find and list all categories that have "Fantasyland" as a shared location.

            var findLocation = categories.SelectMany(c => c.Destinations)
                .Where(c => c.Location == "Fantasyland")
                .Select(c => c.Name)
                .ToList();

            Destination.Print(findLocation, "Categories that have 'Fantasyland' as a shared location:");

        }
        
    }
}
