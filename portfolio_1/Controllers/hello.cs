using Microsoft.AspNetCore.Mvc;
    namespace portfolio_1.Controllers
    {
        public class Hello : Controller
        {
            [HttpGet("")]
            public string Index()
            {
                return "This is my Index";
            }
            [HttpGet("projects")]
            public string Projects()
            {
                return "These are my projects.";
            }
            [HttpGet("contact")]
            public string Contact()
            {
                return "This is my contact.";
            }
        }
    }