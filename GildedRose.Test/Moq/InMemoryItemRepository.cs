
using GildedRoseTest;
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;
using GildedRose.Repository.Interfaces;

namespace GildedRose.Test.Moq
{
    public class InMemoryItemRepository : IItemRepository
    {
        private readonly IList<IItem> _items;

        public InMemoryItemRepository(IList<IItem> items)
        {
            _items = items;
        }
        public IList<IItem> GetAllItems()
        {
            return _items;
        }
    }
}
