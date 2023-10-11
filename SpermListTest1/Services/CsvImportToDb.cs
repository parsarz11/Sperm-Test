using CsvHelper;
using SpermListTest1.data;
using SpermListTest1.data.entites;
using SpermListTest1.Model;
using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SpermListTest1.Services
{
    public class CsvImportToDb
    {
        private readonly IData _data;

        public CsvImportToDb(IData data)
        {
            _data = data;
        }

        public void ImportToDb(string fileName)
        { 
            string path = $"./FileDownloaded/{fileName}";

            var spermVM = new List<sperm>();
            using(var SR = new StreamReader(path))
            {
                using(var csv = new CsvReader(SR, CultureInfo.InvariantCulture))
                {
             
                    var  records = csv.GetRecords<SpermViewModel>().ToList();

                    //spermVM.AddRange(records);
                    var SpermList = records.Select(x =>
                    {
                        var spermOBJ = new sperm()
                        {
                            No = x.No,
                            RegNo = x.RegNo,
                            NAAB_CODE = x.NAAB_CODE,
                            NAME = x.NAME,
                            ICC = x.ICC,
                            LNM = x.LNM,
                            LFM = x.LFM,
                            MILK = x.MILK,
                            FAT = x.FAT,
                            PRO = x.PRO,
                            SCE = x.SCE,
                            PL = x.PL,
                            DPR = x.DPR,
                            PTAT = x.PTAT,
                            UDC = x.UDC,
                            FLC = x.FLC,
                            TPI = x.TPI,
                            SIRE = x.SIRE,
                            MGS = x.MGS,
                        };
                        return spermOBJ;
                    }).ToList();

                    spermVM.AddRange(SpermList);
                }
            }
            
           _data.AddSpermList(spermVM);
            //return spermVM;
        }

       
    }
}
