using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class DemoniteHeart : BaseHeart {
        public DemoniteHeart() : base(
            name: "Demonite Heart",
            lifeBonus: 4,
            rarity: ItemRarityID.Orange,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.DemoniteOre, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.DemoniteBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
