using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.DirtyHearts {
    class DirtHeart : BaseHeart {
        public DirtHeart() : base(
            name: "Dirt Heart",
            internalName: "dirtHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.DirtBlock, 100}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) { }
    }
}
