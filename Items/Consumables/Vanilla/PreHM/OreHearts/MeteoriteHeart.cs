using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class MeteoriteHeart : BaseHeart {
        public MeteoriteHeart() : base(
            name: "Meteorite Heart",
            lifeBonus: 4,
            rarity: ItemRarityID.Orange,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Meteorite, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.MeteoriteBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
