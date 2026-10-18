namespace EFT.UI;

public class ResizeTooltip : UIElement
{
	private const int TileSize = 10; //Field offset: 0x0
	private static readonly Color BadColor; //Field offset: 0x0
	[SerializeField]
	private RectTransform _oldTiles; //Field offset: 0x70
	[SerializeField]
	private ColorBlinker _newTiles; //Field offset: 0x78
	[SerializeField]
	private RectTransform _upArrow; //Field offset: 0x80
	[SerializeField]
	private RectTransform _rightArrow; //Field offset: 0x88
	private Vector2 _tooltipOffset; //Field offset: 0x90
	private RectTransform _parentTooltip; //Field offset: 0x98

	private static ResizeTooltip() { }

	public ResizeTooltip() { }

	private static IntVec2 GetTileSize(IntVec2 cellSize) { }

	public void Show(IntVec2 oldSize, IntVec2 newSize, Vector2 tooltipOffset, RectTransform parentTooltip) { }

	private void Update() { }

}

