namespace EFT.UI.DragAndDrop;

public class TemplatedGridsView : ContainedGridsView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public GridView view; //Field offset: 0x10
		public LocalizedFilterButton button; //Field offset: 0x18
		public TemplatedGridsView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public SlotView view; //Field offset: 0x10
		public LocalizedFilterButton button; //Field offset: 0x18
		public TemplatedGridsView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass13_1() { }

		internal void <Show>b__2() { }

	}

	[SerializeField]
	private GridView[] _presetGridViews; //Field offset: 0x80
	[SerializeField]
	private SlotView[] _presetSlotViews; //Field offset: 0x88
	[SerializeField]
	private Dictionary _gridButtons; //Field offset: 0x90
	[SerializeField]
	private Dictionary _slotButtons; //Field offset: 0x98
	[SerializeField]
	private LocalizedFilterButton _generalSortButton; //Field offset: 0xA0
	[SerializeField]
	public Transform SwitchZoneTabsPosition; //Field offset: 0xA8
	[SerializeField]
	public TMP_Text MaxItemsText; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnItemFilter; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnAllItemFilter; //Field offset: 0xC0

	public event Action OnAllItemFilter
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnItemFilter
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public TemplatedGridsView() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	[CompilerGenerated]
	public void add_OnAllItemFilter(Action value) { }

	[CompilerGenerated]
	public void add_OnItemFilter(Action value) { }

	[CompilerGenerated]
	public void remove_OnAllItemFilter(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemFilter(Action value) { }

	public virtual void Show(CompoundItem compoundItem, ItemContext itemContext, ItemController itemController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false) { }

}

