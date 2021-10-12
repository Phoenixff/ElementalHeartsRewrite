using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace ElementalHeartsRewrite
{
	public class ElementalHeartsRewrite : Mod {

        internal enum PacketType : byte {
            SyncPlayer
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI) {
            PacketType packetType = (PacketType)reader.ReadByte();
            ElementalHeartsRewritePlayer sender = Main.player[(byte)reader.ReadByte()].GetModPlayer<ElementalHeartsRewritePlayer>();

            switch (packetType) {
                case PacketType.SyncPlayer: {
                    int heartsUsedCount = reader.ReadInt32();
                    Logger.Info(heartsUsedCount.ToString());
                    for (int i = 0; i < heartsUsedCount; i++) {
                        string key = reader.ReadString();
                        if (sender.usedHearts.ContainsKey(key)) {
                            sender.usedHearts.Add(key, reader.ReadInt32());
                        }
                    }
                    break;
                }
                default:
                    break;
            }

            //Logger.Info("TEST TEST TEST");
            //int heartNumber = reader.ReadInt32();
            //Logger.Info(heartNumber.ToString());
        }
    }
}