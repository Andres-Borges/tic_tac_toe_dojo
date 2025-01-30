using System.Drawing;

namespace TicTacToesClasses
{
    public class Player : Champion
    {
        public int Score { get; set; }

        //Constructors
        public Player() { }
        public Player (string name, Image image, Image heart, Color color, Point location) : base (name, image, heart, color, location)
        {
            Score = 0;
        }
    }
}