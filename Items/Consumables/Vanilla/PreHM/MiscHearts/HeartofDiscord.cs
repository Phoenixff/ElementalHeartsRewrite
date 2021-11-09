using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class HeartofDiscord : BaseHeart {
        public HeartofDiscord() : base(
            name: "Heart of Discord",
            lifeBonus: 6,
            rarity: ItemRarityID.Lime,
            recipeList: new List<Recipe>() {}
        ) { }
    }
}
