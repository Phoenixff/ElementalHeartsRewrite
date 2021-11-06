using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.OreHearts {
    class ChlorophyteHeart : BaseHeart {
        public ChlorophyteHeart() : base(
            name: "Chlorophyte Heart",
            internalName: "chlorophyteHeart",
            lifeBonus: 8,
            rarity: ItemRarityID.Lime,
            expert: false,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.ChlorophyteOre, 100}
                    },
                    CraftingTiles = {
                        TileID.AdamantiteForge
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.ChlorophyteBar, 17}
                    },
                    CraftingTiles = {
                        TileID.AdamantiteForge
                    }
                }
            }
        ) 
        { }
    }
}
