using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    public class SampleController : Controller
    {
        public string Index()
        {
            return "Sample view test";
        }
    }
}
