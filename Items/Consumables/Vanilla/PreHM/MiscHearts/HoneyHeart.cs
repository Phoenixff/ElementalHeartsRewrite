using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class HoneyHeart : BaseHeart {
        public HoneyHeart() : base(
            name: "Honey Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.HoneyBlock, 100}
                    },
                    CraftingTiles = {
                        TileID.HoneyDispenser
                    }
                }
            }
        ) { }
    }
}
