using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables {
    class NewHeartExample : BaseHeart {
        public NewHeartExample() : base(
            //Name of the heart (will be displayed in game)
            name: " Heart",
            //Name of the heart for saving, server syncing and other internal uses (use camel case: first letter lowercase then every new word starts uppercase)
            internalName: "Heart",
            //How much health the heart will give once consumed
            lifeBonus: 0,
            //The rarity of the item. Determines the color of the name and if it burns in lava
            rarity: ItemRarityID.White,
            //OPTIONAL: Is this an expert item?
            expert: false,
            //A list of all Recipes
            recipeList: new List<Recipe>() {
                //Whenever you want to add a new seperate Recipe add another "new Recipe() {}" class instance and give it its ingredients and tiles
                new Recipe() {
                    //All the crafting ingredients and their required amounts
                    //Format: (replace [bracktes] with the values you want and add commas after every line except the last one)
                    //  {ItemID.[Item name], [item amount]}
                    Ingredients = {

                    },
                    //All the required workstations for crafting the heart
                    //Format: (replace [bracktes] with the values you want and remember to add commas after every line except the last one)
                    //  TileID.[Tile Name]
                    CraftingTiles = {

                    },
                    //Does this Recipe need water to work?
                    NeedsWater = false
                }
            }
        ) 
        //No need to add anything in here
        //We're just using this class to pass data to the BaseHeart class which handles creating the item
        { }
    }
}
