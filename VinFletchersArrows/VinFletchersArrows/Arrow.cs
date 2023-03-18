namespace VinFletchersArrows; 


public class Arrow {
	private ArrowHeadType _headType;
	private FletchingType _feathers;
	private float _length;

	public ArrowHeadType HeadType { get => _headType; }
	public FletchingType Feathers { get => _feathers; }
	public float Length { get => _length; }

	public Arrow(ArrowHeadType ht, FletchingType ft, float lt) {
		_feathers = ft;
		_headType = ht;
		_length = lt;

		if (_length > 100) {
			_length = 100;
		}
		else if (_length < 60) {
			_length = 60;
		}
	}
}


public enum ArrowHeadType { Steel, Wood, Obsidian }
public enum FletchingType { Plastic, Turkey, Goose }

