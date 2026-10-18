namespace EFT.Hideout;

public sealed class SelectItemContextMenu : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public SelectItemContextMenu <>4__this; //Field offset: 0x10
		public Func getDetails; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <GetItem>b__0(Item item, SelectingItemView view) { }

		internal void <GetItem>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public SelectingItemView emptyItem; //Field offset: 0x10

		public <>c__DisplayClass12_1() { }

		internal void <GetItem>b__2() { }

	}

	private struct DirectionSettings
	{
		public int CornerIndex; //Field offset: 0x0
		public Corner StartCorner; //Field offset: 0x4

		public Vector2 DirectionAnchor
		{
			 get { } //Length: 158
		}

		public DirectionSettings(int cornerIndex, Corner startCorner) { }

		public Vector2 get_DirectionAnchor() { }

	}

	private static readonly Dictionary _directionSettings; //Field offset: 0x0
	[SerializeField]
	private RectTransform _container; //Field offset: 0x70
	[SerializeField]
	private RectTransform _parent; //Field offset: 0x78
	[SerializeField]
	private int _maxHeight; //Field offset: 0x80
	[SerializeField]
	private int _maxColumnsCount; //Field offset: 0x84
	private ScrollRectNoDrag _scrollRectNoDrag; //Field offset: 0x88
	private TaskCompletionSource _source; //Field offset: 0x90
	private GridLayoutGroup _grid; //Field offset: 0x98
	private readonly Vector3[] _rootCorners; //Field offset: 0xA0

	private static SelectItemContextMenu() { }

	public SelectItemContextMenu() { }

	private void Awake() { }

	public virtual void Close() { }

	public Task GetItem(IEnumerable availableItems, Func getDetails, bool showEmptyCell, SelectingItemView itemTemplate, RectTransform parentPosition, Vector2 offset, EContextPriorDirection direction) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void SelectItem(Item selectedItem) { }

	private void SetContainerPosition(RectTransform parentPosition, Vector2 offset, EContextPriorDirection direction) { }

}

