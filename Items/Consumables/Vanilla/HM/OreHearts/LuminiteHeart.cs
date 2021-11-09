using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.OreHearts {
    class LuminiteHeart : BaseHeart {
        public LuminiteHeart() : base(
            name: "Luminite Heart",
            lifeBonus: 9,
            rarity: ItemRarityID.Red,
            recipeList: new List<Recipe>() {
                new Recipe() {
                    Ingredients = {
                        {ItemID.LunarOre, 100},
                        {ItemID.FragmentSolar, 10},
                        {ItemID.FragmentNebula, 10},
                        {ItemID.FragmentVortex, 10},
                        {ItemID.FragmentStardust, 10}
                    },
                    CraftingTiles = {
                        TileID.LunarCraftingStation
                    }
                },
                new Recipe() {
                    Ingredients = {
                        {ItemID.LunarBar, 25},
                        {ItemID.FragmentSolar, 10},
                        {ItemID.FragmentNebula, 10},
                        {ItemID.FragmentVortex, 10},
                        {ItemID.FragmentStardust, 10}
                    },
                    CraftingTiles = {
                        TileID.LunarCraftingStation
                    }
                }
            }
        ) { }
    }
}
