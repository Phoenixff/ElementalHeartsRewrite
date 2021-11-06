using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.GemHearts {
    class AmethystHeart : BaseHeart {
        public AmethystHeart() : base(
            name: "Amethyst Heart",
            internalName: "amethystHeart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Amethyst, 25},
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
