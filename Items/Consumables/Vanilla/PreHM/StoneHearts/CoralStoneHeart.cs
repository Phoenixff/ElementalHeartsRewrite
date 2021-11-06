using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.StoneHearts {
    class CoralStoneHeart : BaseHeart {
        public CoralStoneHeart() : base(
            name: "Coralstone Heart",
            internalName: "coralStoneHeart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            expert: false,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.CoralstoneBlock, 100}
                    },
                    CraftingTiles = {}
                }
            }
        ) { }
    }
}
