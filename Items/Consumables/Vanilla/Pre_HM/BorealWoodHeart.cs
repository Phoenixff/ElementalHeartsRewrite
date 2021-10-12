using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.Pre_HM {
    class BorealWoodHeart : BaseHeart {
        public BorealWoodHeart() : base(
            name: "Boreal Wood Heart",
            internalName: "borealWoodHeart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            ingredients: new Dictionary<int, int>() {
                {ItemID.BorealWood, 100}
            },
            craftingTiles: new List<int>() {
                {TileID.WorkBenches}
            }
        ) {}
    }
}
