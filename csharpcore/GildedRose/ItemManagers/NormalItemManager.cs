using System;

namespace GildedRoseKata.ItemManagers
{
    internal class NormalItemManager : ItemManager
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;

            if (item.Quality > 0)
            {
                if (item.SellIn < 0)
                {
                    if (item.Quality > 1)
                    {
                        item.Quality = item.Quality - 2;
                    }
                    else
                    {
                        item.Quality = 0;
                    }
                }
                else
                {
                    if (item.Quality > 0)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
        }
    }
}
