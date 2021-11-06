using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables {
    class BubbleHeart : BaseHeart {
        public BubbleHeart() : base(
            //Name of the heart (will be displayed in game)
            name: "Bubble Heart",
            //Name of the heart for saving, server syncing and other internal uses (use camel case: first letter lowercase then every new word starts uppercase)
            internalName: "bubbleHeart",
            //How much health the heart will give once consumed
            lifeBonus: 2,
            //The rarity of the item. Determines the color of the name and if it burns in lava
            rarity: ItemRarityID.Blue,
            //OPTIONAL: Is this an expert item?
            expert: false,
            //All the crafting ingredients and their required amounts
            //Format: (replace [bracktes] with the values you want and add commas after every line except the last one)
            //  {ItemID.[Item name], [item amount]}
            ingredients: new Dictionary<int, int>() {
            },
            //All the required workstations for crafting the heart
            //Format: (replace [bracktes] with the values you want and remember to add commas after every line except the last one)
            //TileID.[Tile Name]
            craftingTiles: new List<int>() {
            }
        ) 
        //No need to add anything in here
        //We're just using this class to pass data to the BaseHeart class which handles creating the item
        { }
    }
}
