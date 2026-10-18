namespace UI.Hideout;

public sealed class HideoutCustomizationSlotsGroupView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public HideoutCustomizationSlotsGroupView <>4__this; //Field offset: 0x10
		public Action slotClickHandler; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal bool <Show>b__0(Item itemToTest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public Slot slot; //Field offset: 0x10
		public HideoutCustomizationOffer offer; //Field offset: 0x18
		public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass5_1() { }

		internal void <Show>b__1(Item selectedItem) { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_2
	{
		public HideoutCustomizationSlotItemSelectionCell selector; //Field offset: 0x10

		public <>c__DisplayClass5_2() { }

		internal void <Show>b__3() { }

	}

	[CompilerGenerated]
	private struct <Show>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationSlotsGroupView <>4__this; //Field offset: 0x20
		public Action slotClickHandler; //Field offset: 0x28
		public Dictionary offerSlotAssociation; //Field offset: 0x30
		public Action onSlotItemSelectionChangedAction; //Field offset: 0x38
		public Func canSelect; //Field offset: 0x40
		private <>c__DisplayClass5_0 <>8__1; //Field offset: 0x48
		private Enumerator <>7__wrap1; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private HideoutCustomizationSlotItemSelectionCell _itemSelectionCellTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _cellsContainer; //Field offset: 0x78
	private List _selectionCells; //Field offset: 0x80
	private Action _onSlotItemSelectionChangedAction; //Field offset: 0x88
	private Func _canSelect; //Field offset: 0x90

	public HideoutCustomizationSlotsGroupView() { }

	private bool CanSelect(Item itemToTest) { }

	private void OnItemSelectionChanged(ItemAddress address, Item selectedItem) { }

	public void SetInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<Show>d__5))]
	public Task Show(Dictionary offerSlotAssociation, Action onSlotItemSelectionChangedAction, Func canSelect, Action slotClickHandler) { }

}

