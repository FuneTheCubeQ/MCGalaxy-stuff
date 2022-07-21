using MCGalaxy.Commands.Chatting;
using System;
using System.Threading;

namespace MCGalaxy
{
	public class CmdQuack : MessageCmd
	{
		public override string name { get { return "Quack"; } }
		public override string shortcut { get { return ""; } }
		public override string type { get { return "moderation"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
		public override void Use(Player p, string message)
		{
			if (!CanSpeak(p, message))
            		{
				return;
			}

            		{

				Chat.MessageChat(ChatScope.Global, p, p.ColoredName + " %jQUACKED %zlike a duck!", null, null);
			}
		}

		public override void Help(Player p)
		{
			p.Message("/Quack - Quack like a duck.");
		}
	}
}
