
namespace GildedRose.Entities
{
    public class ConjuredItem : BaseItem
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public override void Update()
        {
            SellIn--;

            if (SellIn < 0)
            {
                DecreaseQuality(4);
            }
            else
            {
                DecreaseQuality(2);
            }
        }
    }
}
