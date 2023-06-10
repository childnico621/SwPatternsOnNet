namespace SwPatterns.Creacionales.Singleton
{
    public class SingletonConfiguration
    {
        private static SingletonConfiguration _instance;
        public Dictionary<string, string> configuration { get; private set; }

        private SingletonConfiguration()
        {
            configuration = new Dictionary<string, string>();
            configuration.Add("conn", "mysqlconnection_string");
            configuration.Add("path", "/etc");
        }

        public static SingletonConfiguration GetInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("inicializando...");
                _instance = new SingletonConfiguration();
            }
            return _instance;

        }

        public Dictionary<string, string> GetConfiguration()
        {
            return configuration;
        }
    }
}
