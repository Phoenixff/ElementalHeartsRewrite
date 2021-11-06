using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static ElementalHeartsRewrite.ElementalHeartsRewrite;

namespace ElementalHeartsRewrite {
    public class ElementalHeartsRewritePlayer : ModPlayer {
        public Dictionary<string, int> usedHearts = new Dictionary<string, int>();

        public override void ResetEffects() {
            foreach (KeyValuePair<string, int> usedHeart in usedHearts) {
                player.statLifeMax2 += usedHeart.Value;
            }
        }

        public override void clientClone(ModPlayer clientClone) {
            ElementalHeartsRewritePlayer clone = clientClone as ElementalHeartsRewritePlayer;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
            int writeOperations = 0;
            ModPacket packet = mod.GetPacket();

            packet.Write((byte)PacketType.SyncPlayer);
            writeOperations++;
            packet.Write((byte)player.whoAmI);
            writeOperations++;
            packet.Write(usedHearts.Count); //sends the amount of hearts in the Dictionary to the server so it knows when it has to stop reading data as hearts
            writeOperations++;
            foreach (KeyValuePair<string, int> usedHeart in usedHearts) {
                packet.Write(usedHeart.Key);
                writeOperations++;
                packet.Write(usedHeart.Value);
                writeOperations++;
            }
            packet.Send(toWho, fromWho);
            mod.Logger.Debug(writeOperations);
        }

        public override TagCompound Save() {
            TagCompound tagCompound = new TagCompound();
            foreach (KeyValuePair<string, int> usedHeart in usedHearts) {
                tagCompound.Add(usedHeart.Key, usedHeart.Value);
            }

            return tagCompound;
        }

        public override void Load(TagCompound tag) {
            Dictionary<string, int> tags = tag.AsEnumerable().ToDictionary(x => x.Key, x => int.Parse(x.Value.ToString()));
            this.usedHearts = tags;
        }
    }
}
