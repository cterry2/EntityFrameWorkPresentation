using System.Linq;
using System.Web.Mvc;
using TheSocialNetwork.Service;
using TheSocialNetwork.Service.Interface;

namespace TheSocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private INewsFeedRepository _repository { get; set; }

        public HomeController()
        {
            _repository = new NewsFeedRepository();
        }
        public HomeController(INewsFeedRepository repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            var newsItems = _repository.GetPosts(1);

            return View(newsItems.ToList());
        }        
    }
}