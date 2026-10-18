namespace UnityEngine.UI.Extensions;

[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
public class FlowLayoutGroup : LayoutGroup
{
	public float SpacingX; //Field offset: 0x60
	public float SpacingY; //Field offset: 0x64
	public bool ExpandHorizontalSpacing; //Field offset: 0x68
	public bool ChildForceExpandWidth; //Field offset: 0x69
	public bool ChildForceExpandHeight; //Field offset: 0x6A
	private float _layoutHeight; //Field offset: 0x6C
	private readonly IList _rowList; //Field offset: 0x70

	protected bool IsCenterAlign
	{
		 get { } //Length: 23
	}

	protected bool IsLowerAlign
	{
		 get { } //Length: 23
	}

	protected bool IsMiddleAlign
	{
		 get { } //Length: 23
	}

	protected bool IsRightAlign
	{
		 get { } //Length: 23
	}

	public FlowLayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight) { }

	protected bool get_IsCenterAlign() { }

	protected bool get_IsLowerAlign() { }

	protected bool get_IsMiddleAlign() { }

	protected bool get_IsRightAlign() { }

	public float GetGreatestMinimumChildWidth() { }

	protected void LayoutRow(IList contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis) { }

	public float SetLayout(float width, int axis, bool layoutInput) { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

