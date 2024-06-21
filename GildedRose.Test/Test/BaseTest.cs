using GildedRose.Entities.Interfaces;
using GildedRose.Test.Moq;
using GildedRoseService.Interfaces;
using GildedRoseService.Services;
 
namespace GildedRoseTest
{
    public class BaseTest
    {
        protected IItemService CreateItemService(IList<IItem> items)
        {
            var repository = new InMemoryItemRepository(items);
            return new ItemService(repository);
        }
    }
}
