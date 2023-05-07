## Requirements

	- [OK] At the end of each day our system lowers both values for every item
	- [OK] The Quality of an item is never negative
	- [OK] Once the sell by date has passed, Quality degrades twice as fast
	- [OK] "Aged Brie" actually increases in Quality the older it gets
	- [OK] The Quality of an item is never more than 50
	- [OK] "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	- [OK] "Sulfuras" is alegendary item and as such its Quality is 80 and it never alters.
	- [OK] "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	- [OK] "Backstage passes", Quality increases by 2 when there are 10 days or less 
	- [OK] "Backstage passes", Quality increases  by 3 when there are 5 days or less
	- [OK] "Backstage passes", Quality drops to 0 after the concert

## Refactoring
	- Smeels: 
		- Long method
		- goku structure
	- Objetives
		- Legibility
.....


## New functionality

We have recently signed a supplier of conjured items. This requires an update to our system:

	- "Conjured" items degrade in Quality twice as fast as normal items