using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests.UnitTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityOver0_DecreaseQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Bread", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityEqualsTo0_MaintainsQualityIn0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Bread", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }


        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityEqualsOver0AndSellInDatePassed_DecreaseQualityTwice()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Bread", SellIn = -1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(8, Items[0].Quality);
        }
    }
}
