using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.Pre_HM {
    class WoodHeart : BaseHeart {
        public WoodHeart() : base(
            name: "Wood Heart",
            internalName: "woodHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            ingredients: new Dictionary<int, int>() {
                {ItemID.Wood, 100}
            },
            craftingTiles: new List<int>() {
                {TileID.WorkBenches}
            }
        ) {}
    }
}
