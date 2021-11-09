using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.MiscHearts {
    class FleshHeart : BaseHeart {
        public FleshHeart() : base(
            name: "Flesh Heart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.FleshBlock, 100}
                    },
                    CraftingTiles = {
                        TileID.FleshCloningVat
                    }
                }
            }
        ) { }
    }
}
