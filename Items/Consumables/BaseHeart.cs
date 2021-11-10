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
        public List<Recipe> recipeList;
        public bool expert;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the heart that will be displayed to players</param>
        /// <param name="internalName">Name of the heart that will be used for saving or in dictionaries</param>
        /// <param name="lifeBonus">The amount of bonus HP granted by this heart</param>
        /// <param name="rarity">(ItemRarityID Useable here) Determines the color of the hearts name</param>
        /// <param name="recipeList">A list of Recipes for crafting</param>
        /// <param name="expert">Is the item an expert item?</param>
        public BaseHeart(string name, int lifeBonus, int rarity, List<Recipe> recipeList, bool expert = false) {
            this.name = name;
            this.internalName = this.GetType().Name; ;
            this.lifeBonus = lifeBonus;
            this.rarity = rarity;
            this.recipeList = recipeList;
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
            item.maxStack = 1;
        }

        public override bool CanUseItem(Player player) {
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

        public override void AddRecipes() {
            foreach (Recipe recipe in recipeList) {
                Dictionary<int, int> ingredients = recipe.Ingredients;
                List<int> craftingTiles = recipe.CraftingTiles;

                bool hasItems = ingredients.AsEnumerable().Any();
                bool hasTiles = craftingTiles.AsEnumerable().Any();

                if (hasItems && hasTiles) {
                    ModRecipe newRecipe = new ModRecipe(mod);
                    foreach (KeyValuePair<int, int> ingredient in ingredients) {
                        newRecipe.AddIngredient(ingredient.Key, ingredient.Value); //Key is the ID of the Item from the ItemID Enumerable, Value is the amount of required items
                    }
                    foreach (int craftingTile in craftingTiles) {
                        newRecipe.AddTile(craftingTile);
                    }
                    newRecipe.needWater = recipe.NeedsWater;
                    newRecipe.SetResult(this, 1);
                    newRecipe.AddRecipe();
                }
            }
        }
    }

    public class Recipe {
        private Dictionary<int, int> ingredients = new Dictionary<int, int>();
        private List<int> craftingTiles = new List<int>();
        private bool needsWater = false;

        public Dictionary<int, int> Ingredients { get => this.ingredients; set => this.ingredients = value; }
        public List<int> CraftingTiles { get => this.craftingTiles; set => this.craftingTiles = value; }
        public bool NeedsWater { get => this.needsWater; set => this.needsWater = value; }
    }
}
