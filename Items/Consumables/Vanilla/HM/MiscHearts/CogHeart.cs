using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.MiscHearts {
    class CogHeart : BaseHeart {
        public CogHeart() : base(
            name: "Cog Heart",
            internalName: "cogHeart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            expert: false,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Cog, 100}
                    },
                    CraftingTiles = {
                        TileID.SteampunkBoiler
                    }
                }
            }
        ) { }
    }
}
