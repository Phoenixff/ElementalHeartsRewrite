using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.MiscHearts {
    class CursedFlameHeart : BaseHeart {
        public CursedFlameHeart() : base(
            name: "Cursed Flame Heart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.CursedFlame, 100}
                    },
                    CraftingTiles = {
                        TileID.CrystalBall
                    }
                }
            }
        ) { }
    }
}
