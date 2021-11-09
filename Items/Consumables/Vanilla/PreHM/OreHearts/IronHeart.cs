using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class IronHeart : BaseHeart {
        public IronHeart() : base(
            name: "Iron Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.IronOre, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.IronBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
