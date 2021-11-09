using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class HellstoneHeart : BaseHeart {
        public HellstoneHeart() : base(
            name: "Hellstone Heart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Hellstone, 100},
                        {ItemID.Obsidian, 34}
                    },
                    CraftingTiles = {
                        TileID.Hellforge
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.HellstoneBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Hellforge
                    }
                }
            }
        ) { }
    }
}
