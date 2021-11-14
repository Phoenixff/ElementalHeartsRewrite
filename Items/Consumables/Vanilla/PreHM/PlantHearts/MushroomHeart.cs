using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.PlantHearts {
    class MushroomHeart : BaseHeart {
        public MushroomHeart() : base(
            name: "Mushroom Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Mushroom, 50},
                        {ItemID.GlowingMushroom, 50}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) { }
    }
}
