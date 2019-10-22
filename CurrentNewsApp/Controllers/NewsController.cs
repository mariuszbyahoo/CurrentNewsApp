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
            string news = _context.handler.GetNews("https://www.tvn24.pl/najnowsze.xml");


            if (_context.handler != null)
            {
                return Ok(news);
            }
            else
            {
                throw new Exception("HttpWebRequestHandler jest nullem!!!!");
            }
        }
    }
}
