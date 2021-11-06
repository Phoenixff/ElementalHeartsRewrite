using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables {
    class AmethystHeart : BaseHeart {
        public AmethystHeart() : base(
            //Name of the heart (will be displayed in game)
            name: "Amethyst Heart",
            //Name of the heart for saving, server syncing and other internal uses (use camel case: first letter lowercase then every new word starts uppercase)
            internalName: "amethystHeart",
            //How much health the heart will give once consumed
            lifeBonus: 2,
            //The rarity of the item. Determines the color of the name and if it burns in lava
            rarity: ItemRarityID.Blue,
            //All the crafting ingredients and their required amounts
            //Format: (replace [bracktes] with the values you want and add commas after every line except the last one)
            //  {ItemID.[Item name], [item amount]}
            ingredients: new Dictionary<int, int>() {
                {ItemID.Amethyst, 25},
                {ItemID.StoneBlock, 75}
            },
            //All the required workstations for crafting the heart
            //Format: (replace [bracktes] with the values you want and remember to add commas after every line except the last one)
            //TileID.[Tile Name]
            craftingTiles: new List<int>() {
                TileID.Extractinator
            }
        ) 
        //No need to add anything in here
        //We're just using this class to pass data to the BaseHeart class which handles creating the item
        { }
    }
}
