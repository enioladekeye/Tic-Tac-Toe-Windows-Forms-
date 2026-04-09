using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public static string input = "X";

        bool turn = true;

        int[,] playfield =
        { 
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0} 
        };
        

        public Form1()
        {
            InitializeComponent();
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

        public void when_clicked(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (turn)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
                turn = !turn;
            }
        }
            
        public void check_win ()
        {

        }

        }

    }
