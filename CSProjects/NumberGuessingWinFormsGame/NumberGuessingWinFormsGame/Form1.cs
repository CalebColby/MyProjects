namespace NumberGuessingWinFormsGame
{
    public partial class Form : System.Windows.Forms.Form
    {

        private int GameNum = -1;
        private int GuessesLeft = -1;
        private int LargestPossible = -1;
        private Label[] GameLabels = new Label[5];
        private PictureBox[] Pics = new PictureBox[5];
        
        public Form()
        {
            InitializeComponent();
            GameLabels[0] = LBNgt1;
            GameLabels[1] = LBNgt2;
            GameLabels[2] = LBNgt3;
            GameLabels[3] = LBNgt4;
            GameLabels[4] = LBNgt5;
            Pics[0] = Pic1;
            Pics[1] = Pic2;
            Pics[2] = Pic3;
            Pics[3] = Pic4;
            Pics[4] = Pic5;
        }

        private void GameOver(bool playerWin)
        {
            if (playerWin)
            {
                LBNResult.Text = $"Congratulations, You correctly Guessed\nthe Number: {GameNum}";
            }
            else
            {
                LBNResult.Text = $"Apologies but you failed to guess\nthe number. It was {GameNum}";
            }
            GuessBtn.Enabled = false;
            GuessTxtBox.Enabled = false;
            EasyButton.Enabled = true;
            MedButton.Enabled = true;
            HardButton.Enabled = true;
            StartBtn.Enabled = true;
            GameNum = -1;
            GuessesLeft = -1; 
            LargestPossible = -1;
            
        }

        private void GameSetup()
        {
            LBNResult.Text = "A number has been chosen";
            Random randy = new Random();
            if (EasyButton.Checked)
            {
                GameNum = randy.Next(25) + 1;
                LargestPossible = 25;
            }else if (MedButton.Checked)
            {
                GameNum = randy.Next(50) + 1;
                LargestPossible = 50;
            }else if (HardButton.Checked)
            {
                GameNum = randy.Next(100) + 1;
                LargestPossible = 100;
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

            GuessesLeft = 5;

            for (int i = 0; i < GameLabels.Length; i++)
            {
                GameLabels[i].Text = "";
                Pics[i].Hide();
                Pics[i].Image = Properties.Resources.incorrect_icon;
            }
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

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            int Guess = int.Parse(GuessTxtBox.Text);
            GuessTxtBox.Text = "";

            if (Guess < 1 || Guess > LargestPossible)
            {
                LBNResult.Text = $"The Number You are trying to guess\nis between 1 and {LargestPossible}";
                return;
            }

            Pics[5 - GuessesLeft].Show();
            if (Guess == GameNum)
            {
                Pics[5 - GuessesLeft].Image = Properties.Resources.correct_icon;
                GameLabels[5 - GuessesLeft].Text = "You Are Right!!";
                GameOver(true);
                
            }else if(Guess > GameNum)
            {
                //Change Table Feilds to indicate the user guessed too high
                GameLabels[5 - GuessesLeft].Text = $"{Guess} is Too High";
                //Pics[5 - GuessesLeft].Image = ;
                LBNResult.Text = "Too High";
            }
            else
            {
                //Change Table Feilds to indicate the user guessed too low
                LBNResult.Text = "Too Low";
                GameLabels[5 - GuessesLeft].Text = $"{Guess} is Too Low";
            }
            
            //Pics[5 - GuessesLeft].Image = Properties.Resources.correct_icon;


            GuessesLeft--;
            if(GuessesLeft == 0)
            {
                GameOver(false);
            }
        }

        private void Pic1_Click(object sender, EventArgs e)
        {

        }
    }
}