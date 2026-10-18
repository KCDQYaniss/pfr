namespace EFT.UI.WeaponModding;

public sealed class DropDownMenu : UIElement
{
	[CompilerGenerated]
	private sealed class <<Show>g__CrtDelayOverlap|24_0>d : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DropDownMenu <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <<Show>g__CrtDelayOverlap|24_0>d(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public ItemView itemView; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal void <CreateDropdownModdingItemView>b__0() { }

	}

	[SerializeField]
	private RectTransform _noneItemContainer; //Field offset: 0x70
	[SerializeField]
	private EmptyItemView _emptyItemViewTemplate; //Field offset: 0x78
	[SerializeField]
	private RectTransform _itemsContainer; //Field offset: 0x80
	private float _bottomMargin; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnMenuOpen; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnMenuClosed; //Field offset: 0x98
	private ModdingScreenSlotView _slotView; //Field offset: 0xA0
	private ItemUiContext _itemUiContext; //Field offset: 0xA8
	private readonly List _itemsCollection; //Field offset: 0xB0
	private bool _overlapping; //Field offset: 0xB8
	private Vector2 _cachedViewPosition; //Field offset: 0xBC
	private readonly Vector2 _overlapDelta; //Field offset: 0xC4
	[CompilerGenerated]
	private bool <Open>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private ModdingSelectableItemContext <ItemContext>k__BackingField; //Field offset: 0xD0

	public event Action OnMenuClosed
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnMenuOpen
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private ModdingSelectableItemContext ItemContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool Open
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public DropDownMenu() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<Show>g__CrtDelayOverlap|24_0>d))]
	private IEnumerator <Show>g__CrtDelayOverlap|24_0() { }

	[CompilerGenerated]
	public void add_OnMenuClosed(Action value) { }

	[CompilerGenerated]
	public void add_OnMenuOpen(Action value) { }

	public virtual void Close() { }

	private void CreateDropdownModdingItemView(SelectableItemContext sourceContext, Item item, ItemController itemController, RectTransform container) { }

	[CompilerGenerated]
	public ModdingSelectableItemContext get_ItemContext() { }

	[CompilerGenerated]
	public bool get_Open() { }

	[CompilerGenerated]
	public void remove_OnMenuClosed(Action value) { }

	[CompilerGenerated]
	public void remove_OnMenuOpen(Action value) { }

	[CompilerGenerated]
	private void set_ItemContext(ModdingSelectableItemContext value) { }

	[CompilerGenerated]
	private void set_Open(bool value) { }

	public void Show(ModdingSelectableItemContext itemContext, ModdingScreenSlotView slotView, ItemController itemController) { }

	public bool TryGetOverlappedSlot(out ModdingScreenSlotView lockedSlot) { }

	private void Update() { }

	private void UpdatePosition() { }

	public void ValidateOverlapping() { }

}

