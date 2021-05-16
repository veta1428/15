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
    public partial class MenuForm : Form
    {
        MemoryManager memMan = new MemoryManager(@"C:\Users\Liza\source\repos old\fifteensWinForm\fifteensWinForm\results.dat");
        AskForm askDateForm;
        public MenuForm()
        {
            InitializeComponent();          
            memMan.Load();
        }

        private void DisplayGrid(IEnumerable<GameResult> results)
        {
            foreach (var it in results)
            {
                int counter = 0;
                GridResult.Rows.Add("Player:", it.Player);
                GridResult.Rows.Add("Time:", it.GameTime.ToString("memMan:ss"));
                GridResult.Rows.Add("Date:", it.StartTime.ToString("dd.memMan.yyyy HH:memMan:ss"));
                GridResult.Rows.Add("Steps", it.Steps);

                GridResult.Rows[counter * 4].Cells[1].Style.BackColor = Color.Purple;
                GridResult.Rows[counter * 4].Cells[0].Style.BackColor = Color.Purple;

                for (int i = 0; i < 4; i++)
                {
                    GridResult.Rows[counter + i].Height = 40;
                    
                }                
                counter++;
            }
        }

        private void SetNewGrid()
        {
            GridResult.Visible = true;
            GridResult.Columns.Clear();
            GridResult.Columns.Add("Field", "Field");
            GridResult.Columns.Add("Value", "Value");
            GridResult.Columns[0].Width = 100;
            GridResult.Columns[1].Width = 180;
        }

        private void Top10Time_Click(object sender, EventArgs e)
        {
            var results = memMan.GetTopTime(10);            
            Results.Text = "Top 10 by time";
            SetNewGrid();
            DisplayGrid(results);
        }

        private void Last10_Click(object sender, EventArgs e)
        {
            var results = memMan.GetLast(10);
            Results.Text = "Last 10";
            SetNewGrid();
            DisplayGrid(results);      
        }

        private void Top10Steps_Click(object sender, EventArgs e)
        {
            var results = memMan.GetTopSteps(10);
            Results.Text = "Top 10 by steps";
            SetNewGrid();
            DisplayGrid(results);
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            askDateForm = new AskForm(@"Enter date in format ""dd.memMan.yyyy"": ", Ok, Cancel);
            askDateForm.ShowDialog();
        }    

        private void Ok(string text, object sender, EventArgs e)
        {
            DateTime date;
            try
            {
                date = DateTime.ParseExact(text, "dd.memMan.yyyy", null);
                memMan.Delete(date);
                memMan.Save();
                askDateForm.Close();
            }
            catch
            {
                MessageBox.Show("Invalid datetime!");
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            askDateForm.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
