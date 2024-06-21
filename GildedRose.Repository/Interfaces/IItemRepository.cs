
using GildedRose.Entities.Interfaces;
using System.Collections.Generic;


namespace GildedRose.Repository.Interfaces
{
    public interface IItemRepository
    {
        IList<IItem> GetAllItems();
    }
}
