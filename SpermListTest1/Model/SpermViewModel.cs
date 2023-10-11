using CsvHelper.Configuration.Attributes;
using System.Text.RegularExpressions;

namespace SpermListTest1.Model
{
    public class SpermViewModel
    {
        
         
        [Index(0)]
        public int No { get; set; }
        [Index(1)]
        public int RegNo { get; set; }
        [Index(2)]
        public string NAAB_CODE { get; set; }
        [Index(3)]
        public string NAME { get; set; }
        [Index(4)]
        public double ICC { get; set; }
        [Index(5)]
        public int LNM { get; set; }
        [Index(6)]
        public int LFM { get; set; }
        [Index(7)]
        public int MILK { get; set; }
        [Index(8)]
        public double FAT { get; set; }
        [Index(9)]
        public int PRO { get; set; }
        [Index(10)]
        public double SCE { get; set; }
        [Index(11)]
        public double PL { get; set; }
        [Index(12)]
        public double DPR { get; set; }
        [Index(13)]
        public double PTAT { get; set; }
        [Index(14)]
        public double UDC { get; set; }
        [Index(15)]
        public double FLC { get; set; }
        [Index(16)]
        public int TPI { get; set; }
        [Index(17)]
        public string SIRE { get; set; }
        [Index(18)]
        public string MGS { get; set; }
    }
}
//RegNo     NAME	    ICC	LNM	LFM	MILK	FAT	PRO	
//12345678	John Doe	0.7	42	35	5000	3.8	10	


