using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.StoneHearts {
    class GraniteHeart : BaseHeart {
        public GraniteHeart() : base(
            name: "Granite Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Granite, 100}
                    },
                    CraftingTiles = {
                        TileID.Furnaces
                    }
                }
            }
        ) { }
    }
}
