using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.GemHearts {
    class CrystalHeart : BaseHeart {
        public CrystalHeart() : base(
            name: "Crystal Heart",
            internalName: "crystalHeart",
            lifeBonus: 7,
            rarity: ItemRarityID.LightPurple,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.CrystalShard, 50},
                        {ItemID.PearlstoneBlock, 50}
                    },
                    CraftingTiles = {
                        TileID.MythrilAnvil
                    }
                }
            }
        ) { }
    }
}
