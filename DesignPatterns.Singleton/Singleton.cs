namespace DesignPatterns.Singleton
{
    class Singleton
    {
        static Singleton Instance;
        string singletonData = string.Empty;
        protected Singleton()
        {
        }
        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
        }
        public void SingletonOperation()
        {
            singletonData = "SingletonData";
        }
        public string GetSingletonData()
        {
            return singletonData;
        }
    }
}