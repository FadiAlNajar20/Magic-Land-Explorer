using MagicLandExplorer.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var path = "../../../Data/MagicLandData.json";

            try
            {
                string json = File.ReadAllText(path);
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);
                /*
                 example: 1- show diltered destinations
                2- show longest duration
                3- Sort destinations by Name
                4- show top 3 durtion
                 */
                Console.WriteLine("┌───────────────────────────────────────────────────────┐");
                Console.WriteLine($"│   Welcome in Magic Land Explorer│");
                Console.WriteLine("└───────────────────────────────────────────────────────┘");

                bool isTrue = true;
                while (isTrue)
                {
                    Console.WriteLine("Select an option: ");
                    Console.WriteLine("\t1. Show Filtered Destinations Less Than 100 Minutes");
                    Console.WriteLine("\t2. Show Longest Duration");
                    Console.WriteLine("\t3. Sort Destinations By Name");
                    Console.WriteLine("\t4. Show Top 3 Destinations By Durtion");
                    Console.WriteLine("\t5. Show and list all categories that have \"Fantasyland\" as a shared location.");
                    Console.WriteLine("\t6. Exit");
                    Console.Write("Enter your Choose here: ");
                    int choose = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                    switch (choose)
                    {
                        case 1:
                            FilterDestinations.DestinationsName(categories);
                            break;
                        case 2:
                            LongestDuration.FindLongestDuration(categories);
                            break;
                        case 3:
                            SortByName.SortDestinations(categories);
                            break;
                        case 4:
                            Top3Duration.FindTop3LongestDuration(categories);
                            break;
                        case 5:
                            CategoriesSharedLocation.SharedLocation(categories);
                            break;
                        case 6:
                            Console.WriteLine();
                            isTrue = false;
                            break;
                        default:
                            Console.WriteLine($"\nInvalid option '{choose}', try agean.\n");
                            break;  
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
    }
}
