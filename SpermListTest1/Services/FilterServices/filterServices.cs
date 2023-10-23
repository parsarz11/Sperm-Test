using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using SpermListTest1.data;
using SpermListTest1.data.entites;
using SpermListTest1.Model.FilterModels;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SpermListTest1.Services.FilterServices
{
    public class filterServices
    {

        private readonly IData _DbData;

        public filterServices(IData dbData)
        {
            _DbData = dbData;
        }

        public List<sperm> SearchFilter(FilterModel filterModel)
        {

            var SpermList = _DbData.GetSpermList();
            var result = SpermList;

            if (filterModel != null)
            {
                if (filterModel.No != null)
                {
                    result = result.Where(x => x.No == filterModel.No).ToList();
                }
                if(filterModel.RegNo != null)
                {
                    result = result.Where(x => x.RegNo == filterModel.RegNo).ToList();
                }
                if(filterModel.NAAB_CODE != null)
                {
                    result = result.Where(x => x.NAAB_CODE == filterModel.NAAB_CODE).ToList();
                }
                if(filterModel.NAME != null)
                {
                    result = result.Where(x=> x.NAME == filterModel.NAME).ToList();
                }
                if (filterModel.SIRE != null)
                {
                    result = result.Where(x => x.SIRE == filterModel.SIRE).ToList();
                }
                if (filterModel.MGS != null)
                {
                    result = result.Where(x => x.MGS == filterModel.MGS).ToList();
                }
                if (filterModel.Range != null)
                {
                    result = Range(filterModel.Range, result);
                }

                return result;
            }


            return result;
        }


        private List<sperm> Range(string filterRanges,List<sperm> response)
        {


            var result = response;
            


            var range = JsonSerializer.Deserialize<DeserializerJsonModel>(filterRanges);
            if (range == null) 
            { 
                return result;
            }

            foreach (var index in range.filters)
            {
                
                    if (index.MinValue != null && index.MaxValue != null)
                    {
                        result = response.Where(x => (double)x.GetType().GetProperty(index.Index).GetValue(x)
                        >= index.MinValue && (double)x.GetType().GetProperty(index.Index).GetValue(x) <= index.MaxValue).ToList();
                    }

                    else if (index.MinValue != null)
                    {
                        result = response.Where(x => (double)x.GetType().GetProperty(index.Index).GetValue(x)
                        >= index.MinValue).ToList();
                    }

                    else if (index.MaxValue != null)
                    {
                        result = response.Where(x => (double)x.GetType().GetProperty(index.Index).GetValue(x)
                        <= index.MaxValue).ToList();
                    }
            }

            return result;
        }

        
    }

}


