namespace EFT.UI.Utilities.LightScroller;

public sealed class LightScroller : UIElement, IScrollHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0`2
	{
		public LightScrollerViewFactory viewTemplateFactory; //Field offset: 0x0
		public LightScrollerDataTypeGetter dataTypeGetter; //Field offset: 0x0
		public LightScroller <>4__this; //Field offset: 0x0
		public RectTransform cacheStorage; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0
		public BindableList data; //Field offset: 0x0

		public <>c__DisplayClass49_0`2() { }

		internal ICollectionCache <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_1`2
	{
		public CollectionCache cache; //Field offset: 0x0
		public <>c__DisplayClass49_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass49_1`2() { }

		internal UIElement <Show>b__2(int index) { }

		internal Nullable <Show>b__3(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0`2
	{
		public LightScrollerViewFactory viewTemplateFactory; //Field offset: 0x0
		public LightScroller <>4__this; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0
		public BindableList data; //Field offset: 0x0

		public <>c__DisplayClass50_0`2() { }

		internal ICollectionCache <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_1`2
	{
		public CollectionCache cache; //Field offset: 0x0
		public <>c__DisplayClass50_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass50_1`2() { }

		internal UIElement <Show>b__1(int index) { }

		internal Nullable <Show>b__2(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0`1
	{
		public LightScroller <>4__this; //Field offset: 0x0
		public BindableList data; //Field offset: 0x0

		public <>c__DisplayClass51_0`1() { }

		internal void <Show>b__3() { }

		internal void <Show>g__ItemChangedHandler|0(TItemType _) { }

		internal void <Show>g__ItemsAddedHandler|1(IEnumerable _) { }

		internal void <Show>g__UpdateItems|2() { }

	}

	private sealed class CollectionCache`2 : ICollectionCache, IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action <>9__15_0; //Field offset: 0x0
			public static Action <>9__17_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <Dispose>b__17_0(ItemCache cachedItem) { }

			internal void <MarkAsDeprecated>b__15_0(ItemCache cachedItem) { }

		}

		private sealed class ItemCache : IDisposable
		{
			public readonly TItemType Item; //Field offset: 0x0
			public readonly TViewType ItemView; //Field offset: 0x0
			public bool Deprecated; //Field offset: 0x0

			public ItemCache(TItemType item, TViewType itemView) { }

			public override void Dispose() { }

			public void Recycle() { }

		}

		private readonly LightScrollerViewFactory _viewTemplateFactory; //Field offset: 0x0
		private readonly LightScrollerDataTypeGetter _dataTypeGetter; //Field offset: 0x0
		private readonly RectTransform _container; //Field offset: 0x0
		private readonly RectTransform _rebuildContainer; //Field offset: 0x0
		private readonly RectTransform _storage; //Field offset: 0x0
		private readonly List _viewCache; //Field offset: 0x0
		private readonly Dictionary _recycledCache; //Field offset: 0x0
		private readonly Action _showAction; //Field offset: 0x0
		private readonly bool _recycle; //Field offset: 0x0

		public CollectionCache`2(LightScrollerViewFactory viewTemplateFactory, LightScrollerDataTypeGetter dataTypeGetter, RectTransform container, RectTransform rebuildContainer, RectTransform storage, Action showAction) { }

		public CollectionCache`2(LightScrollerViewFactory viewTemplateFactory, RectTransform container, RectTransform rebuildContainer, Action showAction) { }

		public override void CleanDeprecated() { }

		public override void Dispose() { }

		private ItemCache FindCache(TItemType item, bool deprecated) { }

		public TViewType GetItemView(TItemType item) { }

		public Nullable GetViewSize(TItemType item) { }

		public override void MarkAsDeprecated() { }

	}

	internal enum EScrollbarVisibilityEnum
	{
		Always = 0,
		IfNecessary = 1,
		Never = 2,
	}

	internal enum EScrollDirection
	{
		Vertical = 0,
		Horizontal = 1,
	}

	internal enum EScrollOrder
	{
		Straight = 0,
		Reversed = 1,
	}

	private interface ICollectionCache : IDisposable
	{

		public void CleanDeprecated() { }

		public void MarkAsDeprecated() { }

	}

	internal sealed class LightScrollerDataTypeGetter`2 : MulticastDelegate
	{

		public LightScrollerDataTypeGetter`2(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TDataType data, AsyncCallback callback, object object) { }

		public override TDataTypeEnum EndInvoke(IAsyncResult result) { }

		public override TDataTypeEnum Invoke(TDataType data) { }

	}

	internal sealed class LightScrollerViewFactory`2 : MulticastDelegate
	{

		public LightScrollerViewFactory`2(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TDataType data, AsyncCallback callback, object object) { }

		public override TViewType EndInvoke(IAsyncResult result) { }

		public override TViewType Invoke(TDataType data) { }

	}

	[SerializeField]
	private EScrollDirection _direction; //Field offset: 0x70
	[SerializeField]
	private EScrollOrder _order; //Field offset: 0x74
	[SerializeField]
	private EScrollbarVisibilityEnum _scrollBarVisibility; //Field offset: 0x78
	[SerializeField]
	private RectTransform _targetArea; //Field offset: 0x80
	[SerializeField]
	private Scrollbar _scrollbar; //Field offset: 0x88
	[SerializeField]
	private RectOffset _padding; //Field offset: 0x90
	[SerializeField]
	private float _spacing; //Field offset: 0x98
	[SerializeField]
	private TextAnchor _childAlignment; //Field offset: 0x9C
	[Range(1, 500)]
	[SerializeField]
	private float _scrollSpeedPixels; //Field offset: 0xA0
	[Range(1, 500)]
	[SerializeField]
	private float _defaultViewSize; //Field offset: 0xA4
	private bool _initialized; //Field offset: 0xA8
	private bool _active; //Field offset: 0xA9
	private RectTransform _content; //Field offset: 0xB0
	private RectTransform _rebuildContainer; //Field offset: 0xB8
	private ICollectionCache _cache; //Field offset: 0xC0
	private bool _hasScrollBar; //Field offset: 0xC8
	private int _currentItemIndex; //Field offset: 0xCC
	private Vector2 _targetSize; //Field offset: 0xD0
	private float _scrollPosition; //Field offset: 0xD8
	private int _itemsCount; //Field offset: 0xDC
	private readonly List _viewSizes; //Field offset: 0xE0
	private float _totalSize; //Field offset: 0xE8
	private float _contentSize; //Field offset: 0xEC
	private float _paddedContentSize; //Field offset: 0xF0
	private bool _justUpdated; //Field offset: 0xF4
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"FirstPadding", "SecondPadding"})]
	private ValueTuple _paddings; //Field offset: 0xF8
	private bool _updateRequired; //Field offset: 0x100
	private bool _scrollBarActive; //Field offset: 0x101
	private Func _viewGetter; //Field offset: 0x108
	private Func _viewSizeGetter; //Field offset: 0x110
	[CompilerGenerated]
	private float <NormalizedScrollPosition>k__BackingField; //Field offset: 0x118

	public private float NormalizedScrollPosition
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	private float ScrollPosition
	{
		private get { } //Length: 9
		private set { } //Length: 221
	}

	public LightScroller() { }

	[CompilerGenerated]
	private float <UpdateContent>g__AddView|56_1(int itemIndex, bool putFirst) { }

	[CompilerGenerated]
	private bool <UpdateContent>g__CheckItemIndex|56_0(int index) { }

	public void ApplyScrollCommand(ECommand command) { }

	public virtual void Close() { }

	[CompilerGenerated]
	public float get_NormalizedScrollPosition() { }

	private float get_ScrollPosition() { }

	private float GetPaddedViewSize(int itemIndex, float transformSize) { }

	private float GetSize(RectTransform rectTransform) { }

	private float GetValue(Vector2 vector) { }

	private void Init() { }

	private void OnEnable() { }

	public override void OnScroll(PointerEventData eventData) { }

	private void Scroll(float deltaPixels) { }

	[CompilerGenerated]
	private void set_NormalizedScrollPosition(float value) { }

	private void set_ScrollPosition(float value) { }

	public void SetScrollPosition(float position) { }

	private void Show(BindableList data, Func cacheFactory) { }

	public void Show(BindableList data, LightScrollerViewFactory viewTemplateFactory, Action showAction) { }

	public void Show(BindableList data, LightScrollerViewFactory viewTemplateFactory, LightScrollerDataTypeGetter dataTypeGetter, Action showAction) { }

	private void Update() { }

	private void UpdateContent() { }

	private void UpdateScrollBar() { }

}

