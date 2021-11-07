using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.ExpertBossHearts {
    class DemonHeartMK2 : BaseHeart {
        public DemonHeartMK2() : base(
            name: "Demon Heart MK2",
            lifeBonus: 10,
            expert: true,
            rarity: ItemRarityID.Expert,
            recipeList: new List<Recipe>() {}
        ) { }
    }
}
