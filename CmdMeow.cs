// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║


using System;
using System.Text;
using MCGalaxy;
using MCGalaxy.Tasks;
using MCGalaxy.Util;

namespace MCGalaxy.Commands.Fun
{
    public class CmdMeow : Command
    {
        public override string name { get { return "Meow"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "fun"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
        
        static DateTime nextUse;
        
        public override void Use(Player p, string message)
        {
        {
			TimeSpan delta = nextUse - DateTime.UtcNow;
			if (delta.TotalSeconds > 0)
			{
				p.Message("&cYou have to wait another &b{0} &cseconds before using this command again.",
									   (int)Math.Ceiling(delta.TotalSeconds));
				return;
			}
			nextUse = DateTime.UtcNow.AddSeconds(5);
            }

            if (p.muted)
            {
                p.Message("%cYou cannot use this command while your muted.");
                return;
            }
            else if (message == "")
            { 
            Chat.MessageFrom(p, $"{p.ColoredName}%6 MEOWED %elike a cat!"); 
            }
        }
        public override void Help(Player p)
        {
            p.Message("&T/Meow");
            p.Message("&T/Meow - Makes you Meow like a cat");
        }
    }
}
