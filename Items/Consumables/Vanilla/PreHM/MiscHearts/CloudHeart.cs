using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class CloudHeart : BaseHeart {
        public CloudHeart() : base(
            name: "Cloud Heart",
            internalName: "cloudHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            expert: false,
            recipeList: new List<Recipe>() { 
                new Recipe() {
                    Ingredients = {
                        {ItemID.Cloud, 100}
                    },
                    CraftingTiles = {
                        TileID.SkyMill
                    }
                }
            }
        ) { }
    }
}
