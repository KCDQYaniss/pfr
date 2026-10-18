namespace EFT.UI;

public sealed class GridSpanLayoutGroup : LayoutGroup
{
	[SerializeField]
	private Vector2 _cellSize; //Field offset: 0x60
	[SerializeField]
	private Vector2 _spacing; //Field offset: 0x68
	[SerializeField]
	private int _columns; //Field offset: 0x70
	private readonly List _occupiedCells; //Field offset: 0x78

	public GridSpanLayoutGroup() { }

	private void Arrange() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	private RectInt FindFreeCell(int columns, int rows) { }

	private int GetRequiredRows() { }

	private static Vector2Int GetSize(RectTransform child) { }

	private bool IntersectsOccupied(RectInt cell) { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

