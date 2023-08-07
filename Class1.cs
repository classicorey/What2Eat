using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What2Eat
{
    class BackendRestaurants
    {
        static void Main(string[] args)
        {

            string[,] Restaurants;
            Restaurants = new string[7, 7];

            /*use food type instead? ex. hamburgers, ice cream, pizza, pasta...*/
            //[x, 0] in arrays will be the categories for each

            Restaurants[0, 0] = "Asian";
            Restaurants[1, 0] = "Fast Food";
            Restaurants[2, 0] = "Mexican";
            Restaurants[3, 0] = "Seafood";
            Restaurants[4, 0] = "Dessert";
            Restaurants[5, 0] = "Italian";
            Restaurants[6, 0] = "Pizza";

            //Below are the restaurants per categories above

            Restaurants[0, 1] = "Panda Express";
            Restaurants[0, 2] = "Noodles & Company";
            Restaurants[0, 3] = "Buffet King";
            Restaurants[0, 4] = "Wasabi Wok";
            Restaurants[0, 5] = "The Great Wall";
            Restaurants[0, 6] = "Coco China";

            Restaurants[1, 1] = "McDonalds";
            Restaurants[1, 2] = "Burger King";
            Restaurants[1, 3] = "Arbys";
            Restaurants[1, 4] = "Wendy's";
            Restaurants[1, 5] = "Subway";

            Restaurants[2, 1] = "Taco Bell";
            Restaurants[2, 2] = "Taco Casa";
            Restaurants[2, 3] = "Casa Torres";
            Restaurants[2, 4] = "Dos Chiles";

            Restaurants[3, 1] = "Long John Silvers";
            Restaurants[3, 2] = "Zeke's Fish And Chips";

            Restaurants[4, 1] = "Dairy Queen";
            Restaurants[4, 2] = "Braums";

            Restaurants[5, 1] = "Olive Garden";
            Restaurants[5, 2] = "Fazolis";

            Restaurants[6, 1] = "Pizza Hut";
            Restaurants[6, 2] = "Papa Johns";
            Restaurants[6, 3] = "Dominos";
            Restaurants[6, 4] = "Hungry Howies";
            Restaurants[6, 5] = "Little Caesars";
            Restaurants[6, 6] = "Cici's Pizza";

            Console.WriteLine("List of restaurants by category:");


            //Remember if we are adding rows or columns above 7 to update the below information

            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.WriteLine(Restaurants[row, col]);
                }
                Console.WriteLine("");
            }
        }
    }
}
