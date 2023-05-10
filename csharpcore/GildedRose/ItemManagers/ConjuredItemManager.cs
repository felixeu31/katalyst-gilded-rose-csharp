using System;

namespace GildedRoseKata.ItemManagers
{
    internal class ConjuredItemManager : ItemManager
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;

            if (item.Quality > 0)
            {
                if (item.SellIn < 0)
                {
                    if (item.Quality > 3)
                    {
                        item.Quality = item.Quality - 4;
                    }
                    else
                    {
                        item.Quality = 0;
                    }
                }
                else
                {
                    if (item.Quality > 1)
                    {
                        item.Quality = item.Quality - 2;
                    }
                }
            }
        }
    }
}
