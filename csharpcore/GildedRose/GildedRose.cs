using System.Collections.Generic;
using GildedRoseKata.ItemManagers;

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
                var itemManager = ItemManagerFactory.CreateItemManagerFrom(item.Name);

                itemManager.UpdateSellIn(item);
                itemManager.UpdateQuality(item);
            }
        }
    }
}
