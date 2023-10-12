using SpermListTest1.data.context;
using SpermListTest1.data.entites;

namespace SpermListTest1.data.Repository
{
    public class DbRepository : IData
    {
        private readonly DatabaseContext _dbContext;

        public DbRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddfileData(fileDetails fileDetails)
        {
            _dbContext.fileDetails.Add(fileDetails);
            _dbContext.SaveChanges();
        }

        public void AddSpermList(List<sperm> spermList)
        {
            _dbContext.Sperms.AddRange(spermList);
            _dbContext.SaveChanges();
        }

        public List<sperm> GetSpermList()
        {
            return _dbContext.Sperms.ToList();
        }
        public List<fileDetails> GetFileDetails()
        {
            var FilesList = _dbContext.fileDetails.ToList();
            return FilesList;
        }
    }
}
