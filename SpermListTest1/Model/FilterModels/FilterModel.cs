namespace SpermListTest1.Model.FilterModels
{
    public class FilterModel
    {
        //public string index { get; set; }
        //public double value { get; set; }

        //public double? ICC { get; set; }
        //public int? LNM { get; set; }
        //public int LFM { get; set; }
        //public int? MILK { get; set; }
        //public double? FAT { get; set; }
        //public int? PRO { get; set; }
        //public double? SCE { get; set; }
        //public double? PL { get; set; }
        //public double? DPR { get; set; }
        //public double? PTAT { get; set; }
        //public double? UDC { get; set; }
        //public double? FLC { get; set; }
        //public int? TPI { get; set; }


        public int? No { get; set; }
        public int? RegNo { get; set; }
        public string? NAAB_CODE { get; set; }
        public string? NAME { get; set; }
        public string? SIRE { get; set; }
        public string? MGS { get; set; }
        public FilterRangeModel? Range { get; set; }
    }
}
