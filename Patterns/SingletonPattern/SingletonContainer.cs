namespace SingletonPattern
{
    /// <summary>
    /// Sealed restricts the inheritance
    /// </summary>
    public sealed class SingletonContainer : ISingletonContainer
    {
        //private static SingletonContainer _instance = new SingletonContainer();
        //public static SingletonContainer Instance => _instance;


        /// <summary>
        /// Singleton object is not instantiated until and unless GetInstance is invoked
        /// Thread Safe Singleton Pattern
        /// </summary>

        private static Lazy<SingletonContainer> _instance = new Lazy<SingletonContainer>(() => new SingletonContainer());
        public static SingletonContainer Instance => _instance.Value;

        private Dictionary<string, int> _capital = new Dictionary<string, int>();

        /// <summary>
        /// Private constructor ensures that object is not
        /// instantiated other than with in the class itself
        /// </summary> 
        private SingletonContainer()
        {
            Console.WriteLine("Initializing Singleton object");
            var readFile = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < readFile.Length; i+=2)
            {
                _capital.Add(readFile[i], int.Parse(readFile[i + 1]));
            }

        }

        public int GetPopulation(string name)
        {
            return _capital[name];
        }
    }
}
