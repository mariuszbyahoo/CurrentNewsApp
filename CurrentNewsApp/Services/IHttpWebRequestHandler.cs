using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentNewsApp.Services
{
    public interface IHttpWebRequestHandler
    {
        string GetNews(string url);
    }
}
