using GildedRose.Entities.Interfaces;

namespace GildedRose.Entities
{
    public abstract class BaseItem : IItem
    {
        public string Name { get; private set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        protected BaseItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public abstract void Update();

        protected void DecreaseQuality(int amount)
        {
            Quality = Quality - amount < 0 ? 0 : Quality - amount;
        }

        protected void IncreaseQuality(int amount)
        {
            Quality = Quality + amount > 50 ? 50 : Quality + amount;
        }
    }
}
