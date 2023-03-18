using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {


	public class InventoryItem {
		public double Weight { get; init; }
		public double Volume { get; init; }

		public InventoryItem(double weight, double volume) {
			Weight = weight;
			Volume = volume;
		}

	}


	public class Arrow : InventoryItem {
		public Arrow() : base(0.1, 0.05) { }
		public override string ToString() {
			return "";
		}
		//public Arrow(float weight, float volume) : base(weight: weight, volume: volume) { }
	}


	public class Bow : InventoryItem {
		public Bow() : base(1, 4) { }

	}


	public class Rope : InventoryItem {
		public Rope() : base(1, 1.5) { }
	}


	public class Water : InventoryItem {
		public Water() : base(weight: 2, volume: 3) { }
	}


	public class FoodRations : InventoryItem {
		public FoodRations() : base(1, 05) { }
	}


	public class Sword : InventoryItem {
		public Sword() : base(weight: 5, volume: 3) { }
	}


	public class Pack {
		private double _maxWeight;
		private double _maxVolume;
		private InventoryItem[] _backpack;

		private double _currWeight = 0;
		private double _currVolume = 0;
		private uint _currIndex = 0;

		public uint Count { get => _currIndex; }
		public double CurrentVolume { get => _currVolume; }
		public double CurrentWeight { get => _currWeight; }
		public int PackSize { get => _backpack.Length; }
		public double MaxWeight { get => _maxWeight; }
		public double MaxVolume { get => _maxVolume; }


		public Pack(uint n, double maxVol, double maxWeight) {
			_maxVolume = maxVol;
			_maxWeight = maxWeight;

			if (n == 0) {
				_backpack = new InventoryItem[10];
			}
			else {
				_backpack = new InventoryItem[n];
			}
		}


		public bool Add(InventoryItem item) {
			int len = _backpack.Length;


			if (_backpack[_currIndex] is null) {
				double weight = item.Weight;
				double volume = item.Volume;
				double newWeight = weight + _currWeight;
				double newVolume = volume + _currVolume;


				if ((newWeight <= _maxWeight) && (newVolume <= _maxVolume)) {
					_backpack[_currIndex] = item;

					_currWeight = newWeight;
					_currVolume = newVolume;

					if ((_currIndex + 1) < len) {
						_currIndex += 1;
					}

					return true;
				}

				return false;
			}

			return false;
		}
	}
}
