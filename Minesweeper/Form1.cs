using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper;


namespace Minesweeper
{
    public partial class Form1 : Form
    {
        private Oyun oyun;
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
        private void Scoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard(this);

            scoreboard.LoadScore(oyun.Skorboard.GetScores());
            scoreboard.Show();
            this.Hide();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StartGame_Click(object sender, EventArgs e)
        {   
            //oyuncudan alınacak inputlar
            string playername = txtPlayerName.Text;
            int gridSize;
            int MineCount ;

            if (string.IsNullOrWhiteSpace(playername))
            {
                MessageBox.Show("Enter Name correctly");
                return;
            }

            if (int.TryParse(txtGrid.Text, out gridSize))
            {   
                if(gridSize<1 || gridSize > 30)
                {
                    MessageBox.Show("Enter valid Grid Size");
                    return;
                }
                
                
            }
            else
            {
                MessageBox.Show("Enter valid Grid Size");
                return;
            }

            if (int.TryParse(txtMine.Text, out MineCount))
            {
                if(MineCount < 10 || MineCount > gridSize*gridSize-1)
                {
                    MessageBox.Show("Enter valid Mine Count");
                    return;
                }
               
            }
            else
            {
                MessageBox.Show("Enter valid Mine Count");
                return;
            }



            if(oyun == null){
                oyun = new Oyun
                {
                    grid = gridSize,
                    Mine = MineCount,
                    PlayerName = playername,
                    Score = 0  //0 olarak initilazilelanır
                };
            }else{
                oyun.grid = gridSize;
                oyun.Mine = MineCount;
                oyun.PlayerName = playername;
                oyun.Score = 0;
            }


            GameScreen gameScreen = new GameScreen(oyun,this);
            gameScreen.Show();

            this.Hide();
        }
        
        private void Developer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
