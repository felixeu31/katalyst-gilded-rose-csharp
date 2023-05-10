namespace GildedRoseKata.ItemManagers
{
    public class ItemManagerFactory
    {
        public static ItemManager CreateItemManagerFrom(string itemName)
        {
            if (itemName == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasItemManager();
            }

            if (itemName == "Aged Brie")
            {
                return new AgedBrieItemManager();
            }
            if (itemName == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePassesItemManager();
            }
            if (itemName.Contains("Conjured"))
            {
                return new ConjuredItemManager();
            }

            return new NormalItemManager();
        }
    }
}
