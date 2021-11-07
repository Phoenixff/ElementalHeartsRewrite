using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.GemHearts {
    class DiamondHeart : BaseHeart {
        public DiamondHeart() : base(
            name: "Diamond Heart",
            internalName: "diamondHeart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Diamond, 25},
                        {ItemID.StoneBlock, 75}
                    },
                    CraftingTiles = {
                        TileID.Extractinator
                    }
                }
            }
        ) { }
    }
}
