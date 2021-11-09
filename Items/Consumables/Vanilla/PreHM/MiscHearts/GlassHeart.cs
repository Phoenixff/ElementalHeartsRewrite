using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class GlassHeart : BaseHeart {
        public GlassHeart() : base(
            name: "Glass Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Glass, 100}
                    },
                    CraftingTiles = {
                        TileID.GlassKiln
                    }
                }
            }
        ) { }
    }
}
