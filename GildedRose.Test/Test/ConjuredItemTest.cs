
using GildedRoseTest;
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;

namespace GildedRoseTests
{
    [TestClass]
    public class ConjuredItemTest : BaseTest
    { 

        [TestMethod]
        public void ConjuredItem_QualityDecreasesTwiceAsFast()
        {
            var items = new List<IItem> { new ConjuredItem("Conjured Mana Cake", 10, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(18, items[0].Quality);
            Assert.AreEqual(9, items[0].SellIn);
        }

        [TestMethod]
        public void ConjuredItem_QualityDecreasesTwiceAsFastAfterSellIn()
        {
            var items = new List<IItem> { new ConjuredItem("Conjured Mana Cake", 0, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(16, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }       
    }
}