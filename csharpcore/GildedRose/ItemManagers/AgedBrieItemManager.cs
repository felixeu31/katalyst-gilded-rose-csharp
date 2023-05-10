using System;

namespace GildedRoseKata.ItemManagers
{
    internal class AgedBrieItemManager : ItemManager
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;

            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}
