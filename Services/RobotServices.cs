using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using practice_robots_bootstrap.Services;
using practice_robots_bootstrap.Models;

namespace practice_robots_bootstrap.Services
{
    public class RobotsServices
    {
    public static List<RobotModel> Builder()
        {
            JsonSerializer serializer = new JsonSerializer();
            var RobotList = new List<RobotModel>();

            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var robotsInfo = JsonConvert.DeserializeObject<RobotModel>(reader.ReadToEnd());
                RobotList.Add(robotsInfo);
                
            }
            return RobotList;
        }
    }
}