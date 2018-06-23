

namespace Logger
{
    public class Log : ILog
    {
        /// <summary>
        /// Static field to stored instance of the singleton class
        /// </summary>
        private static Log _instance;

        /// <summary>
        /// Private construct to restrict user to instance outside the class
        /// </summary>
        private Log() { }

        /// <summary>
        /// GetInstance method which create new instance if its null, and return instance  
        /// </summary>
        public static Log GetInstance => _instance ?? (_instance = new Log());


        public void LogException(string message)
        {
            // You can write your code to logging message to files or external data source file
            throw new System.NotImplementedException();
        }
    }
}
