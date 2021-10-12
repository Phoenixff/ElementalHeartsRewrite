using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ElementalHeartsRewrite {
    class ElementalHeartsRewriteConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Elemental Hearts Setting")]

        [DefaultValue(true)]
        [ReloadRequired]
        [Label("Vanilla Changes")]
        public bool VanillaChangesConfig;
    }
}
