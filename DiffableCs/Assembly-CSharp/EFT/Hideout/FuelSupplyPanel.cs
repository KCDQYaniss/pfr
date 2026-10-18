namespace EFT.Hideout;

[UsedImplicitly]
public sealed class FuelSupplyPanel : AbstractPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public FuelSelectionCell selector; //Field offset: 0x10
		public FuelSupplyPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal bool <CreateViews>b__0(Item itemToTest) { }

		internal void <CreateViews>b__1(Item selectedItem) { }

		internal void <CreateViews>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public FuelSupplyPanel <>4__this; //Field offset: 0x10
		public ItemSelectionCell itemView; //Field offset: 0x18
		public BarterItem oldItem; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <CanSelect>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private struct <CreateViews>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IConsumer consumer; //Field offset: 0x20
		public FuelSupplyPanel <>4__this; //Field offset: 0x28
		private int <numberOfSlots>5__2; //Field offset: 0x30
		private int <slotIndex>5__3; //Field offset: 0x34
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FuelSupplyPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private YieldAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject _header; //Field offset: 0xA8
	[SerializeField]
	private Transform _fuelTankListContainer; //Field offset: 0xB0
	[SerializeField]
	private FuelSelectionCell _fuelTankTemplate; //Field offset: 0xB8
	private AreaBehaviour _behaviour; //Field offset: 0xC0
	private bool _isGeneratorOn; //Field offset: 0xC8
	private readonly Dictionary _selectedItems; //Field offset: 0xD0
	private ItemSelectionCell[] _selectionCells; //Field offset: 0xD8

	private IConsumer Consumer
	{
		private get { } //Length: 66
	}

	public FuelSupplyPanel() { }

	private bool CanSelect(ItemSelectionCell itemView, Item item) { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<CreateViews>d__10))]
	private Task CreateViews(IConsumer consumer) { }

	private IConsumer get_Consumer() { }

	private void OnConsumableItemChangedHandler(Item item, int index) { }

	private void OnItemSelectionChanged(ItemSelectionCell sender, Item selectedItem) { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__9))]
	public virtual Task ShowContents() { }

}

