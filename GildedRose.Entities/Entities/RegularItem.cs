 
namespace GildedRose.Entities
{
    public class RegularItem : BaseItem
    {
        public RegularItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public override void Update()
        {
            SellIn--;

            if (SellIn < 0)
            {
                DecreaseQuality(2);
            }
            else
            {
                DecreaseQuality(1);
            }
        }
    }
}
