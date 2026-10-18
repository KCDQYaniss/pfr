namespace EFT.UI;

[UsedImplicitly]
public sealed class ItemsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public BackEndInventoryController backendController; //Field offset: 0x10
		public ItemsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public ItemsPanel <>4__this; //Field offset: 0x10
		public ItemContext equipmentContext; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal void <UpdateEquipment>b__0() { }

	}

	[CompilerGenerated]
	private struct <Show>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemsPanel <>4__this; //Field offset: 0x20
		public IEftSession session; //Field offset: 0x28
		public InventoryController inventoryController; //Field offset: 0x30
		public IHealthController health; //Field offset: 0x38
		public Profile profile; //Field offset: 0x40
		public InsuranceCompany insurance; //Field offset: 0x48
		public bool isInventoryBlocked; //Field offset: 0x50
		public EItemsTab currentTab; //Field offset: 0x54
		public EquipmentBuildsStorage buildsStorage; //Field offset: 0x58
		public InventoryEquipment equipment; //Field offset: 0x60
		public ItemContext sourceContext; //Field offset: 0x68
		public bool inRaid; //Field offset: 0x70
		public CompoundItem lootItem; //Field offset: 0x78
		public SortingTable sortingTable; //Field offset: 0x80
		public EStashSearchAvailability searchAvailability; //Field offset: 0x88
		private TaskAwaiter <>u__1; //Field offset: 0x90
		private YieldAwaiter <>u__2; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateEquipment>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemsPanel <>4__this; //Field offset: 0x20
		public ItemContext sourceContext; //Field offset: 0x28
		public InventoryEquipment inventoryEquipment; //Field offset: 0x30
		public bool inRaid; //Field offset: 0x38
		public bool splitInFrames; //Field offset: 0x39
		private <>c__DisplayClass27_0 <>8__1; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EItemsTab
	{
		Gear = 0,
		Health = 1,
	}

	internal sealed class ItemsTabController : UIElementTabController
	{
		[CompilerGenerated]
		private struct <TryHide>d__15 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public ItemsTabController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly InventoryController _inventoryController; //Field offset: 0x18
		private readonly IEftSession _session; //Field offset: 0x20
		private readonly CompoundItem _lootItem; //Field offset: 0x28
		private readonly ItemContext _sourceContext; //Field offset: 0x30
		private readonly IHealthController _health; //Field offset: 0x38
		private readonly InsuranceCompany _insurance; //Field offset: 0x40
		private readonly EItemsTab _currentTab; //Field offset: 0x48
		private readonly EquipmentBuildsStorage _buildStorage; //Field offset: 0x50
		private readonly bool _inRaid; //Field offset: 0x58
		private readonly SortingTable _sortingTable; //Field offset: 0x60
		private readonly bool _inventoryBlocked; //Field offset: 0x68
		private readonly Profile _profile; //Field offset: 0x70
		private readonly EStashSearchAvailability _searchAvailability; //Field offset: 0x78

		public ItemsTabController(ItemsPanel itemsTab, ItemContext sourceContext, CompoundItem lootItem, IEftSession session, InventoryController inventoryController, IHealthController health, Profile profile, InsuranceCompany insurance, EquipmentBuildsStorage buildsStorage, EItemsTab currentTab, bool inRaid, SortingTable sortingTable, EStashSearchAvailability searchAvailability, bool inventoryBlocked) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0() { }

		public virtual void Show() { }

		[AsyncStateMachine(typeof(<TryHide>d__15))]
		public virtual Task TryHide() { }

	}

	[SerializeField]
	private SimpleStashPanel _simpleStashPanel; //Field offset: 0x70
	[SerializeField]
	private ComplexStashPanel _complexStashPanel; //Field offset: 0x78
	[SerializeField]
	private HealthParametersPanel _healthParametersPanel; //Field offset: 0x80
	[SerializeField]
	private EquipmentBuildPanel _equipmentBuildPanel; //Field offset: 0x88
	[SerializeField]
	private EquipmentTab _equipmentPanel; //Field offset: 0x90
	[SerializeField]
	private InventoryScreenHealthPanel _healthPanel; //Field offset: 0x98
	[SerializeField]
	private ContainersPanel _containers; //Field offset: 0xA0
	[SerializeField]
	private InventoryScreenQuickAccessPanel _quickUse; //Field offset: 0xA8
	[SerializeField]
	private GameObject _equipmentPartBlocker; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnBackButtonClick; //Field offset: 0xC0
	public bool SplitInFrames; //Field offset: 0xC8
	private EItemsTab _currentTab; //Field offset: 0xCC
	private IEftSession _session; //Field offset: 0xD0
	private InventoryController _inventoryController; //Field offset: 0xD8
	private ItemUiContext _itemUiContext; //Field offset: 0xE0
	private SkillManager _skills; //Field offset: 0xE8
	private Inventory _inventory; //Field offset: 0xF0
	private InsuranceCompany _insurance; //Field offset: 0xF8
	private IHealthController _health; //Field offset: 0x100
	private Profile _profile; //Field offset: 0x108
	private bool _wasClosed; //Field offset: 0x110

	public event Action OnBackButtonClick
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public ItemsPanel() { }

	[CompilerGenerated]
	private void <Show>b__26_0() { }

	[CompilerGenerated]
	private void <Show>b__26_1() { }

	[CompilerGenerated]
	public void add_OnBackButtonClick(Action value) { }

	[CompilerGenerated]
	public void remove_OnBackButtonClick(Action value) { }

	[AsyncStateMachine(typeof(<Show>d__26))]
	public Task Show(ItemContext sourceContext, CompoundItem lootItem, IEftSession session, InventoryController inventoryController, IHealthController health, Profile profile, InsuranceCompany insurance, EquipmentBuildsStorage buildsStorage, EItemsTab currentTab, bool inRaid, SortingTable sortingTable, EStashSearchAvailability searchAvailability, bool isInventoryBlocked, InventoryEquipment equipment = null) { }

	[AsyncStateMachine(typeof(<UpdateEquipment>d__27))]
	private Task UpdateEquipment(InventoryEquipment inventoryEquipment, ItemContext sourceContext, bool inRaid, bool splitInFrames) { }

}

