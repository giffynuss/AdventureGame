using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading;


namespace AdventureGame
{
    public class Game
    {
        private static Game _gameInstance = new();
        public static Game GameInstance { get { return _gameInstance; } }
        public List<Room> Roomlist { get; set; } = new List<Room>();
        public List<Character> Characterlist { get; set; } = new List<Character>();

        public void InitializeGame() {
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to the Dungeon Adventure!");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Console.WriteLine("Whohohoohoohohohoh  [¬º-°]¬ [¬º-°]¬ [¬º-°]¬ [¬º-°]¬");
            Thread.Sleep(1000);
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
                Console.WriteLine("\n\nPress enter to start the game u idiot....");
                input = Console.ReadKey();
            }
            if (input.Key == ConsoleKey.Enter)
            {
                Console.Write("starting");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".... ");
                    Thread.Sleep(1000);
                }
                CreateGame();
            }
        }

        public void CreateGame()
        {
            Game.GameInstance.Characterlist.Add(new Player("Player1"));
            Game.GameInstance.Roomlist.Add(new Room(new Item(),new Monster("Michel1")));
            Game.GameInstance.Roomlist.Add(new Room(new Item(), new Monster("Michel2")));
            Game.GameInstance.Roomlist.Add(new Room(new Item(), new Monster("Lisa Lappe")));
            DungeonDive();
        }


        public void DungeonDive()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Console.WriteLine("\nYou entered the dungeon!");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            while (true)
            {
                foreach (Room room in Roomlist)
                {
                    Console.WriteLine($"You are in the {room.Name} ..... {room.Description}\n");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Console.WriteLine($"You cann see an Item: {room.Item.Name} and a Monster: {room.Monster.Name}");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    bool inputvalid = false;
                    while (!inputvalid)
                    {
                        Console.WriteLine("\nWhat do you want to do? \n[0] fight\n[1] use item\n[2] run ");
                        String input2 = Console.ReadLine();
                        Player player = Game.GameInstance.Characterlist[0] as Player;
                        if (input2 == "0")
                        {
                            Console.WriteLine(room.Monster.ToString());
                            DungeonFight(Game.GameInstance.Characterlist[0] as Player, room.Monster);
                            inputvalid = true;
                        }else 
                        if (input2 == "1")
                        {
                            player.UseItem();
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);
                            Console.WriteLine("The monster is attacking you ! ! !");
                            DungeonFight(Game.GameInstance.Characterlist[0] as Player, room.Monster);
                            inputvalid = true;
                        }
                        else
                        if (input2 == "2")
                        {
                            Console.WriteLine("\nYou ran away from the monster and left the room.\n");
                            player.Health -= 20;
                            Thread.Sleep(1000);
                            Console.WriteLine($"You have lost 20 HP ... current HP:{player.Health}");
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);
                            inputvalid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);
                        }
                    }
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nYou see a closed door. Press Enter to enter . . .");
                    Console.ReadLine();
                    Console.WriteLine("You enter the next room . . .\n");
                }
                Console.WriteLine("You have cleared the dungeon! Congratulations, you have earned your Gulasch!🍜");
                Thread.Sleep(10000);
                CloseGame();
            }

        }

        public void DungeonFight(Player player, Monster monster)
        {
            while (true)
            {
                player.attackMagic(monster);
                Console.WriteLine($"You hurt the monster badly ... current HP:{monster.Health}\n");
                Thread.Sleep(1000);
                Thread.Sleep(1000);
                if (monster.Health <= 0)
                {
                    Console.WriteLine("The monster lost it's head");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    monster.attackPhysical(player);
                    Console.WriteLine($"The player got attacked by the monster and is bleeding... current HP: {player.Health}\n");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("The player lost his head and died. Game over!");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Dead();
                    return;
                }
                else
                {
                    Console.WriteLine("The player is still alive and can continue fighting.\n");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                }
            }
        }

        public void CloseGame()
        {
            Console.WriteLine("\nWanna play again?");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Console.WriteLine("Press Enter to restart the game or any other key to exit.");
            Console.WriteLine("");
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                InitializeGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                Thread.Sleep(10000);
                Environment.Exit(0);
            }
        }

        public void Dead()
        {
            Console.WriteLine("HAASHAHHAAHAHAHA YOUU DIED!!!!");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            CloseGame();
        }
    }  
}
