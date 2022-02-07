using log4net;

namespace Logging4Dummies
{
    class Car
    {
        // create a static logger field
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string Model { get; set; }
        public int YearReleased { get; set; }
        public Person Owner { get; set; }

        public Car(string model, int yearReleased, Person owner)
        {
            Model = model;
            YearReleased = yearReleased;
            Owner = owner;

            logger.Debug(String.Format("Created a car {0} at {1}", this, DateTime.Now));
        }

        public override string ToString()
        {
            return String.Format("[{0} ({1}), owned by {2}]", Model, YearReleased, Owner);
        }
    }
}
