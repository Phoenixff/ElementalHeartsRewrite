using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.OreHearts {
    class OrichalcumHeart : BaseHeart {
        public OrichalcumHeart() : base(
            name: "Orichalcum Heart",
            lifeBonus: 6,
            rarity: ItemRarityID.Pink,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.OrichalcumOre, 100}
                    },
                    CraftingTiles = {
                        TileID.MythrilAnvil
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.OrichalcumBar, 25}
                    },
                    CraftingTiles = {
                        TileID.MythrilAnvil
                    }
                }
            }
        ) { }
    }
}
