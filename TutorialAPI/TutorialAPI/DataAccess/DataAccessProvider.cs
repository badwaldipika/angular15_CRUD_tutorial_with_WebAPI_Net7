using TutorialAPI.Models;

namespace TutorialAPI.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly TestDbContext _context;
        public DataAccessProvider(TestDbContext context)
        {
            _context = context;
        }
        public void Create(Tutorial tutorial)
        {
            _context.Tutorials.Add(tutorial);
            _context.SaveChanges();
            return;
        }

        public void Delete(int id)
        {
            var entity = _context.Tutorials.FirstOrDefault(x => x.Id == id);
            _context.Tutorials.Remove(entity);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            foreach (var item in _context.Tutorials.ToList())
            {
                _context.Tutorials.Remove(item);
            }
            _context.SaveChanges();
        }

        public Tutorial Get(int id)
        {
            return _context.Tutorials.FirstOrDefault(x => x.Id == id);
        }

        public List<Tutorial> GetAll()
        {
            return _context.Tutorials.ToList();
        }

        public void Update(Tutorial tutorial)
        {
            _context.Tutorials.Update(tutorial);
            _context.SaveChanges();
        }
    }
}
