using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.MaterialHearts {
    class EctoplasmHeart : BaseHeart {

        public EctoplasmHeart() : base(
            name: "Ectoplasm Heart",
            lifeBonus: 8,
            rarity: ItemRarityID.Yellow,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.Ectoplasm, 100}
                    },
                    CraftingTiles = {
                        TileID.BoneWelder
                    }
        }
    }
        ) { }
    }
}
