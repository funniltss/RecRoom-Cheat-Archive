using Microsoft.AspNetCore.Mvc;


namespace Server.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        [Route("/API/api/versioncheck/v4")]
        [HttpGet]
        public string GetVersion()
        {
            Console.WriteLine("Something\n");
            return "{\"VersionStatus\":0,\"UpdateNotificationStage\":0}";
        }
        [Route("/API/api/gameconfigs/v1/all")]
        [HttpGet]
        public string GetCameConfigs()
        {
            Console.WriteLine("Grab gameconfigs.json");
            return System.IO.File.ReadAllText("C:\\gameconfigs.json");
        }
        [Route("/API/api/config/v1/amplitude")]
        [HttpGet]
        public string GetAmplConfig()
        {
            Console.WriteLine("Get ampl.json");
            return System.IO.File.ReadAllText("C:\\ampl.json");
        }
        [Route("/API/api/customAvatarItems/v1/isCreationAllowedForAccount")]
        [HttpGet]
        public string GetCusotmCreationConfig()
        {
            Console.WriteLine("Custom creation .jsob");
            return System.IO.File.ReadAllText("C:\\customcreation.json");
        }
        [Route("/API/api/relationships/v2/get")]
        [HttpGet]
        public string GetFriends()
        {
            Console.WriteLine("getFriends");
            return "[]";
        }
        [Route("/API/api/players/v2/progression/bulk")]
        [HttpGet]
        public string GetProgression()
        {
            Console.WriteLine("Get Player progression.");
            return System.IO.File.ReadAllText("C:\\plrstats.json");
        }
    }
}


