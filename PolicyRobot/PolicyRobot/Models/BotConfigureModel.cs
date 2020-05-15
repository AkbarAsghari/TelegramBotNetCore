using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyRobot.Models
{
    public class BotConfigureModel : IBotConfigureModel
    {
        public string AccessToken { get; set; }
    }

    public interface IBotConfigureModel
    {
        public string AccessToken { get; set; }
    }
}
