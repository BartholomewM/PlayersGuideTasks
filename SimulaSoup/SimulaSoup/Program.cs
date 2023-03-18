class Program {
	public static void Main(String[] args) {
		(FoodType soupType, MainIngredient igredient, Seasoning spice) soup = (FoodType.Stew, MainIngredient.Carrots, Seasoning.Spicy); 		

	}
}



enum FoodType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }

