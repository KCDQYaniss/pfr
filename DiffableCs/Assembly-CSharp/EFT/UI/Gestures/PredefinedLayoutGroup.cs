namespace EFT.UI.Gestures;

[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public sealed class PredefinedLayoutGroup : LayoutGroup
{
	private enum EAlignment
	{
		Top = 0,
		Right = 1,
		Bottom = 2,
		Left = 3,
	}

	internal interface ICanChangeAlignment
	{

		public void AlignToBottom() { }

		public void AlignToCenter() { }

		public void AlignToLeft() { }

		public void AlignToRight() { }

		public void AlignToTop() { }

	}

	private class SpecialAlignmentNode
	{
		public int ItemId; //Field offset: 0x10
		public EAlignment alignment; //Field offset: 0x14

		public SpecialAlignmentNode() { }

	}

	private static readonly Vector2 _defaultAnchor; //Field offset: 0x0
	[SerializeField]
	private Vector2[] PositionsToCenter; //Field offset: 0x60
	[SerializeField]
	private SpecialAlignmentNode[] _specialAlignment; //Field offset: 0x68
	[SerializeField]
	private bool UpdateSideAlignment; //Field offset: 0x70

	private static PredefinedLayoutGroup() { }

	public PredefinedLayoutGroup() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	private bool TrySetSpecialLayout(RectTransform child) { }

	private void UpdateItemAlignment(RectTransform child, Vector2 anchoredPosition) { }

	private void UpdateLayout() { }

}

