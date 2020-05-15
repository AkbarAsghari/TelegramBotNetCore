using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyRobot.Models
{
    public class ConfigureModel : IConfigureModel
    {
        public string AccessToken { get; set; }
    }

    public interface IConfigureModel
    {
        public string AccessToken { get; set; }
    }
}
