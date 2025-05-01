using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Scoreboard : Form
    {   
        private Form1 Mainmenu;
        public Scoreboard(Form1 Mainmenu)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Mainmenu = Mainmenu;

            
        }
        private void Scoreboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Mainmenu.Show();
            }
        }
        
        public void LoadScore(List<ScoreEntry> scores)
        {
            listBoxScore.Items.Clear();


            foreach (var scoreEntry in scores)
            {
                
                    listBoxScore.Items.Add($"{scoreEntry.name}{scoreEntry.score}");
                
               
            }
        }

        private void listBoxScore_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
