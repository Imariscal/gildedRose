namespace GildedRose.Entities
{
    public class AgedBrie : BaseItem
    {
        public AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality) { }

        public override void Update()
        {
            SellIn--;
            IncreaseQuality(1);
            if (SellIn < 0) IncreaseQuality(1);
        }
    }
     
}
