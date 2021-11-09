using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using Microsoft.Xna.Framework;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.PreHM.MiscHearts {
    //This heart is special enough that it gets its own code since it has to clear the data of all other hearts
    class EmptyHeart : ModItem {

        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Resets all HP bonuses given by other hearts from this mod!\nWill return all the used Hearts so prepare storage space for them!");
            DisplayName.SetDefault("Heart Emptier");
        }

        public override void SetDefaults() {
            item.CloneDefaults(ItemID.LifeFruit);
            item.rare = ItemRarityID.White;
            item.value = 0;
        }

        public override bool UseItem(Player player) {
            int takeHealth = 0;
            Dictionary<string, int> usedHearts = player.GetModPlayer<ElementalHeartsRewritePlayer>().usedHearts;

            foreach (KeyValuePair<string, int> heart in usedHearts) {
                ModItem heartItem = mod.GetItem(heart.Key);
                takeHealth += ((BaseHeart)heartItem).lifeBonus;
                player.QuickSpawnClonedItem(heartItem.item);
            }

            player.statLife -= takeHealth;
            player.GetModPlayer<ElementalHeartsRewritePlayer>().usedHearts = new Dictionary<string, int>();
            Main.NewText("Cleared Elemental Heart stats!", Color.Orange);

            return true;
        }
    }
}
