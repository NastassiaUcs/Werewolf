

using System;
using System.IO;
using Newtonsoft.Json;

namespace Config
{
    class ConfigData
    {
        public string bot_api_key;
        public string connectionstring;
    }
    
    public static class Config
    {
        private static ConfigData data;
        
        static Config()
        {
            data = JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText("config.json"));            
        }

        public static string GetBotApiKey()
        {
            return data.bot_api_key;
        }

        public static string GetConnectionString()
        {
            return data.connectionstring;
        }

        public static string GetByKey(string key)
        {
            Console.WriteLine(key);
            switch (key)
            {
                    default: return "";
            }
        }
    }
}