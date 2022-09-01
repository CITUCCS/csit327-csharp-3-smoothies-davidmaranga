namespace Smoothies
{
    public class Smoothie
    {
        private IEnumerable<string> _ingredients;

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

        /// <summary>
        /// A constructor that sets the ingredients with the value <paramref name="ingredients"/>
        /// if there are no Exceptions thrown.
        /// </summary>
        /// <param name="ingredients">A string type of IEnumerable.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when any of the following conditions are true:
        /// 1. <paramref name="ingredients"/> is empty.
        /// 2. <paramref name="ingredients"/> contains duplicate values.
        /// 3. <paramref name="ingredients"/> contains values which don't exist in _prices.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="ingredients"/> is null.
        /// </exception>
        public Smoothie(IEnumerable<string> ingredients)
        {
            bool hasDuplicates = ingredients.Count() != ingredients.Distinct().Count();
            bool hasUnknownIngredients = false;

            foreach (var ingredient in ingredients)
            {
                if (!_prices.ContainsKey(ingredient))
                {
                    hasUnknownIngredients = true;
                    break;
                }
            }

            if (ingredients.Count() == 0 || hasDuplicates || hasUnknownIngredients)
            {
                throw new ArgumentException();
            }

            if (ingredients == null)
            {
                throw new ArgumentNullException();
            }

            _ingredients = ingredients;
        }

        /// <summary>
        /// Ingredients used for the smoothie
        /// </summary>
        public IEnumerable<string> Ingredients
        {
            get
            {
                return _ingredients.OrderBy(ingredient => ingredient);
            }
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
