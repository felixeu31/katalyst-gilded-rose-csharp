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
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityEqualsTo0_MaintainsQualityIn0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }


        [Fact]
        public void UpdateQuality_WhenSimpleItemWithQualityEqualsOver0AndSellInDatePassed_DecreaseQualityTwice()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = -1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(8, Items[0].Quality);
        }


        [Fact]
        public void UpdateQuality_WhenAgedBrie_IncreaseQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(11, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenAgedBrieHasMaxQuality_DoesNotIncreaseQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenLegendaryItem_QualityRemainsTheSame()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }


        [Fact]
        public void UpdateQuality_WhenBackstagePasses_QualityIncreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(21, Items[0].Quality);
        }


        [Fact]
        public void UpdateQuality_WhenBackstagePasses_QualityIncreasesTwice()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenBackstagePasses_QualityIncreasesTriple()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_WhenBackstagePassesAndSellInDatePassed_QualityDropsTo0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert")]
        [InlineData("Aged Brie")]
        [InlineData("Elixir of the Mongoose")]
        public void UpdateQuality_WhenNoLegendaryItem_SellInDateDecrease(string itemName)
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = itemName, SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(-1, Items[0].SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(-1)]
        public void UpdateQuality_WhenLegendaryItem_SellInDateRemains(int sellInDate)
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellInDate, Quality = 80 } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(sellInDate, Items[0].SellIn);
        }
    }
}
