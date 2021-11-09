using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class LeadHeart : BaseHeart {
        public LeadHeart() : base(
            name: "Lead Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.LeadOre, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.LeadBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
