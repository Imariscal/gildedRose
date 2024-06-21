using GildedRoseService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Service
{
    public class GildedRoseAppService
    {
        private readonly IItemService _itemService;

        public GildedRoseAppService(IItemService itemService)
        {
            _itemService = itemService;
        }

        public void UpdateQuality()
        {
            _itemService.UpdateQuality();
        }
    }
}
