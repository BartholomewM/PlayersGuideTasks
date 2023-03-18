// See https://aka.ms/new-console-template for more information

using Inventory;

class Program {
	public static void Main(String[] args) {
		//InventoryItem[] lst = new InventoryItem[10];

		//bool x = (lst[3] is null);
		//Console.WriteLine(x);

		Pack myBackpack = new Pack(n: 6, maxVol: 13.05, maxWeight: 9.1);
		InventoryItem arrow = new Arrow();
		InventoryItem bow = new Bow();
		InventoryItem rope = new Rope();
		InventoryItem water = new Water();
		InventoryItem food = new FoodRations();

		myBackpack.Add(arrow);
	}
}
