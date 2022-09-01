namespace Smoothies
{
    public class Smoothie
    {
        // DO NOT MODIFY THIS FIELD
        private readonly Dictionary<string, string> _prices = new()
        {
            { "Strawberries", "$1.50" },
            { "Banana", "$0.50" },
            { "Mango", "$2.50" },
            { "Blueberries", "$1.00" },
            { "Raspberries", "$1.00" },
            { "Apple", "$1.75" },
            { "Pineapple", "$3.50" }
        };

        // TODO: Implement me!
        public Smoothie (IEnumerable<string> ingredients)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ingredients used for the smoothie
        /// TODO: Implement me!
        /// </summary>
        public IEnumerable<string> Ingredients 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        /// <summary>
        /// Name of the smoothie
        /// TODO: Implement me!
        /// </summary>
        public string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Method which calculates the total cost of the ingredients used to make the smoothie.
        /// TODO: Implement me!
        /// </summary>
        public string GetCost()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method which returns the number from <c>GetCost() + (GetCost() x 1.5)</c>. Round to two decimal places.
        /// TODO: Implement me!
        /// </summary>
        public string GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
