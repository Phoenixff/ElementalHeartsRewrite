using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.WoodHearts {
    class BorealWoodHeart : BaseHeart {
        public BorealWoodHeart() : base(
            name: "Boreal Wood Heart",
            internalName: "borealWoodHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() { 
                new Recipe() {
                    Ingredients = {
                        {ItemID.BorealWood, 100}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) {}
    }
}
