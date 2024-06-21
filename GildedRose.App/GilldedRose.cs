using GildedRose.Repository;
using GildedRose.Service;
using GildedRoseService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.App
{
    internal class GilldedRose
    {
        static void Main(string[] args)
        {
            var itemRepository = new ItemRepository();
            var itemService = new ItemService(itemRepository);
            var app = new GildedRoseAppService(itemService);

            for (int i = 0; i < 30; i++)
            {
                app.UpdateQuality();
                Console.WriteLine($"================================================");
                Console.WriteLine($"Day {i}");
                foreach (var item in itemRepository.GetAllItems())
                {
                    Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
                }
                Console.WriteLine($"================================================");

            }
            Console.WriteLine($"Press any key to finish");
            Console.ReadLine();

        }
    }
}
