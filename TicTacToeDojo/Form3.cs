using TicTacToesClasses;
using TicTacToeDojo.Properties;
namespace TicTacToeDojo
{
    //Form3 = Game
    public partial class Form3 : Form
    {
        public List<Champion> champions;
        public Player? _player;
        private readonly string _selectedName;

        public enum Piece
        {
            X, O
        }

        public Piece currentPlayer;
        public Color currentPlayerColor;
        public Random rand = new Random();
        public List<Button> buttons;
        public string picFoeName;
        public bool gameEnd = false;

        private readonly GameLogic _gameLogic = new GameLogic();

        public Form3(string name)
        {
            _selectedName = name;
            champions = new List<Champion>();

            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //CreateChampions();

            champions = _gameLogic.CreateChampions();
            _player = _gameLogic.CreatePlayer(champions, _selectedName);

            //Displays champions on the form
            PrintChampion(_player);
            PrintChampion(champions[0]);

            //Change the hearts
            picPlayerHeart1.BackgroundImage = ChangeHeart(_player);
            picPlayerHeart2.BackgroundImage = ChangeHeart(_player);

            picFoeHeart1.BackgroundImage = ChangeHeart(champions[0]);
            picFoeHeart2.BackgroundImage = ChangeHeart(champions[0]);

            StartNewRound();

            lblTurn.Text = "Your Turn";
            lblTurn.ForeColor = _player.ColorScheme;

            currentPlayerColor = champions[0].ColorScheme;
        }

        //Makes the Button Fore Color stay the same even when disabled
        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;

            //Only if the button is disabled
            if (!button.Enabled)
            {
                using (Brush textBrush = new SolidBrush(currentPlayerColor))
                {
                    //Center text
                    TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                    //Print Text
                    TextRenderer.DrawText(e.Graphics, button.Text, button.Font, e.ClipRectangle, currentPlayerColor, flags);
                }
            }
        }

        public void PrintChampion(Champion c)
        {
            //Creates the picture box
            PictureBox pic = new PictureBox();
            pic.Name = "pic" + c.Name;
            pic.Image = c.Image;
            pic.Location = c.Location;
            pic.Size = new Size(244, 440);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Visible = true;
            pic.BackColor = Color.Transparent;

            //Adds to the form
            this.Controls.Add(pic);
        }

        public Image ChangeHeart(Champion c)
        {
            return c.Heart;
        }

        //Tic Tac Toe Logic
        private void Player_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            lblTurn.Text = $"{champions[0].Name}'s Turn";
            lblTurn.ForeColor = currentPlayerColor;

            currentPlayer = Piece.X;
            currentPlayerColor = _player.ColorScheme;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;

