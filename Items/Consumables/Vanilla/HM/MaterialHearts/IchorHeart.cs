using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.MaterialHearts {
    class IchorHeart : BaseHeart {
        public IchorHeart() : base(
            name: "Ichor Heart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Ichor, 100}
                    },
                    CraftingTiles = {
                        TileID.CrystalBall
                    }
                }
            }
        ) { }
    }
}
