namespace NumberGuessingWinFormsGame
{
    public partial class Form : System.Windows.Forms.Form
    {

        private int GameNum = -1;
        private string? GameDifficulty = null;
        public Form()
        {
            InitializeComponent();
        }

        private void GameOver(bool playerWin)
        {
            GuessBtn.Enabled = false;
            GuessTxtBox.Enabled = false;
            EasyButton.Enabled = true;
            MedButton.Enabled = true;
            HardButton.Enabled = true;
            StartBtn.Enabled = true;
        }

        private void GameSetup()
        {
            LBNResult.Text = "A number has been chosen";
            Random randy = new Random();
            if (EasyButton.Checked)
            {
                GameNum = randy.Next(25) + 1;
            }else if (MedButton.Checked)
            {
                GameNum = randy.Next(50) + 1;
            }else if (HardButton.Checked)
            {
                GameNum = randy.Next(100) + 1;
            }
            else
            {
                LBNResult.Text = "Please Choose a Difficulty\nBefore Starting the Game";
                return;
            }
            //GuessBtn.Enabled = true;
            GuessTxtBox.Enabled = true;
            EasyButton.Enabled = false;
            MedButton.Enabled = false;
            HardButton.Enabled = false;
            StartBtn.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuessTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            GameSetup();
        }

        private void GuessTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(GuessTxtBox.Text == "")
            {
                GuessBtn.Enabled = false;
            }
            else
            {
                GuessBtn.Enabled = true;
            }
        }
    }
}