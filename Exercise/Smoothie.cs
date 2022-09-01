namespace Smoothies
{
    public class Smoothie
    {
        private IEnumerable<string> _ingredients;
        private string _name;

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
        /// </summary>
        public string Name
        {
            get
            {
                IEnumerable<string> sortedIngredients = _ingredients.OrderBy(ingredient => ingredient);
                string name = "";

                foreach (var element in sortedIngredients)
                {
                    string ingredient = element;

                    if (ingredient.Contains("ries"))
                    {
                        ingredient = ingredient.Remove(ingredient.Length - 3);
                        ingredient += "y";
                    }

                    name += ingredient + " ";
                }

                name += sortedIngredients.Count() > 1 ? "Fusion" : "Smoothie";

                return name;
            }
        }

        /// <summary>
        /// Method which calculates the total cost of the ingredients used to make the smoothie.
        /// </summary>
        public string GetCost()
        {
            double totalCost = 0.0;

            foreach (var ingredient in _ingredients)
            {
                totalCost += Convert.ToDouble(_prices[ingredient].Remove(0, 1));
            }

            return "$" + totalCost.ToString("N2");
        }

        /// <summary>
        /// Method which returns the number from <c>GetCost() + (GetCost() x 1.5)</c>.
        /// The number is rounded to two decimal places.
        /// </summary>
        public string GetPrice()
        {
            double totalCost = Convert.ToDouble(GetCost().Remove(0, 1));
            double totalPrice = totalCost + totalCost * 1.5;

            return "$" + totalPrice.ToString("N2");
        }
    }
}
