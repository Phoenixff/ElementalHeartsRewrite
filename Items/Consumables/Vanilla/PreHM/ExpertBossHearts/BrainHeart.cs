using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.ExpertBossHearts {
    class BrainHeart : BaseHeart {
        public BrainHeart() : base(
            name: "Brain Heart",
            internalName: "brainHeart",
            lifeBonus: 5,
            rarity: ItemRarityID.Expert,
            expert: true,
            recipeList: new List<Recipe>() { }
        ) { }
    }
}
