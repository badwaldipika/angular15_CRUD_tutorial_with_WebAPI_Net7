using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TutorialAPI.DataAccess;
using TutorialAPI.Models;

namespace TutorialAPI.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/tutorials")]
    [ApiController]
    public class TutorialsController : ControllerBase
    {
        private readonly ILogger<TutorialsController> _logger;
        private readonly IDataAccessProvider _dataAccessProvider;

        public TutorialsController(ILogger<TutorialsController> logger, IDataAccessProvider dataAccessProvider)
        {
            _logger = logger;
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public List<Tutorial> GetAll()
        {
            var list = _dataAccessProvider.GetAll();
            return list;
        }

        [HttpGet("{id}")]
        public Tutorial Get(int id)
        {
            return _dataAccessProvider.Get(id);
        }

        [HttpPost(Name = "Create")]
        public void Create(Tutorial data)
        {
            _dataAccessProvider.Create(data);

        }

        [HttpPut("{id}")]
        public void Update(Tutorial data, int id)
        {
            _dataAccessProvider.Update(data);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dataAccessProvider.Delete(id);
        }

        [HttpDelete(Name = "DeleteAll")]
        public void DeleteAll()
        {
            _dataAccessProvider.DeleteAll();
        }

        [HttpGet("Title")]
        public List<Tutorial> FindByTitle(string Title)
        {
            var list = new List<Tutorial>();
            Tutorial obj = new Tutorial();
            obj.Description = "here is the description.";
            obj.Published = true;
            obj.Title = "Title";
            obj.Id = 1;

            list.Add(obj);
            Tutorial obj1 = new Tutorial();
            obj1.Description = "here is the description.1";
            obj1.Published = true;
            obj1.Title = "Title1";
            obj1.Id = 2;

            list.Add(obj1);
            return list;
        }
    }
}
