using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using static Terraria.ModLoader.ModContent;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.ExpertBossHearts {
    class MechanicalHeart : BaseHeart {
        public MechanicalHeart() : base(
            name: "Mechanical Heart",
            lifeBonus: 15, //CheckThis: increased from 10 to 15 since normal boss hearts give 5 and you fight 3 bosses for this one
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemType<MechanicalCrystalPiece1>(), 1},
                        {ItemType<MechanicalCrystalPiece2>(), 1},
                        {ItemType<MechanicalCrystalPiece3>(), 1}
                    },
                    CraftingTiles = {
                        TileID.TinkerersWorkbench
                    }
                }
            }
        ) { }
    }
}
