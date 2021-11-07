using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRewrite
{
	public class ElementalHeartsRewrite : Mod {



        internal enum PacketType : byte {
            SyncPlayer
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI) {
            int readOperations = 0;

            PacketType packetType = (PacketType)reader.ReadByte();
            readOperations++;
            byte playernumber = reader.ReadByte();
            readOperations++;
            ElementalHeartsRewritePlayer sentPlayer = Main.player[playernumber].GetModPlayer<ElementalHeartsRewritePlayer>();

            switch (packetType) {
                case PacketType.SyncPlayer: {
                    int heartsUsedCount = reader.ReadInt32();
                    Logger.Debug("Hearts used:" + heartsUsedCount);
                    readOperations++;
                    for (int i = 0; i < heartsUsedCount; i++) {
                        string key = reader.ReadString();
                        readOperations++;
                        int value = reader.ReadInt32();
                        readOperations++;
                        if (sentPlayer.usedHearts.ContainsKey(key)) {
                            sentPlayer.usedHearts.Add(key, value);
                        }
                    }
                    Logger.Debug("Times data was read from the packet: " + readOperations);
                    break;
                }
                default:
                    break;
            }
        }

        public override void AddRecipes() {
            base.AddRecipes();
            ModRecipe recipe;

            //Candy Cane Blocks for the Candy Cane Heart
            //TODO: Put a better recipe for Candy Canes here (Maybe ice or snow combined with dyes?)
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Pumpkin, 5);
            recipe.AddIngredient(ItemID.Cactus, 5);
            recipe.AddIngredient(ItemID.Hay, 5);
            recipe.AddIngredient(ItemID.GlowingMushroom, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CandyCaneBlock, 20);
            recipe.AddRecipe();

            //CheckThis: should we add a recipe for Coralstone? its only craftable in 1.4
            
        }
    }
}

//TODO: (Optional) Add these Tasks to your Visual Studio
/*
 * You can add tasks under Tools -> Options -> Environment -> Task List 
 * (dont add the - in front of their name. im just using that here so the definitions dont show up in the task list)
 * 
 * (When adding a Task that you want feedback on add your discord name as well so we can come back to you about it)
 * 
 * -CheckThis
 * Use this if youre not sure about what you added and want someone elses opinion on it
 * 
 * -Suggestion
 * Use this if you want to suggest a way to do something better
 * 
 * -Bug
 * Use this for known bugs that you dont know how to fix yourself
 * 
 * -TestThis
 * Use this for things that you think might cause bugs or after fixing a bug
 * 
*/