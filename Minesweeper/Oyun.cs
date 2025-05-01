using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Oyun
    {
            public int grid { get; set; }
            public int Mine {  get; set; }
            public string PlayerName {  get; set; }
            public double Score {  get; set; }

            public bool[,] Mines { get; set; }
            
            public skorboard Skorboard { get; set; }

        public Oyun()
        {
            Skorboard=new skorboard();
        }

        public void EndgameScore(string Name, int time,double mine)
        {
            Score=Skorboard.CalcScore(time, mine);
            Skorboard.TryAddscore(Name, Score);
            Skorboard.GetScores();
        }

       
    }
    
}
