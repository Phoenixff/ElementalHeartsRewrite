using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.OreHearts {
    class CobaltHeart : BaseHeart{
        public CobaltHeart() : base(
            name: "Cobalt Heart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            expert: false,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.CobaltOre, 100}
                    },
                    CraftingTiles = {
                        TileID.Hellforge
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.CobaltBar, 34}
                    },
                    CraftingTiles = {
                        TileID.Hellforge
                    }
                }
            }
        ) { }
    }
}
