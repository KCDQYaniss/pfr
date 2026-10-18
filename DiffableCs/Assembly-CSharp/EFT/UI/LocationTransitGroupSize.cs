namespace EFT.UI;

public sealed class LocationTransitGroupSize : BattleUIPanel
{
	[SerializeField]
	private Image _template; //Field offset: 0x78
	[SerializeField]
	private RectTransform _container; //Field offset: 0x80
	[SerializeField]
	private Sprite _onSprite; //Field offset: 0x88
	[SerializeField]
	private Sprite _offSprite; //Field offset: 0x90
	private readonly List _items; //Field offset: 0x98

	public LocationTransitGroupSize() { }

	private void EnsureCapacity(int maxSize) { }

	public void Show(int size, int maxSize) { }

}

