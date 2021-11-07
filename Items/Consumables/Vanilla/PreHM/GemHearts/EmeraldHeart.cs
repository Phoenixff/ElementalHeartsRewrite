using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.GemHearts {
    class EmeraldHeart : BaseHeart {

        public EmeraldHeart() : base(
        name: "Emerald Heart",
            lifeBonus: 4,
            rarity: ItemRarityID.Orange,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Emerald, 25},
                        {ItemID.StoneBlock, 75}
                    },
                    CraftingTiles = {
                        TileID.Extractinator
                    }
                }
            }
        ) { }
    }
}
