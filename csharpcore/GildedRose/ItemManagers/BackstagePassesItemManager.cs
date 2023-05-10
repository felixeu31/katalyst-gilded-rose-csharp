using System;

namespace GildedRoseKata.ItemManagers
{
    internal class BackstagePassesItemManager : ItemManager
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 6)
            {
                if (item.Quality < 48)
                {
                    item.Quality = item.Quality + 3;
                }
                else
                {
                    item.Quality = 50;
                }
            }
            else if (item.SellIn < 11)
            {
                if (item.Quality < 49)
                {
                    item.Quality = item.Quality + 2;
                }
                else
                {
                    item.Quality = 50;
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
