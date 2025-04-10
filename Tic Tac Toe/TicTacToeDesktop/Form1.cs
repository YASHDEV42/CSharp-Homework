using System;
using System.Windows.Forms;

namespace TicTacToeDesktop
{
    public partial class Form1 : Form
    {
        private char currentPlayer = 'X'; // Start with player X
        private char[] board = new char[9]; // 3x3 board (1D array)

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        // Initialize the game board and UI
        private void InitializeGame()
        {
            currentPlayer = 'X';
            Array.Fill(board, ' '); // Clear the board array
            lblStatus.Text = "Player X's Turn";

            // Enable and clear all buttons
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Name.StartsWith("btn"))
                {
                    button.Text = "";  // Clear text
                    button.Enabled = true;  // Enable button
                }
            }
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null) return;

            int index = int.Parse(clickedButton.Name.Substring(3)) - 1;

            if (board[index] == ' ')
            {
                board[index] = currentPlayer;
                clickedButton.Text = currentPlayer.ToString();
                clickedButton.ForeColor = System.Drawing.Color.Black; // Ensure text is visible
                clickedButton.Refresh(); // Force UI update

                if (CheckForWinner())
                {
                    lblStatus.Text = $"Player {currentPlayer} wins!";
                    DisableAllButtons();
                }
                else if (IsBoardFull())
                {
                    lblStatus.Text = "It's a draw!";
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    lblStatus.Text = $"Player {currentPlayer}'s Turn";
                }
            }
        }


        // Check if there's a winner
        private bool CheckForWinner()
        {
            int[,] winConditions = {
        { 0, 1, 2 }, // Row 1
        { 3, 4, 5 }, // Row 2
        { 6, 7, 8 }, // Row 3
        { 0, 3, 6 }, // Column 1
        { 1, 4, 7 }, // Column 2
        { 2, 5, 8 }, // Column 3
        { 0, 4, 8 }, // Diagonal 1
        { 2, 4, 6 }  // Diagonal 2
    };

            // Iterate over each row in the winConditions array
            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                int a = winConditions[i, 0]; // First index in the row
                int b = winConditions[i, 1]; // Second index in the row
                int c = winConditions[i, 2]; // Third index in the row

                // Check if the board has the same symbol in all three positions
                if (board[a] != ' ' && board[a] == board[b] && board[b] == board[c])
                {
                    return true; // A winner is found
                }
            }

            return false; // No winner yet
        }

        // Check if the board is full (draw condition)
        private bool IsBoardFull()
        {
            foreach (char cell in board)
            {
                if (cell == ' ') return false;
            }
            return true;
        }

        // Disable all buttons after the game ends
        private void DisableAllButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Name.StartsWith("btn"))
                {
                    button.Enabled = false;
                }
            }
        }

        // Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        // Event handlers for each button
        private void btn1_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn2_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn3_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn4_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn5_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn6_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn7_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn8_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
        private void btn9_Click(object sender, EventArgs e) => BoardButton_Click(sender, e);
    }
}