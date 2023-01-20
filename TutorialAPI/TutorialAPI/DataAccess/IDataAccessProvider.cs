using TutorialAPI.Models;

namespace TutorialAPI.DataAccess
{
    public interface IDataAccessProvider
    {
        void Create(Tutorial tutorial);
        void Update(Tutorial tutorial);
        void Delete(int id);
        void DeleteAll();
        Tutorial Get(int id);
        List<Tutorial> GetAll();
    }
}
