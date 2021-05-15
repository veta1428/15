using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifteensWinForm
{
    public partial class Form1 : Form
    {
        Color backColor = Color.BlueViolet;
        Color foreColor = Color.White;

        Color[] colorsback = { Color.BlueViolet, Color.Red, Color.Yellow, Color.Green, Color.Magenta, Color.Blue, Color.Bisque };
        Color[] colorsfore = { Color.White, Color.White, Color.Black, Color.White, Color.White, Color.White, Color.Black };

        Numbers numbers = new Numbers();
        DateTime date = new DateTime();
        Timer me = new Timer();
        DateTime startTime = new DateTime();
        DateTime gameTime = new DateTime();
        public string playerName = null;
        int steps = 0;
        AskForm askNameForm;

        const int SIZE = 4;

        

        public Form1()
        {
            InitializeComponent();
            dataGrid.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            me.Tick += OhTick;
        }
        private void TimerNewGame()
        {
            me.Tick -= OhTick;
            me = new Timer();
            me.Enabled = true;
            me.Interval = 1000;
            me.Tick += OhTick;
            date = new DateTime(0, 0);
            ShowTime.Text = date.ToString("mm:ss");
        }
        private void ColorsNewGame()
        {
            Random rand = new Random();
            int number = rand.Next(0, colorsback.Length);
            backColor = colorsback[number];
            foreColor = colorsfore[number];
        }
        private void StartNewGame()
        {
            startTime = DateTime.Now;
            numbers = new Numbers();

            ColorsNewGame();
            ShowPosition();
            TimerNewGame();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.RowCount = SIZE;
            dataGrid.ColumnCount = SIZE;

            for (int i = 0; i < SIZE; i++)
            {
                dataGrid.Columns[i].Width = 80;
            }
            for (int i = 0; i < SIZE; i++)
            {
                dataGrid.Rows[i].Height = 80;
            }

            StartNewGame();
        }

        private void ShowPosition()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = numbers.table[i, j];
                    dataGrid.Rows[i].Cells[j].Style.BackColor = backColor;
                    dataGrid.Rows[i].Cells[j].Style.ForeColor = foreColor;
                    dataGrid.Rows[i].Cells[j].Selected = false;
                }
            }

            EmptyPoint empty = numbers.GetEmpty();
            dataGrid.Rows[empty.row].Cells[empty.column].Value = "";
            dataGrid.Rows[empty.row].Cells[empty.column].Style.BackColor = foreColor;
            NumberOfChanges.Text = numbers.GetChanges().ToString();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            bool isPossibleToChange = numbers.CanBeChanged(e.RowIndex, e.ColumnIndex);

            if (isPossibleToChange == true)
            {
                EmptyPoint empty = numbers.GetEmpty();

                int item = numbers.table[e.RowIndex, e.ColumnIndex];

                dataGrid.Rows[empty.row].Cells[empty.column].Value = item;
                dataGrid.Rows[empty.row].Cells[empty.column].Style.BackColor = backColor;

                dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = foreColor;
                dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;

                numbers.Change(e.RowIndex, e.ColumnIndex);

                NumberOfChanges.Text = numbers.GetChanges().ToString();

                if (numbers.WonAlready() == false)
                {
                    steps = numbers.GetChanges();
                    gameTime = date;

                    askNameForm = new AskForm("Enter your name: ", Ok, Cancel);

                    MessageBox.Show("Congratulations! You did it!");
                    askNameForm.ShowDialog();
                    MakeResultObject();
                    MenuForm menu = new MenuForm();
                    menu.ShowDialog();
                    StartNewGame();
                }
            }
        }

        private void Ok(string text, object sender, EventArgs e)
        {
            if (text == null || text == "")
            {
                playerName = "Unknown";
            }
            else
            {
                playerName = text;
            }
            askNameForm.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            playerName = "Unknown";
            askNameForm.Close();
        }
       

        private void RepeatGame_Click(object sender, EventArgs e)
        {
            numbers.SetInitialTable();
            ShowPosition();
        }

        private void OhTick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            ShowTime.Text = date.ToString("mm:ss");
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            new DateTime(0, 0);
            ShowTime.Text = date.ToString("mm:ss");
            StartNewGame();
        }

        private void MakeResultObject()
        {
            GameResult gr = new GameResult(steps, gameTime, startTime, playerName);
            MemoryManager mm = new MemoryManager(@"C:\Users\Liza\source\repos old\fifteensWinForm\fifteensWinForm\results.dat");
            mm.Load();
            mm.Add(gr);
            mm.Save();
            IEnumerable<GameResult> top = mm.GetTopTime();
            var x = top.ToArray();
        }

    }
}
