[![Points badge](../../blob/badges/.github/badges/points.svg)](../../actions)
# CSIT327 2.3 Smoothie 🥛🍌🍓

## Task

- Smoothie constructor should accept a list of ingredients.
    - Should not be empty => throw `ArgumentException` error
	- Ingredients should not be repeated => throw `ArgumentException` error
	- Ingredients that doesn't exist (**ingredients are CASE SENSITIVE**) => throw `ArgumentException` error
	- Ingredients should not be `null` => throw `ArgumentNullException` error

- Implement `Ingredients` Property
    - Will return a list of all supplied ingredients in the constructor
	- Ingredients should be in alphabetical order A->Z
	- Users should **NOT** be able to set Ingredients explicitly \
	`smoothie.Ingredients = new List<string> {"Bananana"};` ❌

- Implement `Name` Property
     gets the ingredients and puts them in alphabetical order into a nice descriptive sentence.\
	 If there are multiple ingredients, add the word "**Fusion**" to the end but otherwise, add "**Smoothie**". \
	 **Remember to change "-berries" to "-berry"**. See the examples below.
	- Users should **NOT** be able to set Name explicitly \
	`smoothie.Name = "IllegalName";` ❌

- Implement `GetCost` method which calculates the total cost of the ingredients used to make the smoothie. 
    - Round to two decimal places.

- Implement `GetPrice` method which returns the number from `GetCost` plus the number from `GetCost` multiplied by **1.5**.
    -  Round to two decimal places.

|  Ingredient  | Price |
|:------------:|:-----:|
| Strawberries | $1.50 |
| Banana       | $0.50 |
| Mango        | $2.50 |
| Blueberries  | $1.00 |
| Raspberries  | $1.00 |
| Apple        | $1.75 |
| Pineapple    | $3.50 |


## Sample
### Single Ingredient

		s1 = new Smoothie(new List<string> { "Banana" });

		s1.Ingredients ➞ { "Banana" }

		s1.Name ➞ "Banana Smoothie"

		s1.GetCost() ➞ "$0.50"

		s1.GetPrice() ➞ "$1.25"
		

### Multiple Ingredients

		s2 = new Smoothie(new List<string> { "Raspberries", "Strawberries", "Blueberries" });
		
		s2.Ingredients ➞ { "Blueberries", "Raspberries", "Strawberries" }

		s2.Name ➞ "Blueberry Raspberry Strawberry Fusion"
		
		s2.GetCost() ➞ "$3.50"

		s2.GetPrice() ➞ "$8.75"

# Project Repository DO's and DONT's

## DO's ✅
1. Observe DRY. 
2. Make atomic commits. 
3. Apply good commit messages 
4. Document code. 
5. Remove code smells.
6. Remember to push final codes in master.
7. Feel free to add classes and methods.

## DONT'S ❌
Failure to comply on the following will **automatically void your grade** in this exercise: 

1. Do NOT change function signature. 
2. Do NOT touch anything in `.github` folder. 
3. Do NOT edit README.md 
4. Do NOT modify tests in `*.Tests` project.


---
### Prepared by:
Yours Truly,

**Jhon Christian Ambrad** \
jhonchristian.ambrad@cit.edu \
+639761014328
