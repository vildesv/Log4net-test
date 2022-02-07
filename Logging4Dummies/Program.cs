// See https://aka.ms/new-console-template for more information
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")] // added the log4net assembly

namespace Logging4Dummies
{
    class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);      // Creates a logger using the LogManager class. It provides the GetLogger method to get a unique logger per each class (uses built-in tools to identify the caller class

        static void Main(string[] args)
        {
            // create 2 persons
            var person1 = new Person("John", "Gold");
            var person2 = new Person("James", "Miller");

            // create 2 cars
            var car1 = new Car("Tesla Model S", 2020, person1);
            var car2 = new Car("Tesla Model X", 2020, person2);

            // logging
            logger.Debug("Some debug log");                                                                         // Relatively detailed tracing used by application developers.
            logger.Info(String.Format("Person1: {0}", person1));                                                    // Informational messages that might make sense to end users and system administrators, and highlight the progress of the application.
            logger.Info(String.Format("Car2: {0}", car2));                                                          // Informational messages that might make sense to end users and system administrators, and highlight the progress of the application.
            logger.Warn(String.Format("Warning accured at {0}", DateTime.Now));                                     // Potentially harmful situations of interest to end users or system managers that indicate potential problems.
            logger.Error(String.Format("Error accured at {0}", DateTime.Now));                                      // Error events of considerable importance that will prevent normal program execution, but might still allow the application to continue running.
            logger.Fatal(String.Format("Serious problem with car {0} accured at {1}", car1, DateTime.Now));         // Very severe error events that might cause the application to terminate.
        }
    }
}



/* 

 How to start logging with log4net
(https://betterstack.com/community/guides/logging/net/how-to-start-logging-with-log4net/)

 Step 1 - Create a project              // Made a project named Logging4Dummies
 Step 2 - Installing dependencies       // Done with the Package Manager Console. Commands in use: Install-Package log4net (root package of log4net) and Install-Package log4net.Ext.Json (provides easy-to-use JSON layout).
 Step 3 - Creating a Logger             // Added comments in the code at Program.cs.
 Step 4 - Configuring the Logger        // Configuring the Logger using the log4net.config file (set the file's Copy to Output Directory property to Copy Always). The log4net.config is written in XML.
 Step 5 - Creating Extra Classes        // Created a Person class and a Car class.
 Step 6 - Logging                       // Logging simple messages to the console using at least one of five different log levels.

*/