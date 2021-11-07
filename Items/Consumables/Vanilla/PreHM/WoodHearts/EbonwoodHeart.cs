using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.WoodHearts {
    class EbonwoodHeart : BaseHeart {
        public EbonwoodHeart() : base(
            name: "Ebonwood Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Ebonwood, 100}
                    },
                    CraftingTiles = {
                        TileID.WorkBenches
                    }
                }
            }
        ) { }
    }
}
