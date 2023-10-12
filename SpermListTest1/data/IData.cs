using SpermListTest1.data.entites;

namespace SpermListTest1.data
{
    public interface IData
    {
        public List<fileDetails> GetFileDetails();
        public void AddfileData(fileDetails fileDetails);
        public void AddSpermList(List<sperm> spermList);
        public List<sperm> GetSpermList();
    }
}
