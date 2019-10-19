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
        private readonly NewsContext _context;

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
                news.Data = _context.handler.GetNews("https://www.tvn24.pl/najnowsze.xml");
                //_context.NewsSet.Add(news); 
                //_context.SaveChanges(); This line throws : SqlException: Invalid object name 'NewsSet'.
                // if uncommented

                return Ok(news.Data);
            }
            else
            {
                throw new Exception("HttpWebRequestHandler jest nullem!!!!");
            }
        }
    }
}
