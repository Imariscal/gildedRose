using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Repository.Interfaces;
using System.Collections.Generic;


namespace GildedRose.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly IList<IItem> _items;

        /// <summary>
        /// Asumimos que obtenemos la info desde una BD
        /// </summary>
        public ItemRepository()
        {
            _items = new List<IItem>
            {
                new RegularItem("+5 Dexterity Vest", 10, 20),
                new AgedBrie(2, 0),
                new RegularItem("Elixir of the Mongoose", 5, 7),
                new SulfurasItem(),
                new BackstagePasses(15, 20),
                new ConjuredItem("Conjured Mana Cake", 3, 6)
            };
        }

        public IList<IItem> GetAllItems()
        {
            return this._items;
        }
    }
}
