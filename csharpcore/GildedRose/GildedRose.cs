﻿using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                UpdateSellIn(item);
                UpdateQuality(item);
            }
        }

        private static void UpdateQuality(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {

            }
            else if (item.Name == "Aged Brie")
            {
                UpdateAgedBrieQuality(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                UpdateBackStagePassesQuality(item);
            }
            else
            {
                UpdateNormalItemQuality(item);
            }
        }

        private static void UpdateNormalItemQuality(Item item)
        {
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
                        item.Quality = item.Quality - 1;
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

        private static void UpdateBackStagePassesQuality(Item item)
        {
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

        private static void UpdateAgedBrieQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private static void UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }
    }
}
