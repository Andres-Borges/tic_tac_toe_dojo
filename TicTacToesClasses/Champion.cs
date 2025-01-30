using System.Drawing;

namespace TicTacToesClasses
{
    public class Champion
    {
        //Attributes
        public string? Name { get; set; }
        public int? Lives { get; set; }
        public Image? Image { get; set; }
        public Image? Heart { get; set; }
        public Color ColorScheme { get; set; }
        public Point Location { get; set; }

        //Constructors
        public Champion() { } //Empty constructor
        public Champion(string name, Image image, Image heart, Color color, Point location)
        {
            Name = name;
            Lives = 2;
            Image = image;
            Heart = heart;
            ColorScheme = color;
            Location = location;
        }
    }
}