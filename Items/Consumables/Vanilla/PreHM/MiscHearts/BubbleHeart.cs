using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    class BubbleHeart : BaseHeart {
        public BubbleHeart() : base(
            name: "Bubble Heart",
            internalName: "bubbleHeart",
            lifeBonus: 2,
            rarity: ItemRarityID.Blue,
            expert: false,
            recipeList: new List<Recipe>() { }
        ) { }
    }
}
