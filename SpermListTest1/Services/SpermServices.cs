using SpermListTest1.data;
using SpermListTest1.data.entites;

namespace SpermListTest1.Services
{
    public class SpermServices
    {
        private readonly IData _SpermRepo;

        public SpermServices(IData spermRepo)
        {
            _SpermRepo = spermRepo;
        }

        public List<sperm> SpermList()
        {
            return _SpermRepo.GetSpermList();
        }
    }
}
