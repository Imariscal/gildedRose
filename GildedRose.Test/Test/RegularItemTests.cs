using GildedRoseTest;
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;

namespace GildedRoseTests
{
    [TestClass]
    public class RegularItemTests : BaseTest
    {
        [TestMethod]
        public void RegularItem_QualityDecreases()
        {
            var items = new List<IItem> { new RegularItem("Regular Item", 10, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(19, items[0].Quality);
            Assert.AreEqual(9, items[0].SellIn);
        }

        [TestMethod]
        public void Item_QualityNeverAboveFifty()
        {
            var items = new List<IItem> { new AgedBrie(10, 50) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(50, items[0].Quality);
        }


    }
}
