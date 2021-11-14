using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.OreHearts {
    class MythrilHeart : BaseHeart {
        public MythrilHeart() : base(
            name: "Mythril Heart",
            lifeBonus: 6,
            rarity: ItemRarityID.Pink,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.MythrilOre, 100}
                    },
                    CraftingTiles = {
                        TileID.MythrilAnvil
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.MythrilBar, 25}
                    },
                    CraftingTiles = {
                        TileID.MythrilAnvil
                    }
                }
            }
        ) { }
    }
}
