using System;

namespace GildedRoseKata.ItemManagers
{
    internal class AgedBrieItemManager : ItemManager
    {
        public void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}
