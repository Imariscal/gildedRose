 
namespace GildedRose.Entities
{
    public class BackstagePasses : BaseItem
    {
        public BackstagePasses(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality) { }

        public override void Update()
        {
            SellIn--;

            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn < 5)
            {
                IncreaseQuality(3);
            }
            else if (SellIn < 10)
            {
                IncreaseQuality(2);
            }
            else
            {
                IncreaseQuality(1);
            }
        }
    }
}
