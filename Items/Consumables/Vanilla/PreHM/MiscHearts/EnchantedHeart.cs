using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class EnchantedHeart : BaseHeart {
        public EnchantedHeart() : base(
            name: " Heart",
            lifeBonus: 1,
            rarity: ItemRarityID.White,
            recipeList: new List<Recipe>() {}
        ) { }
    }
}
