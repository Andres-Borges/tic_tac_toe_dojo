using TicTacToeDojo.Properties;
using TicTacToesClasses;

namespace TicTacToeDojo
{
    public partial class Form2 : Form
    {
        //Form2 = Select Champion Screen

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void selectBtns_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.FlatAppearance.MouseOverBackColor = Color.Transparent;

            Color color = Color.Black;
            switch (button.Text)
            {
                case "Sakura":
                    color = Color.DeepPink;
                    break;
                case "Blaze":
                    color = Color.Red;
                    break;
                case "Aurora":
                    color = Color.DarkGoldenrod;
                    break;
                case "Jade":
                    color = Color.Green;
                    break;
            }
            button.ForeColor = color;
        }

        private void selectBtns_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }

        private void selectBtns_Click(object sender, EventArgs e)
        {
            Button selectedChampion = (Button)sender;

            Form3 game = new Form3(selectedChampion.Text);
            game.Show();
            this.Hide();
        }
    }
}