using System.Diagnostics;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public static string input = "X";

        bool turn = true;

        int[,] board =
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };

        int currentRow;
        int currentCol;
        int moves;



        public Form1()
        {
            InitializeComponent();
            gameStart();
        }

        public void when_clicked(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (turn)
                {
                    button.Text = "O";
                }
                else
                {
                    button.Text = "X";
                }
                turn = !turn;

                moves--;


                if (button == button1)
                {
                    board[0, 0] = turn ? 1 : 2;
                    currentRow = 0;
                    currentCol = 0;
                   
                }
                else if (button == button2)
                {
                    board[0, 1] = turn ? 1 : 2;
                    currentRow = 0;
                    currentCol = 1;

                }
                else if (button == button3)
                {
                    board[0, 2] = turn ? 1 : 2;
                    currentRow = 0;
                    currentCol = 2;
                }
                else if (button == button4)
                {
                    board[1, 0] = turn ? 1 : 2;
                    currentRow = 1;
                    currentCol = 0;
                }
                else if (button == button5)
                {
                    board[1, 1] = turn ? 1 : 2;
                    currentRow = 1;
                    currentCol = 1;
                }
                else if (button == button6)
                {
                    board[1, 2] = turn ? 1 : 2;
                    currentRow = 1;
                    currentCol = 2;
                }
                else if (button == button7)
                {
                    board[2, 0] = turn ? 1 : 2;
                    currentRow = 2;
                    currentCol = 0;
                }
                else if (button == button8)
                {
                    board[2, 1] = turn ? 1 : 2;
                    currentRow = 2;
                    currentCol = 1;
                }
                else if (button == button9)
                {
                    board[2, 2] = turn ? 1 : 2;
                    currentRow = 2;
                    currentCol = 2;
                }
//                Debug.WriteLine(currentRow + ", " + currentCol);
 //               Debug.WriteLine(board[currentRow, currentCol]);

                check_win(currentRow, currentCol);
            }
        }

        public void check_win(int row, int col)
        {
            // Check for 3 in a row
            for (int i = 0; i < board.GetLength(0); i++)
            {

                if (board[row, i] == board[currentRow, currentCol])
                {
                    if (i == board.GetLength(0) - 1)
                    {
                        if (board[currentRow, currentCol] == 1)
                        {
                            label.Text = "X wins! Press any button to continue";
                        }
                        else if (board[currentRow, currentCol] == 2)
                        {
                            label.Text = "O wins! Press any button to continue";
                        }
                        Debug.WriteLine("3 in a row");
                        gameOver();
                    }
                }
                else
                {
                    break;
                }
            }

            // Check for 3 in a column
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[i, col] == board[currentRow, currentCol])
                {
                    if (i == board.GetLength(1) - 1)
                    {
                        if (board[currentRow, currentCol] == 1)
                        {
                            label.Text = "X wins! Press any button to continue";
                        }
                        else if (board[currentRow, currentCol] == 2)
                        {
                            label.Text = "O wins! Press any button to continue";
                        }
                        //Debug.WriteLine("3 in a column");
                        gameOver();
                    }
                }
                else
                {
                    break;
                }
            }

            // Check for 3 in a diagonal
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                {
                if (board[currentRow, currentCol] == 1)
                {
                    label.Text = "X wins! Press any button to continue";
                }
                else if (board[currentRow, currentCol] == 2)
                {
                    label.Text = "O wins! Press any button to continue";
                }
                //Debug.WriteLine("3 in a diagonal");
                gameOver();
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
            {
                if (board[currentRow, currentCol] == 1)
                {
                    label.Text = "X wins! Press any button to continue";
                }
                else if (board[currentRow, currentCol] == 2)
                {
                    label.Text = "O wins! Press any button to continue";
                }
                //Debug.WriteLine("3 in a diagonal");
                gameOver();
            }

            //Check for tie
            if (moves == 0)
            {
                label.Text = "Tie! Press any button to continue";
                gameOver();
            }



        }

        public void gameStart()
        {
            moves = board.GetLength(0) * board.GetLength(1);
            
            label.Text = "Playing";
            button1.Click -= reset;
            button2.Click -= reset;
            button3.Click -= reset;
            button4.Click -= reset;
            button5.Click -= reset;
            button6.Click -= reset;
            button7.Click -= reset;
            button8.Click -= reset;
            button9.Click -= reset;

            button1.Click += when_clicked;
            button2.Click += when_clicked;
            button3.Click += when_clicked;
            button4.Click += when_clicked;
            button5.Click += when_clicked;
            button6.Click += when_clicked;
            button7.Click += when_clicked;
            button8.Click += when_clicked;
            button9.Click += when_clicked;
        }
        public void gameOver()
        {

            button1.Click -= when_clicked;
            button2.Click -= when_clicked;
            button3.Click -= when_clicked;
            button4.Click -= when_clicked;
            button5.Click -= when_clicked;
            button6.Click -= when_clicked;
            button7.Click -= when_clicked;
            button8.Click -= when_clicked;
            button9.Click -= when_clicked;

            button1.Click += reset;
            button2.Click += reset;
            button3.Click += reset;
            button4.Click += reset;
            button5.Click += reset;
            button6.Click += reset;
            button7.Click += reset;
            button8.Click += reset;
            button9.Click += reset;
        }

        public void reset(object? sender, EventArgs e)
        {
            
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 0;
                }
            }
            turn = true;
            gameStart();
        }
    }
}
