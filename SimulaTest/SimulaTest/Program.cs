

class Program {
	public static void Main(String[] args) {
		var chest = new Chest();
		GameLoop(ref chest);
	}

	public static void GameLoop(ref Chest chest) {
		while (true) {
			ReadInstruction(ref chest);
		}

	}

	public static void ReadInstruction(ref Chest chest) {
		string? str = "";

		while (true) {
			Console.WriteLine($"The chest is {chest.ChestState}");
			Console.WriteLine("What do you want to do?");
			str = Console.ReadLine();

			switch (str) {
				case "unlock":
					chest.Unlock(); 
					break;

				case "open":
					chest.Open(); 
					break;

				case "close":
					chest.Close(); 
					break;

				case "lock":
					chest.Lock(); 
					break;

				default:
					Console.WriteLine("Something went wrong");	
					break;
			}
		}
	}
}


class Chest {
	private ChestState _state;
	public ChestState ChestState { get => _state; }

	public Chest() {
		_state = ChestState.Locked;
	}


	public void Unlock() {
		if (_state == ChestState.Locked) {
			_state = ChestState.Closed;
		}
		else {
			Console.WriteLine("You can't do it");
		}
	}


	public void Open() {
		if ( _state == ChestState.Closed) {
			_state = ChestState.Open;
		}
		else {
			Console.WriteLine("You can't do it");
		}
	}


	public void Close() {
		if (_state == ChestState.Open) {
			_state = ChestState.Closed;
		}
		else {
			Console.WriteLine("You can't do it");
		}
	}


	public void Lock() {
		if (_state == ChestState.Closed) {
			_state = ChestState.Locked;
		}
		else {
			Console.WriteLine("You can't do it");
		}
	}
}

enum ChestState { Open, Closed, Locked }