using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Metrics;
using System;
using Inventory;


namespace PackingInventoryTest {
	[TestClass]
	public class TestInventoryItem {
		[TestMethod]
		public void TestWeight() {
			InventoryItem it = new Arrow();

			Assert.AreEqual(0.1, it.Weight);
		}

		[TestMethod]
		public void TestVolume() {
			InventoryItem it = new Arrow();

			Assert.AreEqual(0.05, it.Volume);
		}
	}

	[TestClass]
	public class TestPackProperty {
		[TestMethod]
		public void TestCount() {
			InventoryItem arrow = new Arrow();
			Pack myBackpack = new Pack(n: 10, maxVol: 13.05, maxWeight: 9.1);
			myBackpack.Add(arrow);

			Assert.AreEqual((uint)1, myBackpack.Count);
		}

		[TestMethod]
		public void TestAddVolume() {
			InventoryItem arrow = new Arrow();
			Pack myBackpack = new Pack(n: 10, maxVol: 13.05, maxWeight: 9.1);
			myBackpack.Add(arrow);

			Assert.AreEqual(0.05, myBackpack.CurrentVolume);
		}

		[TestMethod]
		public void TestAddWeight() {
			InventoryItem arrow = new Arrow();
			Pack myBackpack = new Pack(n: 10, maxVol: 13.05, maxWeight: 9.1);
			myBackpack.Add(arrow);

			Assert.AreEqual(0.1, myBackpack.CurrentWeight);
		}

		[TestMethod]
		public void TestInitN() {
			Pack myBackpack = new Pack(n: 10, maxVol: 13.05, maxWeight: 9.1);

			Assert.AreEqual(myBackpack.PackSize, 10);
		}

		//[TestMethod]
		//public void TestRemove() {

		//}
	}


	[TestClass]
	public class TestAddBasic {
		[TestMethod]
		public void TestAddFalse() {
			Pack myBackpack = new Pack(n: 2, maxVol: 20, maxWeight: 20);
			InventoryItem arrow = new Arrow();
			InventoryItem bow = new Bow();

			var a = myBackpack.Add(arrow);
			var b = myBackpack.Add(bow);
			var c = myBackpack.Add(bow);

			Assert.AreEqual(true, a);
			Assert.AreEqual(true, b);
			Assert.AreEqual(false, c);
		}

		[TestMethod]
		public void TestAddTrue() {
			InventoryItem arrow = new Arrow();
			Pack myBackpack = new Pack(n: 10, maxVol: 13.05, maxWeight: 9.1);
			bool x = myBackpack.Add(arrow);

			Assert.AreEqual(true, x);
		}

		
	}

	[TestClass]
	public class TestBigAdd {

		[TestMethod]
		public void TestPerfectSituation() {
			Pack myBackpack = new Pack(n: 6, maxVol: 20, maxWeight: 20);
			InventoryItem arrow = new Arrow();
			InventoryItem bow = new Bow();
			InventoryItem rope = new Rope();
			InventoryItem water = new Water();
			InventoryItem food = new FoodRations();
			InventoryItem sword = new Sword();

			myBackpack.Add(arrow);
			myBackpack.Add(bow);
			myBackpack.Add(rope);
			myBackpack.Add(water);
			myBackpack.Add(food);
			myBackpack.Add(sword);

			double expectedVol = arrow.Volume + bow.Volume + rope.Volume + water.Volume + food.Volume + sword.Volume;
			double expectedWeight = arrow.Weight + bow.Weight + rope.Weight + water.Weight + food.Weight + sword.Weight;

			double actualVol = myBackpack.CurrentVolume;
			double actualWeight = myBackpack.CurrentWeight;

			Assert.AreEqual(expectedVol, actualVol);
			Assert.AreEqual(expectedWeight, actualWeight);
		}
	}
}