using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{

    
    public partial class GameScreen : Form
    {
        
        private const int GridWidth = 1000;
        private const int gridheight = 800;
        private Button[,] gridButtons;
        private Oyun oyun;
        private Form1 mainMenu;
        private Timer gameTimer;
        int Seconds = 1;
        private int openedNonMineCells = 0;
        private int totalNonMineCells;
        private int minecounter = 0;
        private double flagcounter = 0;
        
        
        private void GameTick(object sender, EventArgs e)
        {
           
            Seconds++;
        }
        private void InitializeGameTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;//1000 milisaniye 1 saniye
            gameTimer.Tick += new EventHandler(GameTick);
            gameTimer.Start();
        }

        
        public GameScreen(Oyun oyun, Form1 Mainmenu)
        {   
            InitializeComponent();
            this.oyun = oyun;
            this.mainMenu= Mainmenu;
            InitializeGrid(oyun.grid);
            InitializeGameTimer();
            this.KeyPreview = true;

        }
        private void InitializeGrid(int gridsize) {

            int buttonSize = Math.Min(GridWidth / gridsize, gridheight / gridsize);
            gridButtons = new Button[gridsize, gridsize];
            int HamleSayısı = 0;
            int Startx = (this.ClientSize.Width - (buttonSize * gridsize))/2;
            int Starty=(this.ClientSize.Height - (buttonSize * gridsize)) /2 + 80;
            PlaceMines(gridsize, oyun.Mine);
            totalNonMineCells=(gridsize*gridsize)-oyun.Mine;

            for (int row = 0; row < gridsize; row++) 
            {
                for (int col = 0; col < gridsize; col++) 
                {
                    Button button = new Button
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Location = new Point(Startx + col * buttonSize, Starty + row * buttonSize),
                        Tag = new Point(row, col),
                        BackColor = Color.Gray,
                        BackgroundImageLayout=ImageLayout.Stretch//resim gride otursun
                    };
                    button.MouseDown += GridButton_MouseDown;
                    this.Controls.Add(button);
                    gridButtons[row, col] = button;
                }
            }
            
            void GridButton_MouseDown(object sender, MouseEventArgs e)
            {
                Button button = sender as Button;
                Point coordinates = (Point)button.Tag;

                if(e.Button == MouseButtons.Left)
                {
                    

                    if (oyun.Mines[coordinates.X, coordinates.Y])
                    { 
                        button.BackgroundImage = Properties.Resources.Mine;
                        HamleSayısı++;
                        GERCEKHAMLE.Text = "      "+HamleSayısı.ToString();
                       
                        
                        RevealMines();
                        minecounter++;
                        if (openedNonMineCells == totalNonMineCells || minecounter != 0) {
                        
                        EndGame(); }


                    }
                    
                    else
                    {

                        OpenCell(button, coordinates.X, coordinates.Y);
                        HamleSayısı++;
                        GERCEKHAMLE.Text ="      "+ HamleSayısı.ToString();
                        if (openedNonMineCells == totalNonMineCells  || minecounter != 0) { EndGame(); }
                    }
                   
                }
                else if (e.Button == MouseButtons.Right)
                {
                    HamleSayısı++;
                    GERCEKHAMLE.Text ="      "+ HamleSayısı.ToString();
                    FlagCell(button,coordinates.X,coordinates.Y);
                    button.Refresh();
                    if (openedNonMineCells == totalNonMineCells  || minecounter != 0) { EndGame(); }
                }
               
          
                    

            }

                

            void FlagCell(Button button, int row, int col)
            {
                if (button.BackgroundImage != null)
                {
                    button.BackgroundImage = null;
                    
                }
                else
                {
                    button.BackgroundImage = Properties.Resources.flag;
                    FlagMine(row, col);
                    
                }
                button.Refresh();
            }
           
        }
        private int CountNeighbor(int row, int col)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1;j <= 1; j++)
                {
                    int Newrow = row + i;
                    int Newcol = col + j;

                    //grid disindakileri skiple
                    if(Newrow >= 0 && Newrow < oyun.grid && Newcol >=0 && Newcol<oyun.grid)
                    {
                        if (oyun.Mines[Newrow, Newcol]) count++;
                    }
                }
            }
            return count;
        }
        void OpenCell(Button button, int row, int col)
        {
            button.BackgroundImage = null;
            button.BackColor = Color.White;
            button.Enabled = false;
            openedNonMineCells++;
            int Neighbor = CountNeighbor(row, col);
            if (Neighbor > 0)
            {
                button.Text = Neighbor.ToString();
                button.ForeColor = Color.Black;
            }
            else
            {
                AdjEmpty(row, col);
            }

        }
        private void AdjEmpty(int row,int col)
        {
            for (int i = -1;i <= 1; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    int Newrow = row + i;
                    int Newcol = col + j;

                    if(Newrow >= 0 && Newrow < oyun.grid && Newcol >= 0 && Newcol < oyun.grid)
                    {
                        Button Adjbutton = gridButtons[Newrow, Newcol];
                        if(Adjbutton.Enabled&&!oyun.Mines[Newrow, Newcol])
                        {
                            OpenCell(Adjbutton, Newrow, Newcol);
                        }
                    }
                }
            }
        }
        private void PlaceMines(int gridsize,int minecount)
        {
            oyun.Mines= new bool [gridsize,gridsize]; //gridi initiliazelar
            Random random = new Random();
            int placedMines = 0;

            while(placedMines < minecount)
            {
                int row=random.Next(0,gridsize);
                int col=random.Next(0,gridsize);

                //bossa mayın koy
                if (!oyun.Mines[row, col])
                {
                    oyun.Mines[row, col] = true;
                    placedMines++;
                }
            }
        }
       private void RevealMines()
        {
            int gridSize = oyun.grid;
            for(int row = 0;row  < gridSize;row++)
            {
                for(int col = 0; col < gridSize; col++)
                {
                    if(oyun.Mines[row, col]&&gridButtons[row,col]!=null&& gridButtons[row,col].BackgroundImage==null)
                    {   
                        Button buttonmine = gridButtons[row, col];
                        buttonmine.BackgroundImage = Properties.Resources.Mine;
                        
                        buttonmine.Enabled = false;
                        
                    }
                }
            }
            
        }

       public void FlagMine(int row, int col)
        {
            if (oyun.Mines[row,col])
            {
                flagcounter++;
            }
            else
            {
                return;
            }
        }
        private void EndGame()
        {
            oyun.EndgameScore(oyun.PlayerName, Seconds, flagcounter);
            MessageBox.Show($"{oyun.Score}");
            this.Hide();
            mainMenu.Show();// end

        }


        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            { 
                this.Hide();
                mainMenu.Show();
               
            }
        }
        
    }
}
