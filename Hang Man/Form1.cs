
namespace HangMan
{
    public partial class Form1 : Form
    {
        #region Vars
        List<string> words = new List<string>
        {
            "apple",
            "banana",
            "cherry",
            "date",
            "fig",
            "grape",
            "kiwi",
            "lemon",
            "mango",
            "nectarine"
        };
        int incorrectGuess;
        Random random;
        string selectedWord;
        char[] displayWord;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            incorrectGuess = 0;
            random = new Random();
            selectedWord = words[random.Next(0, words.Count)];
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            string formattedDisplayWord = string.Join(" ", displayWord);
            lblWordDisplay.Text = formattedDisplayWord;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your event handler code here
        }

        private void tbGame_Click(object sender, EventArgs e)
        {
            char guess = tbGuess.Text.ToLower()[0];
            bool correctGuess = false;
            tbGuess.Clear();

            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    displayWord[i] = guess;
                    correctGuess = true;
                }
            }

            lblWordDisplay.Text = string.Join(" ", displayWord);
            if (!correctGuess)
            {
                updateHangmanImage();
            }
            if (!lblWordDisplay.Text.Contains("_"))
            {
                MessageBox.Show("You win!");
                Application.Restart();
            }
            else if (incorrectGuess >= 6)
            {
                MessageBox.Show("You lose! The word was: " + selectedWord);
                Form1_Load(sender, e);
            }

        }

        private void updateHangmanImage()
        {
            incorrectGuess++;
            switch (incorrectGuess)
            {
                case 1:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-1");
                    break;
                case 2:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-2");
                    break;
                case 3:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-3");
                    break;
                case 4:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-4");
                    break;
                case 5:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-5");
                    break;
                case 6:
                    panel1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("hangman-6");
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
