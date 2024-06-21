 
using GildedRoseTest;
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;

namespace GildedRoseTests
{
    [TestClass]
    public class GildedRoseTests : BaseTest
    { 
        [TestMethod]
        public void BackstagePasses_QualityIncreasesBy1()
        {
            var items = new List<IItem> { new BackstagePasses(15, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(21, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [TestMethod]
        public void BackstagePasses_QualityIncreasesBy2()
        {
            var items = new List<IItem> { new BackstagePasses(10, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(22, items[0].Quality);
            Assert.AreEqual(9, items[0].SellIn);
        }

        [TestMethod]
        public void BackstagePasses_QualityIncreasesBy3()
        {
            var items = new List<IItem> { new BackstagePasses(5, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(23, items[0].Quality);
            Assert.AreEqual(4, items[0].SellIn);
        }

        [TestMethod]
        public void BackstagePasses_QualityDropsToZero()
        {
            var items = new List<IItem> { new BackstagePasses(0, 20) };
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }
       
    }
}
