using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    //CheckThis: should cactus hearts go in the Wood_Hearts folder? ~Phoenixff
    class CactusHeart : BaseHeart {
        public CactusHeart() : base(
            name: "Cactus Heart",
            internalName: "cactusHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            expert: false,
            recipeList: new List<Recipe>() { 
                new Recipe() {
                    Ingredients = {
                        {ItemID.Cactus, 100}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) { }
    }
}
