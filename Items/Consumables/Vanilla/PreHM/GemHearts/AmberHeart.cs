using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.GemHearts {
    class AmberHeart : BaseHeart {
        public AmberHeart() : base(
            name: "Amber Heart",
            internalName: "amberHeart",
            lifeBonus: 5,
            rarity: ItemRarityID.LightRed,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Amber, 25},
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
