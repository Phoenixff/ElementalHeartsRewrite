using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class IceHeart : BaseHeart {
        public IceHeart() : base(
            name: "Ice Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.IceBlock, 100}
                    },
                    CraftingTiles = {
                        TileID.IceMachine
                    }
                }
            }
        ) { }
    }
}
