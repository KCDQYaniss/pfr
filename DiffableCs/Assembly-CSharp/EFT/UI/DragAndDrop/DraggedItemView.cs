namespace EFT.UI.DragAndDrop;

public sealed class DraggedItemView : MonoBehaviour
{
	[SerializeField]
	private Image _mainImage; //Field offset: 0x20
	private Item _item; //Field offset: 0x28
	private ItemIcon _itemIcon; //Field offset: 0x30
	private Action _iconSubscription; //Field offset: 0x38
	private RectTransform _rectTransform; //Field offset: 0x40
	private ItemUiContext _uiContext; //Field offset: 0x48
	private IContainerView _currentContainerUnderCursor; //Field offset: 0x50
	private ItemContext _currentTargetItemContext; //Field offset: 0x58
	private LocationInGrid _currentLocationInGrid; //Field offset: 0x60
	[CompilerGenerated]
	private DragItemContext <ItemContext>k__BackingField; //Field offset: 0x68
	private ScrollRect _scroll; //Field offset: 0x70
	private Vector2 _scrollDifNormalized; //Field offset: 0x78
	private Nullable _scrollTime; //Field offset: 0x80

	public private DragItemContext ItemContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private RectTransform RectTransform
	{
		private get { } //Length: 443
	}

	public DraggedItemView() { }

	private DraggedItemView Construct(ItemContext originalItemContext, ItemRotation itemRotation, Color imageColor, ItemUiContext itemUiContext) { }

	public static DraggedItemView Create(ItemContext originalItemContext, ItemRotation itemRotation, Color imageColor, ItemUiContext itemUiContext) { }

	[CompilerGenerated]
	public DragItemContext get_ItemContext() { }

	private RectTransform get_RectTransform() { }

	public void Kill() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void OnDrag(PointerEventData eventData) { }

	private void OnIconChanged() { }

	private void RotateAccordingUnderCursorContext(ItemRotation targetRotation) { }

	private void RotateByInput() { }

	private void RotateItem(ItemRotation rotation) { }

	[CompilerGenerated]
	private void set_ItemContext(DragItemContext value) { }

	private void SetInCenter() { }

	private void TryScroll(PointerEventData eventData) { }

	public void Update() { }

	private void UpdateRotation() { }

	private void UpdateScroll() { }

	public void UpdateTargetUnderCursor(IContainerView containerUnderCursor, ItemContext itemUnderCursor) { }

}

