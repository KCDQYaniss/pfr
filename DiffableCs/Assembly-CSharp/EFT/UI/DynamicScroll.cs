namespace EFT.UI;

public class DynamicScroll : MonoBehaviour
{
	[SerializeField]
	private int _visibleCount; //Field offset: 0x20
	[SerializeField]
	private VerticalLayoutGroup _layoutGroup; //Field offset: 0x28
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x30
	[SerializeField]
	private List _activeElements; //Field offset: 0x38
	[SerializeField]
	private List _disabledElements; //Field offset: 0x40
	private readonly SortedList _allElements; //Field offset: 0x48
	private int _visibleIndex; //Field offset: 0x50
	private Nullable _rectYSize; //Field offset: 0x54

	private Nullable RectYSize
	{
		private get { } //Length: 328
	}

	public DynamicScroll() { }

	[CompilerGenerated]
	private void <Start>b__10_0(Vector2 arg) { }

	protected override void Disable(DynamicScrollElement scrollElement, EArrangement arrangement) { }

	protected override void Enable(DynamicScrollElement scrollElement, EArrangement arrangement) { }

	private Nullable get_RectYSize() { }

	[CanBeNull]
	private DynamicScrollElement GetFirstVisible() { }

	private KeyValuePair GetVisibleStatus(DynamicScrollElement element) { }

	private void SetValues() { }

	private void Start() { }

	private void Update() { }

}

