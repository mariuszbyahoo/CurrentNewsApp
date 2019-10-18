using CurrentNewsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentNewsApp.Controllers
{
    [ApiController]
    [Route("/api/news")]
    public class NewsController : ControllerBase
    {
        private NewsContext _context;

        public NewsController(NewsContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult GetNews()
        {
            if (_context.handler != null)
            {
                News news = new News();
                news.data = _context.handler.GetNews("https://www.tvn24.pl/najnowsze.xml"); // tu jest null i tu się wywala
                return Ok(news.data);
            }
            else
            {
                throw new Exception("HttpWebRequestHandler jest nullem!!!!");
            }
        }
    }
}
