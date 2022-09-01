using Xunit;
using Shouldly;
using System.Collections.Generic;
using System;

namespace Smoothies.Tests
{
    public class SmoothieTests
    {


        [Fact]
        [Trait("TestGroup", "SmoothieConstructor")]
        public void Smoothie_Constructor_ShouldReceiveIEnumerable()
        {
            Should.NotThrow(() => new Smoothie(new List<string> { "Banana", "Strawberries" }));
        }

        [Fact]
        [Trait("TestGroup", "SmoothieConstructor")]
        public void Smoothie_RepeatedIngredients_ShouldThrowArgumentException()
        {
            Should.Throw<ArgumentException>(
                () => new Smoothie(new List<string> { "Banana", "Strawberries", "Apple", "Banana" }));
        }

        [Fact]
        [Trait("TestGroup", "SmoothieConstructor")]
        public void Smoothie_EmptyIngredients_ShouldThrowArgumentException()
        {
            Should.Throw<ArgumentException>(() => new Smoothie(new List<string>()));
        }

        [Fact]
        [Trait("TestGroup", "SmoothieConstructor")]
        public void Smoothie_NonExistentIngredients_ShouldThrowArgumentException()
        {
            Should.Throw<ArgumentException>(() => new Smoothie(new List<string> { "Peach", "banana"}));
        }

        [Fact]
        [Trait("TestGroup", "SmoothieConstructor")]
        public void Smoothie_NullIngredients_ShouldThrowArgumentNullException()
        {
            Should.Throw<ArgumentNullException>(() => new Smoothie(null!));
        }

        [Fact]
        [Trait("TestGroup", "SmoothieIngredients")]
        public void Smoothie_Ingredients_ShouldBeReadonly()
        {
            typeof(Smoothie).GetProperty("Ingredients")!
                            .GetSetMethod()
                            .ShouldBeNull();
        }

        [Theory]
        [MemberData(nameof(IngredientsData))]
        [Trait("TestGroup", "SmoothieIngredients")]
        public void Smoothie_Ingredients_ShouldReturnExpected(
            IEnumerable<string> ingredients,
            IEnumerable<string> expected)
        {
            var smoothie = new Smoothie(ingredients);

            smoothie.Ingredients.ShouldNotBeEmpty();
            smoothie.Ingredients.ShouldBeInOrder(SortDirection.Ascending);
            smoothie.Ingredients.ShouldBe(expected);
        }

        [Theory]
        [MemberData(nameof(NameData))]
        [Trait("TestGroup", "SmoothieName")]
        public void Smoothie_Name_ShouldBeExpected(IEnumerable<string> ingredients, string expected)
        {
            var smoothie = new Smoothie(ingredients);

            smoothie.Name.ShouldNotBeNullOrEmpty();
            smoothie.Name.ShouldBe(expected);
        }

        [Fact]
        [Trait("TestGroup", "SmoothieName")]
        public void Smoothie_Name_ShouldBeReadonly()
        {
            typeof(Smoothie).GetProperty("Name")!
                            .GetSetMethod()
                            .ShouldBeNull();
        }

        [Theory]
        [MemberData(nameof(GetCostData))]
        [Trait("TestGroup", "SmoothieGetCost")]
        public void Smoothie_GetCost_ShouldBeExpected(IEnumerable<string> ingredients, string expected)
        {
            var smoothie = new Smoothie(ingredients);

            smoothie.GetCost().ShouldNotBeNullOrEmpty();
            smoothie.GetCost().ShouldBe(expected);
        }

        [Theory]
        [MemberData(nameof(GetPriceData))]
        [Trait("TestGroup", "SmoothieGetPrice")]
        public void Smoothie_GetPrice_ShouldBeExpected(IEnumerable<string> ingredients, string expected)
        {
            var smoothie = new Smoothie(ingredients);

            smoothie.GetPrice().ShouldNotBeNullOrEmpty();
            smoothie.GetPrice().ShouldBe(expected);
        }

        public static IEnumerable<object[]> IngredientsData =>
            new List<object[]>
            {
                new object[] {
                    new List<string>() { "Strawberries", "Banana", "Blueberries" },
                    new List<string>() { "Banana", "Blueberries", "Strawberries" }
                },
                new object[] {
                    new List<string>() { "Banana"},
                    new List<string>() { "Banana"}
                },
                new object[] {
                    new List<string>() { "Strawberries", "Apple", "Banana", "Blueberries" },
                    new List<string>() { "Apple", "Banana", "Blueberries", "Strawberries" }
                }
            };

        public static IEnumerable<object[]> NameData =>
            new List<object[]>
            {
                new object[] {
                    new List<string>() { "Strawberries", "Banana", "Blueberries" },
                    "Banana Blueberry Strawberry Fusion"
                },
                new object[] {
                    new List<string>() { "Banana"},
                    "Banana Smoothie"
                },
                new object[] {
                    new List<string>() { "Mango"},
                    "Mango Smoothie"
                },
                new object[] {
                    new List<string>() { "Strawberries", "Apple", "Banana", "Blueberries" },
                    "Apple Banana Blueberry Strawberry Fusion"
                }
            };
        
        public static IEnumerable<object[]> GetCostData =>
            new List<object[]>
            {
                new object[] {
                    new List<string>() { "Strawberries", "Banana", "Blueberries" },
                    "$3.00"
                },
                new object[] {
                    new List<string>() { "Banana"},
                    "$0.50"
                },
                new object[] {
                    new List<string>() { "Mango"},
                    "$2.50"
                },
                new object[] {
                    new List<string>() { "Strawberries", "Apple", "Banana", "Blueberries" },
                    "$4.75"
                }
            };

        public static IEnumerable<object[]> GetPriceData =>
            new List<object[]>
            {
                new object[] {
                    new List<string>() { "Strawberries", "Banana", "Blueberries" },
                    "$7.50"
                },
                new object[] {
                    new List<string>() { "Banana"},
                    "$1.25"
                },
                new object[] {
                    new List<string>() { "Mango"},
                    "$6.25"
                },
                new object[] {
                    new List<string>() { "Strawberries", "Apple", "Banana", "Blueberries" },
                    "$11.88"
                }
            };
    }
}
