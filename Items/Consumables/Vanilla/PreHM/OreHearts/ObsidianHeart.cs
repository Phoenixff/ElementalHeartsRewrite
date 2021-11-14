using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class ObsidianHeart : BaseHeart {
        public ObsidianHeart() : base(
            name: "Obsidian Heart",
            lifeBonus: 3,
            rarity: ItemRarityID.Green,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Obsidian, 100}
                    },
                    CraftingTiles = {
                        TileID.Hellforge
                    }
                }
            }
        ) { }
    }
}
