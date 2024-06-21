namespace GildedRose.Entities.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        int SellIn { get; set; }
        int Quality { get; set; }
        void Update();
    }
}