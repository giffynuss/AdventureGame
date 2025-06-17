using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Game
    {
        private static Game _gameInstance = new();
        public static Game GameInstance { get { return _gameInstance; } }
        public List<Room> Roomlist { get; set; } = new List<Room>();
        public List<Character> Characterlist { get; set; } = new List<Character>();

        public void IntroduceGame() {
            Console.WriteLine("Welcome to the Dungeon Adventure!");
            Console.WriteLine("Whohohoohoohohohoh  [¬º-°]¬ [¬º-°]¬ [¬º-°]¬ [¬º-°]¬");
            //Console.WriteLine("""
            //           (\__/)
            //           (•ㅅ•)      Don’t talk to
            //        ＿ノヽ ノ＼＿      me or my son
            //    `/　`/ ⌒Ｙ⌒ Ｙ  ヽ     ever again.
            //    ( 　(三ヽ人　 /　  |
            //    |　ﾉ⌒＼ ￣￣ヽ   ノ
            //    ヽ＿＿＿＞､＿_／
            //           ｜( 王 ﾉ〈 (\__/)
            //           /ﾐ`ー―彡\  (•ㅅ•)
            //          / ╰    ╯ \ /    \>⠀⠀⠀⠀⠀
            //    """);
            Console.WriteLine("\nPress enter to start the game....");
            ConsoleKeyInfo input = Console.ReadKey();
            while (input.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n\nPress Enter to start the game u idiot....");
                input = Console.ReadKey();
            }
            if (input.Key == ConsoleKey.Enter)
            {
                Console.Write("starting");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".... ");
                }
                Console.Read();
                InitializeGame();
            }
        }

        public void InitializeGame()
        {
            
        }

        public void CloseGame()
        {
            Environment.Exit(0);
        }
    }  
}
