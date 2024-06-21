using GildedRoseTest;
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;

namespace GildedRoseTests
{
    [TestClass]
    public class SulfurasTest : BaseTest
    {
      
        [TestMethod]
        public void Sulfuras_QualityDoesNotChange()
        {
            var items = new List<IItem> { new SulfurasItem() };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
        }
      
    }
}
