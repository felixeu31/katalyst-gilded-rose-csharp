using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityOver0_DecreaseQualityBy1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Bread", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].Quality);
        }
    }
}
