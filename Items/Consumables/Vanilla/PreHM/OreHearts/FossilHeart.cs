using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.OreHearts {
    class FossilHeart : BaseHeart {
        public FossilHeart() : base(
            name: "Fossil Heart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.DesertFossil, 100}
                    },
                    CraftingTiles = {
                        TileID.Extractinator
                    }
                }
            }
        ) { }
    }
}
