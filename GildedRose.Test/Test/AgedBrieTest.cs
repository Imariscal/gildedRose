
using GildedRose.Entities;
using GildedRose.Entities.Interfaces;
using GildedRose.Service;
using GildedRoseTest;


namespace GildedRoseTests
{
    [TestClass]
    public class AgedBrieTest : BaseTest
    { 

        [TestMethod]
        public void AgedBrie_QualityIncreases()
        {
            var items = new List<IItem> { new AgedBrie(10, 20) }; 
            var itemService = CreateItemService(items);
            var app = new GildedRoseAppService(itemService);

            app.UpdateQuality();

            Assert.AreEqual(21, items[0].Quality);  
            Assert.AreEqual(9, items[0].SellIn);   
        }
       
    }
}
