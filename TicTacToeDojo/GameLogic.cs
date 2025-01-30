using TicTacToeDojo.Properties;
using TicTacToesClasses;

namespace TicTacToeDojo
{
    public class GameLogic
    {
        public List<Champion> CreateChampions()
        {
            List<Champion> champions = new List<Champion>();

            //Create champions
            champions.Add(new Champion("Sakura", Resources.Sakura_Foe, Resources.Sakura_Heart, Color.DeepPink, new Point(600, 0)));
            champions.Add(new Champion("Blaze", Resources.Blaze_Foe, Resources.Blaze_Heart, Color.Red, new Point(600, 0)));
            champions.Add(new Champion("Aurora", Resources.Aurora_Foe, Resources.Aurora_Heart, Color.DarkGoldenrod, new Point(600, 0)));
            champions.Add(new Champion("Jade", Resources.Jade_Foe, Resources.Jade_Heart, Color.Green, new Point(600, 0)));

            return champions;
        }

        public Player CreatePlayer(List<Champion> champions, string playerName)
        {
            Player player = new Player();

            foreach (Champion c in champions.ToList())
            {
                if (c.Name == playerName)
                {
                    Image pic = Resources.scroll;
                    Image heart = Resources.scroll;
                    switch (c.Name)
                    {
                        case "Sakura":
                            pic = Resources.Sakura_Player;
                            heart = Resources.Sakura_Heart;
                            break;
                        case "Blaze":
                            pic = Resources.Blaze_Player;
                            heart = Resources.Blaze_Heart;
                            break;
                        case "Aurora":
                            pic = Resources.Aurora_Player;
                            heart = Resources.Aurora_Heart;
                            break;
                        case "Jade":
                            pic = Resources.Jade_Player;
                            heart = Resources.Jade_Heart;
                            break;
                    }

                    player = new Player(c.Name, pic, heart, c.ColorScheme, new Point(0, 0));
                    champions.Remove(c);
                }
            }

            return player;
        }
    }
}