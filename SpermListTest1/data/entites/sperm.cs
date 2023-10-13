using CsvHelper.Configuration.Attributes;

namespace SpermListTest1.data.entites
{
    public class sperm
    {
        public int id { get; set; }
        public int No { get; set; }
        public int RegNo { get; set; }
        public string NAAB_CODE { get; set; }
        public string NAME { get; set; }
        public double ICC { get; set; }
        public double LNM { get; set; }
        public double LFM { get; set; }
        public double MILK { get; set; }
        public double FAT { get; set; }
        public double PRO { get; set; }
        public double SCE { get; set; }
        public double PL { get; set; }
        public double DPR { get; set; }
        public double PTAT { get; set; }
        public double UDC { get; set; }
        public double FLC { get; set; }
        public double TPI { get; set; }
        public string SIRE { get; set; }
        public string MGS { get; set; }
    }
}

//No RegNo	    NAAB_CODE	NAME	    ICC	  LNM	LFM	  MILK	  FAT	  PRO	  SCE	PL	  DPR	PTAT	UDC	  FLC	TPI	  SIRE	MGS
//1	 12345678	USA0001	    John Doe	0.7	  42	35	  5000	  3.8	  10	  7	    5.5	  2	    1.6	    2.3	  2.8	180	  A1	B1

//No	RegNo	NAME	ICC	LNM	LFM	MILK	FAT	PRO


