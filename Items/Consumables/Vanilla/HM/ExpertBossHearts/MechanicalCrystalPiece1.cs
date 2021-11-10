using Terraria.ModLoader;

namespace ElementalHeartsRewrite.Items.Consumables.Vanilla.HM.ExpertBossHearts {
    class MechanicalCrystalPiece1 : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mechanical Crystal Piece 1");
        }

        public override void SetDefaults() {
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.rare = -12;
            item.value = 5000;
            item.expert = true;
        }
    }
}
