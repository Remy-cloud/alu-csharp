namespace Enemies
{
    /// <summary>
    /// Represents a Zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the zombie.
        /// </summary>
        private int health;

        /// <summary>
        /// The name of the zombie.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with a specified health value.
        /// Throws ArgumentException if value is less than 0.
        /// </summary>
        /// <param name="value">The health value for the zombie.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Returns the value of health of the Zombie object.
        /// </summary>
        /// <returns>The health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}