            buttons.Remove(button);
            CheckGame();
            if (champions.Count > 0)
            {
                botTimer.Start(); //If the game is not won, the bot goes
            }
        }

        private void Bot_Move(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                currentPlayer = Piece.O;
                currentPlayerColor = champions[0].ColorScheme;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].Enabled = false;

                buttons.RemoveAt(index);
                CheckGame();
                botTimer.Stop();

                lblTurn.Text = "Your Turn";
                lblTurn.ForeColor = _player.ColorScheme;
            }
        }

        public void StartNewRound()
        {
            buttons = new List<Button> { btnA1, btnA2, btnA3, btnB1, btnB2, btnB3, btnC1, btnC2, btnC3 };

            foreach (Button b in buttons)
            {
                b.Enabled = true;
                b.Text = string.Empty;
                b.ForeColor = Color.Black;
            }

            lblScore.Text = $"Score: {_player.Score.ToString()}";
        }

        //Tic Tac Toe Logic
        private bool CheckWin()
        {
            //If someone wins
            if (btnA1.Text == currentPlayer.ToString() && btnA2.Text == currentPlayer.ToString() && btnA3.Text == currentPlayer.ToString() ||
                btnB1.Text == currentPlayer.ToString() && btnB2.Text == currentPlayer.ToString() && btnB3.Text == currentPlayer.ToString() ||
                btnC1.Text == currentPlayer.ToString() && btnC2.Text == currentPlayer.ToString() && btnC3.Text == currentPlayer.ToString() ||
                btnA1.Text == currentPlayer.ToString() && btnB1.Text == currentPlayer.ToString() && btnC1.Text == currentPlayer.ToString() ||
                btnA2.Text == currentPlayer.ToString() && btnB2.Text == currentPlayer.ToString() && btnC2.Text == currentPlayer.ToString() ||
                btnA3.Text == currentPlayer.ToString() && btnB3.Text == currentPlayer.ToString() && btnC3.Text == currentPlayer.ToString() ||
                btnA1.Text == currentPlayer.ToString() && btnB2.Text == currentPlayer.ToString() && btnC3.Text == currentPlayer.ToString() ||
                btnA3.Text == currentPlayer.ToString() && btnB2.Text == currentPlayer.ToString() && btnC1.Text == currentPlayer.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckTie()
        {
            if (buttons.Count == 0)
            {
                _player.Score += 50;
                StartNewRound();
            }
        }

        private void CheckGame()
        {
            if (CheckWin())
            {
                botTimer.Stop();

                if (currentPlayer.ToString() == "X") //If the player won the round
                {
                    if (champions[0].Lives == 2)
                    {
                        champions[0].Lives--;
                        picFoeHeart1.BackgroundImage = Resources.Broken_Heart;
                        _player.Score += 100;
                    }
                    else
                    {
                        //The computer has been defeated
                        _player.Score += 150;
                        picFoeName = "pic" + champions[0].Name;
                        champions.RemoveAt(0);

                        PictureBox pic = (PictureBox)this.Controls.Find(picFoeName, true)[0];
                        this.Controls.Remove(pic);

                        if (champions.Count > 0)
                        {
                            //Print next champion
                            PrintChampion(champions[0]);
                            picFoeHeart1.BackgroundImage = ChangeHeart(champions[0]);
                            picFoeHeart2.BackgroundImage = ChangeHeart(champions[0]);

                            lblTurn.Text = $"{champions[0].Name}'s Turn";
                            lblTurn.ForeColor = champions[0].ColorScheme;
                        }
                        else
                        {
                            //Victory
                            gameEnd = true;
                            DisplayResults("You Won!");

                        }
                    }
                }
                else //If the computer won the round
                {
                    if (_player.Lives == 2)
                    {
                        _player.Lives--;
                        picPlayerHeart1.BackgroundImage = Resources.Broken_Heart;
                        _player.Score -= 50;
                    }
                    else
                    {
                        //Game Over
                        picFoeName = "pic" + champions[0].Name;
                        PictureBox pic = (PictureBox)this.Controls.Find(picFoeName, true)[0];
                        this.Controls.Remove(pic);

                        gameEnd = true;
                        DisplayResults("You have lost!");
                    }
                }

                if (!gameEnd)
                {
                    StartNewRound();
                }
            }
            else
            {
                CheckTie();
            }
        }

        //End Game Screen
        private void ClearScreen()
        {
            //Makes almost all elements of the screen not visible
            picFoeHeart1.Visible = false;
            picFoeHeart2.Visible = false;
            picPlayerHeart1.Visible = false;
            picPlayerHeart2.Visible = false;

            foreach (Button b in buttons)
            {
                b.Visible = false;
                b.Enabled = false;
            }

            lblScore.Text = string.Empty;
            lblTurn.Visible = false;
            picTurn.Visible = false;
        }

        private void DisplayResults(string result)
        {
            StartNewRound();
            ClearScreen();

            this.BackgroundImage = Resources.Background_Image;
            if (result == "You Won!")
            {
                lblEndResult.ForeColor = Color.Green;
            }
            else
            {
                lblEndResult.ForeColor = Color.Red;
            }

            lblEndResult.Text = result;
            lblEndScore.Text = "Final Score: " + _player.Score.ToString();

            lblEndScore.Visible = true;
            lblEndResult.Visible = true;

            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = true;
        }

        private void menuBtns_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.ForeColor = Color.Green;
        }

        private void menuBtns_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}