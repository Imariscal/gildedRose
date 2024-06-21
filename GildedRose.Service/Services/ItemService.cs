
using GildedRose.Repository.Interfaces;
using GildedRoseService.Interfaces;


namespace GildedRoseService.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void UpdateQuality()
        {
            var items = _itemRepository.GetAllItems();
            foreach (var item in items)
            {
                item.Update();
            }
        }
    }
}
