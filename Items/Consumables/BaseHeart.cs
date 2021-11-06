using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace ElementalHeartsRewrite.Items.Consumables {
    public class BaseHeart : ModItem {

        public string name;
        public string internalName;
        public int lifeBonus;
        public int rarity;
        public Dictionary<int, int> ingredients;
        public List<int> craftingTiles;
        public bool expert;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the heart that will be displayed to players</param>
        /// <param name="internalName">Name of the heart that will be used for saving or in dictionaries</param>
        /// <param name="lifeBonus">The amount of bonus HP granted by this heart</param>
        /// <param name="rarity">(ItemRarityID Useable here) Determines the color of the hearts name</param>
        /// <param name="ingredients">A dictionary of items (ItemID useable) and their amounts</param>
        /// <param name="craftingTiles">A list of tiles (TileID useable) required for crafting</param>
        public BaseHeart(string name, string internalName, int lifeBonus, int rarity, Dictionary<int, int> ingredients, List<int> craftingTiles, bool expert = false) {
            this.name = name;
            this.internalName = internalName;
            this.lifeBonus = lifeBonus;
            this.rarity = rarity;
            this.ingredients = ingredients;
            this.craftingTiles = craftingTiles;
            this.expert = expert;
        }

        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Permanently increases maximum life by " + lifeBonus);
            DisplayName.SetDefault(name);
        }

        public override void SetDefaults() {
            item.CloneDefaults(ItemID.LifeFruit);
            item.rare = rarity;
            item.value = 0;
            item.expert = expert;
        }

        public override bool CanUseItem(Player player) {
            mod.Logger.Info(this);
            return
                !player.GetModPlayer<ElementalHeartsRewritePlayer>().usedHearts.ContainsKey(this.internalName);
        }

        public override bool UseItem(Player player) {
            player.statLifeMax2 += lifeBonus;
            player.statLife += lifeBonus;
            if (Main.myPlayer == player.whoAmI) {
                player.HealEffect(lifeBonus, true);
            }
            player.GetModPlayer<ElementalHeartsRewritePlayer>().usedHearts.Add(this.internalName, this.lifeBonus);
            return true;
        }

        //This Method is only really usefull if you want to add a single recipe
        //I might have to figure out a way 
        public override void AddRecipes() {
            bool hasItems = ingredients.AsEnumerable().Any();
            bool hasTiles = craftingTiles.AsEnumerable().Any();
            if (hasItems && hasTiles) {
                ModRecipe recipe = new ModRecipe(mod);
                foreach (KeyValuePair<int, int> ingredient in ingredients) {
                    recipe.AddIngredient(ingredient.Key, ingredient.Value); //Key is the ID of the Item from the ItemID Enumerable, Value is the amount of required items
                }
                foreach (int craftingTile in craftingTiles) {
                    recipe.AddTile(craftingTile);
                }
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }
}
