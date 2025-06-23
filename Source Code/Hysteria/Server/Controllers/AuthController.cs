using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Server.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        [Route("/AUTH/connect/token")]
        [HttpPost]
        public string GetVersion()
        {
            Console.WriteLine("get token.json");
            return System.IO.File.ReadAllText("C:\\token.json");
        }
        [Route("/AUTH/eac/challenge")]
        [HttpGet]
        public string GetEacChallenge()
        {
            Console.WriteLine("AHAHHHA");
            string text = new WebClient().DownloadString("https://auth.rec.net/eac/challenge");
            return text;
        }
        [Route("/AUTH/cachedlogin/forplatformid/0/76561198931296020")]
        [HttpGet]
        public string GetCachedLogins()
        {

            Console.WriteLine("Chasded edaccs.");
            return System.IO.File.ReadAllText("C:\\cashedaccouts.json");
        }
    }
}
