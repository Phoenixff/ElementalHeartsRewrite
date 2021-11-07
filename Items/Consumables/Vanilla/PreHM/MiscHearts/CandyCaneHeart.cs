using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class CandyCaneHeart : BaseHeart {
        public CandyCaneHeart() : base(
            name: "Candy Cane Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            expert: false,
            recipeList: new List<Recipe>() { 
                new Recipe() {
                    Ingredients = {
                        {ItemID.CandyCaneBlock, 50},
                        {ItemID.GreenCandyCaneBlock, 50}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) 
        //No need to add anything in here
        //We're just using this class to pass data to the BaseHeart class which handles creating the item
        { }
    }
}
