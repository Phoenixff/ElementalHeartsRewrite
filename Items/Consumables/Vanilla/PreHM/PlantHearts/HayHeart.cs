using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.PlantHearts {
    class HayHeart : BaseHeart {
        public HayHeart() : base(
            name: "Hay Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Hay, 100}
                    },
                    CraftingTiles = {
                        TileID.Sawmill
                    }
                }
            }
        ) { }
    }
}
