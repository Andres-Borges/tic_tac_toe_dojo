using System.Net.NetworkInformation;
using TicTacToeDojo.Properties;

namespace TicTacToeDojo
{
    //Form1 = Menu

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form2 select = new Form2();
            select.Show();
            this.Hide();
        }

        private void menuBtns_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.ForeColor = Color.Red;
        }

        private void menuBtns_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            ChangeScreen(false);
            this.BackgroundImage = Resources.Tutorial_Page;
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            ChangeScreen(false);
            this.BackgroundImage = Resources.Contacts_Page;
        }

        private void ChangeScreen(bool change)
        {
            lblStudio.Visible = change;
            labelPresents.Visible = change;

            btnStart.Visible = change;
            btnStart.Enabled = change;

            btnTutorial.Visible = change;
            btnTutorial.Enabled = change;

            buttonContacts.Visible = change;
            buttonContacts.Enabled = change;

            pbLogo.Visible = change;

            btnBack.Visible = !change;
            btnBack.Enabled = !change;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChangeScreen(true);
            this.BackgroundImage = Resources.Background_Image;
        }
    }
}