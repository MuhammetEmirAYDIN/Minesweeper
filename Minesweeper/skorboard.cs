using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Minesweeper
{
    

    public class ScoreEntry
    {
        public string name { get; set; }
        public double score { get; set; }

        public ScoreEntry(String Name, double Score)
        {
            name = Name;
            score = Score;
        }
        
    }
    public class skorboard
    {
        private List<ScoreEntry> topscores;
        

        
        public skorboard()
        {
           
            topscores = new List<ScoreEntry>
            {
                new ScoreEntry ("[  ]                           ",9999),
                new ScoreEntry ("ISAAC                    ",805),
                new ScoreEntry ("SHAGGY               ",756),
                new ScoreEntry ("ISE                         ",710),
                new ScoreEntry ("WOLFIE                 ",648),
                new ScoreEntry ("CARMILLA             ",606),
                new ScoreEntry ("REGULUS             ",508),
                new ScoreEntry ("JANE                     ",456),
                new ScoreEntry ("EMIYA                   ",400),
                new ScoreEntry ("ALICE                    ",24)
            };
            

            
        }
        public List<ScoreEntry> GetScores()
        {
            
            
            return topscores.OrderByDescending(s=>s.score).ToList().GetRange(0, 10);
        }

        public void TryAddscore(string Name,double Score)
        {
            
            if(topscores.Count <10 || Score>topscores.Last().score)
            {
                if (topscores.Count == 10)
                {
                    topscores.RemoveAt(topscores.Count-1);
                    
                }
            }
            topscores.Add(new ScoreEntry(Name,Score));
            topscores=topscores.OrderByDescending(s=>s.score).ToList();

            
        }


        public double CalcScore(int time, double Mine)
        {
            
            return (int)((Mine / time) * 1000);
        }

       
    }
}