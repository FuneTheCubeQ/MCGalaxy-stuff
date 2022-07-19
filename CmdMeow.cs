using MCGalaxy.Commands.Chatting;
using System;
using System.Threading;

namespace MCGalaxy
{
	public class CmdMeow : MessageCmd
	{
		public override string name { get { return "Meow"; } }
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
				string suffix = RandomMessage();
				Chat.MessageChat(ChatScope.Global, p, p.ColoredName + " &7Used /Meow " + suffix, null, null);
			}
		}

		public string RandomMessage()
		{
			Random random = new Random();
			int val = random.Next(11);

			switch(val)
           		{
				case 0:
					return "%dbut instead, Gekale typed %dMEOW!";
				case 1:
					return "%dand meowed!";
				case 2:
					return "%dbut went to New Blood and did /banall instead.";
				case 3:
					return "%dbut on the wrong server.";
				case 4:
					return "%dbut died before typing it.";
				case 5:
					return "%dbut forgot Gekale didn't finish the code.";
				case 6:
					return "%dbut it didn't work.";
				case 7:
					return "%dbut became a dog instead.";
				case 8:			  
					return "%dbut exploded.";
				case 9:
					return "%dbut quacked instead.";
				case 10:
					return "%dbut went to NA2 instead.";
				default:
					return "%dbut went to Shad's store instead.";

			}
		}

		public override void Help(Player p)
		{
			p.Message("/Meow - Meow like a cat.");
		}
	}
}
