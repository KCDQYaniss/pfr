namespace EFT.UI;

[UsedImplicitly]
public sealed class HideoutMannequinEquipmentScreen : BaseHideoutAreaTransferItemsScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public CompoundItem originalLootItem; //Field offset: 0x10
		public HideoutMannequinEquipmentScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <SubscribeRemoveItemEvent>g__RemoveHandler|0(RemoveItemEventArgs removeArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public IItemOwner itemOwner; //Field offset: 0x10
		public <>c__DisplayClass17_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass17_1() { }

		internal void <SubscribeRemoveItemEvent>b__1() { }

	}

	internal sealed class HideoutMannequinEquipmentScreenController : BaseHideoutAreaTransferItemsScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__18 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public HideoutMannequinEquipmentScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly IHealthController HealthController; //Field offset: 0x78
		[CompilerGenerated]
		private int <LastSelectedTabIndex>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private CompoundItem <LastShowedEquipment>k__BackingField; //Field offset: 0x88

		public private int LastSelectedTabIndex
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public private CompoundItem LastShowedEquipment
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public virtual bool ShowSortingTable
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public HideoutMannequinEquipmentScreenController(AreaData areaData, IEftSession session, InventoryController inventoryController, IHealthController healthController) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		protected virtual void CloseAction(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__18))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		[CompilerGenerated]
		public int get_LastSelectedTabIndex() { }

		[CompilerGenerated]
		public CompoundItem get_LastShowedEquipment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		public virtual bool get_ShowSortingTable() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		private void set_LastSelectedTabIndex(int value) { }

		[CompilerGenerated]
		private void set_LastShowedEquipment(CompoundItem value) { }

	}

	[SerializeField]
	private EquipmentTab _equipmentPanel; //Field offset: 0x130
	[SerializeField]
	private EquipmentBuildPanel _equipmentBuildPanel; //Field offset: 0x138
	[SerializeField]
	private ContainersPanel _containersPanel; //Field offset: 0x140
	[SerializeField]
	private HealthParameterPanel _weightPanel; //Field offset: 0x148
	private IHealthController _healthController; //Field offset: 0x150
	private InsuranceCompany _insurance; //Field offset: 0x158
	private InventoryEquipment _currentEquipment; //Field offset: 0x160
	private ItemContext _equipmentContext; //Field offset: 0x168
	private ItemContext _areaStashItemContext; //Field offset: 0x170
	private int _lastSelectedTabIndex; //Field offset: 0x178

	protected virtual bool SetAsLastSiblingTabGroup
	{
		 get { } //Length: 3
	}

	public HideoutMannequinEquipmentScreen() { }

	[CompilerGenerated]
	private void <Show>b__14_0() { }

	[CompilerGenerated]
	private void <Show>b__14_1() { }

	[CompilerGenerated]
	private void <Show>b__14_2() { }

	public virtual void Close() { }

	protected virtual bool get_SetAsLastSiblingTabGroup() { }

	private void OnItemAdded(AddItemEventArgs addInfo) { }

	private void OnItemRemoved(RemoveItemEventArgs removeInfo) { }

	public virtual void Show(HideoutMannequinEquipmentScreenController controller) { }

	private void Show(AreaData areaData, InventoryController inventoryController, IHealthController healthController, IEftSession session) { }

	private void SubscribeRemoveItemEvent(CompoundItem originalLootItem) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual void UpdateAreaStashView(AreaData areaData, CompoundItem stash) { }

	private void UpdateEquipment(InventoryEquipment inventoryEquipment) { }

	protected virtual void UpdateTabGroup(int selectedTabIndex) { }

	private void UpdateWeightValue(InventoryEquipment equipment) { }

}

