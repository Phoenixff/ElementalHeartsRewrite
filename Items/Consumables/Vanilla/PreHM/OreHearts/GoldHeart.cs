using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class GoldHeart : BaseHeart {
        public GoldHeart() : base(
            name: "Gold Heart",
            lifeBonus: 3,
            rarity: ItemRarityID.Green,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.GoldOre, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.GoldBar, 25}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
