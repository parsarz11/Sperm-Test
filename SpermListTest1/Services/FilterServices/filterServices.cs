using Microsoft.EntityFrameworkCore.Diagnostics;
using SpermListTest1.data;
using SpermListTest1.data.entites;
using SpermListTest1.Model;
using System;
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
            var filterType = filterModel.FilterType;
            
            if(filterType == "Range")
            {
                return Range(filterModel.index, filterModel.min, filterModel.max);

            }else if(filterType == "Min")
            {
                return Min(filterModel.index);
            }else if(filterType == "Max")
            {
                return Max(filterModel.index);

            }else if (filterType == "SelectByValue")
            {
                return SelectByValue(filterModel.index, filterModel.value);
            }
            
            return new List<sperm>();
        }


        private List<sperm> Range(string type, double min, double max)
        {
            var SpermList = _DbData.GetSpermList();
            var range = SpermList.Select(x => x.GetType().GetProperty(type).GetValue(x).GetType()).FirstOrDefault();
            

            if(range.Name == "Int32")
            {
                var filterdList = SpermList.Where(x => (int)x.GetType().GetProperty(type).GetValue(x) >= min && (int)x.GetType().GetProperty(type).GetValue(x) <= max)
                .ToList();
                
                return filterdList;
            }
            else
            {
                var filterdList = SpermList.Where(x => (double)x.GetType().GetProperty(type).GetValue(x) >= min && (double)x.GetType().GetProperty(type).GetValue(x) <= max)
               .ToList();

                
                return filterdList;
            }

            
        }

        private List<sperm> Min(string type)
        {
            var spermList = _DbData.GetSpermList();
            var range = spermList.Select(x => x.GetType().GetProperty(type).GetValue(x).GetType()).FirstOrDefault();
            if (range.Name == "Int32")
            {

                var filterdByType = spermList.Select(x => (int)x.GetType().GetProperty(type).GetValue(x)).ToList();
                var min = filterdByType.Min();

                var filteredList = spermList.Where(x => x.GetType().GetProperty(type).GetValue(x).Equals(min)).ToList();


                return filteredList;
            }
            else
            {

                var filterdByType = spermList.Select(x => (double)x.GetType().GetProperty(type).GetValue(x)).ToList();
                var max = filterdByType.Max();

                var filteredList = spermList.Where(x => x.GetType().GetProperty(type).GetValue(x).Equals(max)).ToList();


                return filteredList;
            }

        }

        private List<sperm> Max(string type)
        {
            var spermList = _DbData.GetSpermList();
            var range = spermList.Select(x => x.GetType().GetProperty(type).GetValue(x).GetType()).FirstOrDefault();
            if (range.Name == "Int32")
            {
                
                var filterdByType = spermList.Select(x => (int)x.GetType().GetProperty(type).GetValue(x)).ToList();
                var max = filterdByType.Max();

                var filteredList = spermList.Where(x => x.GetType().GetProperty(type).GetValue(x).Equals(max)).ToList();


                return filteredList;
            }else
            {
                
                var filterdByType = spermList.Select(x => (double)x.GetType().GetProperty(type).GetValue(x)).ToList();
                var max = filterdByType.Max();

                var filteredList = spermList.Where(x => x.GetType().GetProperty(type).GetValue(x).Equals(max)).ToList();


                return filteredList;
            }
        }

        private List<sperm> SelectByValue(string type,double value)
        {

            var spermList =_DbData.GetSpermList();

            var range = spermList.Select(x => x.GetType().GetProperty(type).GetValue(x).GetType()).FirstOrDefault();
            if (range.Name == "Int32")
            {

                var FilteredList = spermList.Where(x => (int)x.GetType().GetProperty(type).GetValue(x) == value).ToList();
                return FilteredList;
            }else
            {
                var FilteredList = spermList.Where(x => (double)x.GetType().GetProperty(type).GetValue(x) == value).ToList();
                return FilteredList;
            }


        }
    }

    
}
