namespace EFT.UI;

[UsedImplicitly]
public sealed class ItemUiContext : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__201_0; //Field offset: 0x8
		public static Comparison <>9__290_5; //Field offset: 0x10
		public static Func <>9__324_1; //Field offset: 0x18
		public static Func <>9__324_2; //Field offset: 0x20
		public static Func <>9__326_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <CanShowUnloadItemsWindow>b__201_0(Item item) { }

		internal IEnumerable <InstallMod>b__326_1(Weapon weapon) { }

		internal bool <ReloadWeapon>b__324_1(GridItemAddress g) { }

		internal int <ReloadWeapon>b__324_2(GridItemAddress g) { }

		internal int <TopUpItem>b__290_5(Item x, Item y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__239`2
	{
		public static readonly <>c__239 <>9; //Field offset: 0x0
		public static Func <>9__239_2; //Field offset: 0x0

		private static <>c__239`2() { }

		public <>c__239`2() { }

		internal bool <OpenWindow>b__239_2(WindowData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass203_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass203_0() { }

		internal void <ShowMessageWindow>b__0() { }

		internal void <ShowMessageWindow>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass218_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass218_0() { }

		internal void <ShowScrolledMessageWindow>b__0() { }

		internal void <ShowScrolledMessageWindow>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass220_0
	{
		public Action acceptAction; //Field offset: 0x10
		public Action cancelAction; //Field offset: 0x18
		public DialogWindowContext registeredContext; //Field offset: 0x20

		public <>c__DisplayClass220_0() { }

		internal void <ShowMessageWindow>g__AcceptHandler|0() { }

		internal void <ShowMessageWindow>g__CloseHandler|2() { }

		internal void <ShowMessageWindow>g__DeclineHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_0`2
	{
		public ItemUiContext <>4__this; //Field offset: 0x0
		public WindowData windowData; //Field offset: 0x0
		public TContext context; //Field offset: 0x0
		public TWindow window; //Field offset: 0x0

		public <>c__DisplayClass239_0`2() { }

		internal void <OpenWindow>g__CloseHandler|1() { }

		internal void <OpenWindow>g__SelectedHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass245_0
	{
		public TaskCompletionSource source; //Field offset: 0x10
		public DialogWindowContext context; //Field offset: 0x18

		public <>c__DisplayClass245_0() { }

		internal void <SelectHandoverExchangeableItemsAsync>g__DeclineHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass247_0
	{
		public ItemUiContext <>4__this; //Field offset: 0x10
		public string title; //Field offset: 0x18
		public string message; //Field offset: 0x20
		public string imageUrl; //Field offset: 0x28
		public float time; //Field offset: 0x30

		public <>c__DisplayClass247_0() { }

		internal DialogWindowContext <ShowDelayTypeWindow>g__ShowWindow|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass257_0`1
	{
		public ItemUiContext <>4__this; //Field offset: 0x0
		public WindowData windowData; //Field offset: 0x0
		public TContext windowContext; //Field offset: 0x0
		public Window window; //Field offset: 0x0

		public <>c__DisplayClass257_0`1() { }

		internal void <RegisterWindow>g__CloseHandler|1() { }

		internal void <RegisterWindow>g__SelectedHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass280_0
	{
		public ItemContext itemContext; //Field offset: 0x10
		public ItemUiContext <>4__this; //Field offset: 0x18
		public ContextInteractions contextInteractions; //Field offset: 0x20

		public <>c__DisplayClass280_0() { }

		internal WindowContext <Inspect>b__0(InfoWindow window) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass281_0
	{
		public Magazine magazine; //Field offset: 0x10

		public <>c__DisplayClass281_0() { }

		internal bool <FindCompatibleAmmo>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass282_0
	{
		public Slot chamber; //Field offset: 0x10

		public <>c__DisplayClass282_0() { }

		internal bool <FindCompatibleAmmo>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass286_0
	{
		private struct <<LoadAmmoByType>g__LoadStacks|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IReadOnlyList ammo; //Field offset: 0x20
			public <>c__DisplayClass286_0 <>4__this; //Field offset: 0x28
			private IEnumerator <>7__wrap1; //Field offset: 0x30
			private Ammo <ammoStack>5__3; //Field offset: 0x38
			private int <stackCount>5__4; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Magazine magazine; //Field offset: 0x10
		public ItemUiContext <>4__this; //Field offset: 0x18

		public <>c__DisplayClass286_0() { }

		[AsyncStateMachine(typeof(<<LoadAmmoByType>g__LoadStacks|0>d))]
		internal Task <LoadAmmoByType>g__LoadStacks|0(IReadOnlyList ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass287_0
	{
		private struct <<LoadBarrelByType>g__LoadStacks|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IReadOnlyList ammo; //Field offset: 0x20
			public <>c__DisplayClass287_0 <>4__this; //Field offset: 0x28
			private IEnumerator <>7__wrap1; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Weapon weapon; //Field offset: 0x10
		public ItemUiContext <>4__this; //Field offset: 0x18
		public bool loaded; //Field offset: 0x20

		public <>c__DisplayClass287_0() { }

		[AsyncStateMachine(typeof(<<LoadBarrelByType>g__LoadStacks|0>d))]
		internal Task <LoadBarrelByType>g__LoadStacks|0(IReadOnlyList ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass288_0
	{
		private struct <<LoadAmmoFromContainers>g__TryLoad|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CompoundItem container; //Field offset: 0x20
			public <>c__DisplayClass288_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public List ammo; //Field offset: 0x10
		public string ammoTemplateId; //Field offset: 0x18
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Func loadStacks; //Field offset: 0x28

		public <>c__DisplayClass288_0() { }

		[AsyncStateMachine(typeof(<<LoadAmmoFromContainers>g__TryLoad|0>d))]
		internal Task <LoadAmmoFromContainers>g__TryLoad|0(CompoundItem container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass290_0
	{
		private struct <<TopUpItem>g__TopUpFrom|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Item container; //Field offset: 0x20
			public <>c__DisplayClass290_0 <>4__this; //Field offset: 0x28
			private int <i>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Item targetItem; //Field offset: 0x10
		public List sourcesBuffer; //Field offset: 0x18
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Item currentSource; //Field offset: 0x28
		public bool inventoryChanged; //Field offset: 0x30

		public <>c__DisplayClass290_0() { }

		internal bool <TopUpItem>b__4(Item x) { }

		internal bool <TopUpItem>g__ItemIsFull|0() { }

		internal void <TopUpItem>g__RefreshItemEventHandler|2(RefreshItemEventArgs args) { }

		internal void <TopUpItem>g__RemoveItemEventHandler|3(RemoveItemEventArgs args) { }

		[AsyncStateMachine(typeof(<<TopUpItem>g__TopUpFrom|1>d))]
		internal Task <TopUpItem>g__TopUpFrom|1(Item container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass292_0
	{
		public List itemsBuffer; //Field offset: 0x10
		public Item targetItem; //Field offset: 0x18
		public ItemUiContext <>4__this; //Field offset: 0x20

		public <>c__DisplayClass292_0() { }

		internal bool <HasSourcesForTopUp>b__1(Item x) { }

		internal bool <HasSourcesForTopUp>g__HasSources|0(Item container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass293_0
	{
		public Item item; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass293_0() { }

		internal void <Examine>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass304_0
	{
		public TagComponent tagComponent; //Field offset: 0x10
		public ItemUiContext <>4__this; //Field offset: 0x18

		public <>c__DisplayClass304_0() { }

		internal EditTagWindowContext <EditTag>b__0(EditTagWindow window) { }

		internal void <EditTag>g__SaveHandler|1(string tagName, int tagColor) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass304_1
	{
		public EditTagWindowContext context; //Field offset: 0x10
		public <>c__DisplayClass304_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass304_1() { }

		internal void <EditTag>g__CloseHandler|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass310_0
	{
		public ItemContext itemContext; //Field offset: 0x10
		public ItemUiContext <>4__this; //Field offset: 0x18

		public <>c__DisplayClass310_0() { }

		internal WindowContext <OpenInsuranceWindow>b__0(InsuranceWindow window) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass311_0
	{
		public RepairController repairController; //Field offset: 0x10
		public ItemContext itemContext; //Field offset: 0x18
		public ItemUiContext <>4__this; //Field offset: 0x20

		public <>c__DisplayClass311_0() { }

		internal WindowContext <OpenRepairWindow>b__0(RepairWindow window) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass317_0
	{
		public ItemUiContext <>4__this; //Field offset: 0x10
		public int maxUsableAmount; //Field offset: 0x18
		public IHealthController healthController; //Field offset: 0x20
		public FoodDrink foodDrink; //Field offset: 0x28
		public int maxValue; //Field offset: 0x30

		public <>c__DisplayClass317_0() { }

		internal void <ShowSplitMenuDialog>b__0(int amount) { }

		internal void <ShowSplitMenuDialog>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass321_0
	{
		public CompoundItem item; //Field offset: 0x10
		public ItemContext itemContext; //Field offset: 0x18
		public ItemUiContext <>4__this; //Field offset: 0x20

		public <>c__DisplayClass321_0() { }

		internal GridWindowContext <OpenItem>b__0(GridWindow window) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass321_1
	{
		public GridWindowContext context; //Field offset: 0x10
		public <>c__DisplayClass321_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass321_1() { }

		internal void <OpenItem>g__CloseHandler|2() { }

		internal void <OpenItem>g__SelectedHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass324_0
	{
		public ItemUiContext <>4__this; //Field offset: 0x10
		public Magazine foundMagazine; //Field offset: 0x18
		public ItemAddress magSlotAddress; //Field offset: 0x20

		public <>c__DisplayClass324_0() { }

		internal void <ReloadWeapon>b__3(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass324_1
	{
		public Magazine currentMagazine; //Field offset: 0x10

		public <>c__DisplayClass324_1() { }

		internal GridItemAddress <ReloadWeapon>b__0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass326_0
	{
		public ItemUiContext <>4__this; //Field offset: 0x10
		public Mod mod; //Field offset: 0x18
		public Func <>9__2; //Field offset: 0x20

		public <>c__DisplayClass326_0() { }

		internal bool <InstallMod>b__0(Weapon weapon) { }

		internal bool <InstallMod>b__2(Slot slot) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass335_0
	{
		public ItemUiContext <>4__this; //Field offset: 0x0
		public Slot magazineSlot; //Field offset: 0x8
		public Magazine best; //Field offset: 0x10
		public bool bestUnlocked; //Field offset: 0x18
		public int bestCount; //Field offset: 0x1C

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__CompareAmmoForLoad; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <ApplyMagPreset>d__278 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPreset preset; //Field offset: 0x20
		public IReadOnlyCollection magazines; //Field offset: 0x28
		public ItemUiContext <>4__this; //Field offset: 0x30
		private Option <applyResult>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Disassemble>d__328 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public ItemContext itemContext; //Field offset: 0x28
		private Enumerator <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EquipItem>d__318 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InstallMod>d__326 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public ItemContext itemContext; //Field offset: 0x28
		public CompoundItem[] collections; //Field offset: 0x30
		private <>c__DisplayClass326_0 <>8__1; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAmmoByType>d__286 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Magazine magazine; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		public string ammoTemplateId; //Field offset: 0x30
		public Action callback; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAmmoFromContainers>d__288 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string ammoTemplateId; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		public Func loadStacks; //Field offset: 0x30
		private <>c__DisplayClass288_0 <>8__1; //Field offset: 0x38
		public Action callback; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBarrelByType>d__287 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon weapon; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		public string ammoTemplateId; //Field offset: 0x30
		public Action callback; //Field offset: 0x38
		private <>c__DisplayClass287_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWeapon>d__325 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon weapon; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		public CompoundItem[] collections; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QuickMoveFromSortingTable>d__333 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public BackEndInventoryController controller; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunWithSound>d__330 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemController itemController; //Field offset: 0x20
		public OperationResult operationResult; //Field offset: 0x28
		public Callback callback; //Field offset: 0x38
		public Item item; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectItem>d__263 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public IEnumerable availableItems; //Field offset: 0x28
		public Func getDetails; //Field offset: 0x30
		public bool showEmptyCell; //Field offset: 0x38
		public SelectingItemView itemTemplate; //Field offset: 0x40
		public RectTransform elementPosition; //Field offset: 0x48
		public Vector2 offset; //Field offset: 0x50
		public EContextPriorDirection direction; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetPinLockState>d__305 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		public EItemPinLockState state; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowPlayerProfileScreen>d__279 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string accId; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		public Nullable token; //Field offset: 0x30
		public bool isInRaid; //Field offset: 0x40
		public EItemViewType viewType; //Field offset: 0x44
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ThrowItem>d__308 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TopUpItem>d__290 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Item targetItem; //Field offset: 0x28
		public ItemUiContext <>4__this; //Field offset: 0x30
		private <>c__DisplayClass290_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Uninstall>d__316 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public ItemContext itemContext; //Field offset: 0x28
		public bool putInStash; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadAmmo>d__327 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemContext itemContext; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadWeapon>d__323 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon weapon; //Field offset: 0x20
		public ItemUiContext <>4__this; //Field offset: 0x28
		private Magazine <magModInWeapon>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnpackItem>d__291 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemUiContext <>4__this; //Field offset: 0x20
		public Item targetItem; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class WindowData
	{
		private static int _nextIndex; //Field offset: 0x0
		public readonly Item Item; //Field offset: 0x10
		public readonly UIInputNode Window; //Field offset: 0x18
		public readonly Type WindowType; //Field offset: 0x20
		public readonly WindowContext WindowContext; //Field offset: 0x28
		public readonly int Index; //Field offset: 0x30
		public readonly bool Single; //Field offset: 0x34

		public WindowData(Item item, UIInputNode window, Type windowType, bool single, WindowContext windowContext) { }

	}

	[CompilerGenerated]
	private static ItemUiContext <Instance>k__BackingField; //Field offset: 0x0
	private const string MAG_PRESET_LOADING_COMPLETE = "MagPreset/LoadingComplete"; //Field offset: 0x0
	[Header("Tooltips")]
	[SerializeField]
	private SimpleTooltip _simpleTooltip; //Field offset: 0x80
	[SerializeField]
	private ItemTooltip _itemTooltip; //Field offset: 0x88
	[SerializeField]
	private PriceTooltip _priceTooltip; //Field offset: 0x90
	[SerializeField]
	private SkillTooltip _skillTooltip; //Field offset: 0x98
	[SerializeField]
	private CustomizationOfferTooltip _customizationOfferTooltip; //Field offset: 0xA0
	[SerializeField]
	private MasteringTooltip _masteringTooltip; //Field offset: 0xA8
	[SerializeField]
	private MultiLineTooltip _multiLineTooltip; //Field offset: 0xB0
	[SerializeField]
	private CompoundTooltip _compoundTooltip; //Field offset: 0xB8
	[SerializeField]
	private TaskRewardsTooltip _taskRewardsTooltip; //Field offset: 0xC0
	[SerializeField]
	private TaskConditionsTooltip _taskConditionsTooltip; //Field offset: 0xC8
	[SerializeField]
	private AchievementGlobalProgressTooltip _achievementGlobalProgressTooltip; //Field offset: 0xD0
	[SerializeField]
	private LocationBlockedForPlayersTooltip _locationBlockedForPlayersTooltip; //Field offset: 0xD8
	[SerializeField]
	private ExpansionsTooltip _extensionsTooltip; //Field offset: 0xE0
	[SerializeField]
	private TradingOfferTooltip _tradingOfferTooltip; //Field offset: 0xE8
	[Header("Windows")]
	[SerializeField]
	private RepairWindow _repairWindowTemplate; //Field offset: 0xF0
	[SerializeField]
	private InsuranceWindow _insuranceWindowTemplate; //Field offset: 0xF8
	[SerializeField]
	private CaptchaHandler _captchaHandler; //Field offset: 0x100
	[SerializeField]
	private DelayTypeWindow _delayTypeWindow; //Field offset: 0x108
	[SerializeField]
	private TraderDialogConfirmationWindow _dialogChoiceConfirmationWindow; //Field offset: 0x110
	[SerializeField]
	private SeasonalPersonalPerksConfirmationWindow _seasonalPersonalPerksConfirmationWindow; //Field offset: 0x118
	[SerializeField]
	private BrowserWindow _browserWindow; //Field offset: 0x120
	[SerializeField]
	private ItemsListWindow _itemsListWindow; //Field offset: 0x128
	[SerializeField]
	private SplitDialog _splitDialogTemplate; //Field offset: 0x130
	[SerializeField]
	private GridWindow _gridWindowTemplate; //Field offset: 0x138
	[SerializeField]
	private EditTagWindow _editTagWindowTemplate; //Field offset: 0x140
	[SerializeField]
	private StashSearchWindow _stashSearchWindow; //Field offset: 0x148
	[SerializeField]
	private SortingTableWindow _sortingTableWindow; //Field offset: 0x150
	[SerializeField]
	private EquipItemWindow _equipItemWindow; //Field offset: 0x158
	[SerializeField]
	private PlayerEquipmentWindow _playerEquipmentWindow; //Field offset: 0x160
	[SerializeField]
	private ClothingConfirmationWindow _clothingConfirmation; //Field offset: 0x168
	[SerializeField]
	private InspectClothingWindow _clothingInspect; //Field offset: 0x170
	[SerializeField]
	private AssembleBuildWindow _missingBuildItemsWindow; //Field offset: 0x178
	[SerializeField]
	private EditBuildNameWindow _editBuildNameWindow; //Field offset: 0x180
	[SerializeField]
	private MagPresetsWindow _magPresetWindow; //Field offset: 0x188
	[SerializeField]
	private AcceptQuestChangeWindow _acceptQuestChangeWindow; //Field offset: 0x190
	[SerializeField]
	private HandoverQuestItemsWindow _handoverQuestItemsWindow; //Field offset: 0x198
	[SerializeField]
	private HandoverExchangeableItemsWindow _handoverItemsWindow; //Field offset: 0x1A0
	[SerializeField]
	private QuestItemsUnloadWindow _questItemsUnloadWindow; //Field offset: 0x1A8
	[SerializeField]
	private ReadNoteWindow _readNoteWindow; //Field offset: 0x1B0
	[SerializeField]
	private AddOfferWindow _addOfferWindow; //Field offset: 0x1B8
	[SerializeField]
	private RenewOfferWindow _renewOfferWindow; //Field offset: 0x1C0
	[SerializeField]
	private RagfairFilterWindow _ragfairFilterWindow; //Field offset: 0x1C8
	[SerializeField]
	private HandoverRagfairMoneyWindow _handoverRagfairMoneyWindow; //Field offset: 0x1D0
	[SerializeField]
	private GroupInviteWindow _groupInviteWindow; //Field offset: 0x1D8
	[SerializeField]
	private RaidInviteWindow _raidInviteWindow; //Field offset: 0x1E0
	[SerializeField]
	private PlayersInviteWindow _playersInviteWindow; //Field offset: 0x1E8
	[SerializeField]
	private InfoWindow _infoWindowTemplate; //Field offset: 0x1F0
	[SerializeField]
	private MessageWindow _messageWindow; //Field offset: 0x1F8
	[SerializeField]
	private MessageWindow _scrolledMessageWindow; //Field offset: 0x200
	[SerializeField]
	private BattlePassExchangeWindow _battlePassExchangeWindow; //Field offset: 0x208
	[SerializeField]
	private BattlePassUniversalDocumentsHandoverWindow _battlePassUniversalDocumentsHandoverWindow; //Field offset: 0x210
	[Header("Other")]
	[SerializeField]
	private RectTransform _infoWindowsContainer; //Field offset: 0x218
	[SerializeField]
	private WeaponPreviewPool _weaponPreviewPool; //Field offset: 0x220
	[SerializeField]
	private SelectItemContextMenu _selectItemMenu; //Field offset: 0x228
	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x230
	[SerializeField]
	private RectTransform _contextMenuArea; //Field offset: 0x238
	[SerializeField]
	public Transform DragLayer; //Field offset: 0x240
	[SerializeField]
	private SubtitlesAuthorityController _subtitlesAuthorityController; //Field offset: 0x248
	[SerializeField]
	private UiRecorderController _recorderUi; //Field offset: 0x250
	[CompilerGenerated]
	private Action OnEffectsChange; //Field offset: 0x258
	[CompilerGenerated]
	private Action OnInventoryLocked; //Field offset: 0x260
	private readonly HashSet _registeredViews; //Field offset: 0x268
	private DraggedItemView _draggedItemView; //Field offset: 0x270
	private DragItemContext _dragItemContext; //Field offset: 0x278
	private readonly Dictionary _contextMenuCustomNames; //Field offset: 0x280
	private readonly Dictionary _boundIndexes; //Field offset: 0x288
	private readonly List _windows; //Field offset: 0x290
	private ItemController _itemController; //Field offset: 0x298
	private InventoryController _inventoryController; //Field offset: 0x2A0
	private Profile _profile; //Field offset: 0x2A8
	private Inventory _inventory; //Field offset: 0x2B0
	private IHealthController _healthController; //Field offset: 0x2B8
	private CompoundItem[] _rightPanelItem; //Field offset: 0x2C0
	private CompoundItem _leftPanelItem; //Field offset: 0x2C8
	private InsuranceCompany _insuranceCompany; //Field offset: 0x2D0
	private RepairController _repairController; //Field offset: 0x2D8
	private RagFair _ragfair; //Field offset: 0x2E0
	private Trader _trader; //Field offset: 0x2E8
	private InventoryEquipment _equipment; //Field offset: 0x2F0
	private QuestController _questController; //Field offset: 0x2F8
	private SplitDialog _splitDialog; //Field offset: 0x300
	private ECursorResult _contextCursor; //Field offset: 0x308
	private bool _compatibilityCheck; //Field offset: 0x30C
	private readonly Queue _windowQueue; //Field offset: 0x310
	private WindowContext _lastOpenWindowContext; //Field offset: 0x318
	private ContextInteractions _currentContextInteractions; //Field offset: 0x320
	[CompilerGenerated]
	private ItemContextInteractionsSwitcher <ContextInteractionsSwitcher>k__BackingField; //Field offset: 0x328
	[CompilerGenerated]
	private IEftSession <Session>k__BackingField; //Field offset: 0x330
	[CompilerGenerated]
	private IClientSession <ClientSession>k__BackingField; //Field offset: 0x338
	[CompilerGenerated]
	private EItemUiContextType <ContextType>k__BackingField; //Field offset: 0x340
	[CompilerGenerated]
	private ItemContext <CurrentItemContext>k__BackingField; //Field offset: 0x348
	private readonly BindableState _currentPriorityGridWindowContext; //Field offset: 0x350
	private CompoundItem _currentPriorityCompoundItem; //Field offset: 0x358
	[CompilerGenerated]
	private Action OnShowWeaponBuilds; //Field offset: 0x360
	[CompilerGenerated]
	private Action OnOpenHideoutCrafts; //Field offset: 0x368

	public event Action OnEffectsChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnInventoryLocked
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnOpenHideoutCrafts
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnShowWeaponBuilds
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public AchievementGlobalProgressTooltip AchievementGlobalProgressTooltip
	{
		 get { } //Length: 8
	}

	public BrowserWindow BrowserWindow
	{
		 get { } //Length: 8
	}

	public private IClientSession ClientSession
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CompoundTooltip CompoundTooltip
	{
		 get { } //Length: 8
	}

	public private ItemContextInteractionsSwitcher ContextInteractionsSwitcher
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SimpleContextMenu ContextMenu
	{
		 get { } //Length: 8
	}

	public RectTransform ContextMenuArea
	{
		 get { } //Length: 8
	}

	public private EItemUiContextType ContextType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private ItemContext CurrentItemContext
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IBindable CurrentPriorityGridWindowContext
	{
		 get { } //Length: 8
	}

	private GridWindowContext CurrentPriorityGridWindowContextValue
	{
		private get { } //Length: 69
	}

	private EPriorityWindowMode CurrentPriorityGridWindowMode
	{
		private get { } //Length: 215
	}

	public CustomizationOfferTooltip CustomizationOfferTooltip
	{
		 get { } //Length: 8
	}

	public ExpansionsTooltip ExtensionsTooltip
	{
		 get { } //Length: 8
	}

	private Handbook Handbook
	{
		private get { } //Length: 46
	}

	public HandoverExchangeableItemsWindow HandoverItemsWindow
	{
		 get { } //Length: 8
	}

	public HandoverQuestItemsWindow HandoverQuestItemsWindow
	{
		 get { } //Length: 8
	}

	public HandoverRagfairMoneyWindow HandoverRagfairMoneyWindow
	{
		 get { } //Length: 8
	}

	public private static ItemUiContext Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public ItemsListWindow ItemsListWindow
	{
		 get { } //Length: 8
	}

	public ItemTooltip ItemTooltip
	{
		 get { } //Length: 8
	}

	public LocationBlockedForPlayersTooltip LocationBlockedForPlayersTooltip
	{
		 get { } //Length: 8
	}

	public MasteringTooltip MasteringTooltip
	{
		 get { } //Length: 8
	}

	public bool MessageWindowActive
	{
		 get { } //Length: 165
	}

	public MultiLineTooltip MultiLineTooltip
	{
		 get { } //Length: 8
	}

	private CompoundItem[] PlayerCollections
	{
		private get { } //Length: 392
	}

	private CompoundItem[] PlayerStash
	{
		private get { } //Length: 77
	}

	public PriceTooltip PriceTooltip
	{
		 get { } //Length: 8
	}

	public QuestController QuestController
	{
		 get { } //Length: 8
	}

	public RagfairFilterWindow RagfairFilterWindow
	{
		 get { } //Length: 8
	}

	public PlayerRecorderController RecorderController
	{
		 get { } //Length: 33
	}

	public RenewOfferWindow RenewOfferWindow
	{
		 get { } //Length: 8
	}

	private bool ScrolledMessageWindowActive
	{
		private get { } //Length: 165
	}

	public private IEftSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private SettingsManager SettingsManager
	{
		private get { } //Length: 46
	}

	public SkillTooltip SkillTooltip
	{
		 get { } //Length: 8
	}

	public bool SortAvailable
	{
		 get { } //Length: 23
	}

	public SplitDialog SplitDialog
	{
		 get { } //Length: 372
	}

	public SubtitlesAuthorityController SubtitlesController
	{
		 get { } //Length: 8
	}

	public TaskConditionsTooltip TaskConditionsTooltip
	{
		 get { } //Length: 8
	}

	public TaskRewardsTooltip TaskRewardsTooltip
	{
		 get { } //Length: 8
	}

	public SimpleTooltip Tooltip
	{
		 get { } //Length: 8
	}

	public TradingOfferTooltip TradingOfferTooltip
	{
		 get { } //Length: 8
	}

	public bool UseLobbyLogicForRecorder
	{
		 get { } //Length: 125
	}

	public WeaponPreviewPool WeaponPreviewPool
	{
		 get { } //Length: 8
	}

	public WishlistManager WishlistManager
	{
		 get { } //Length: 33
	}

	public ItemUiContext() { }

	[CompilerGenerated]
	private bool <DisassembleOperationsList>b__329_0(Mod x) { }

	[CompilerGenerated]
	private void <FindSuitableMagazine>g__Consider|335_0(Magazine mag, ref <>c__DisplayClass335_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <RecorderPlayButtonPressHandler>b__237_0() { }

	[CompilerGenerated]
	private void <ShowHandbookScreen>b__232_0() { }

	private void ActiveEventsChangeHandler(ItemEventArgs activeEvent) { }

	[CompilerGenerated]
	public void add_OnEffectsChange(Action value) { }

	[CompilerGenerated]
	public void add_OnInventoryLocked(Action value) { }

	[CompilerGenerated]
	public void add_OnOpenHideoutCrafts(Action value) { }

	[CompilerGenerated]
	public void add_OnShowWeaponBuilds(Action value) { }

	public void AddToFavorites(Item item, Action callback) { }

	public void AddToWishList(MongoID templateId, EWishlistGroup group) { }

	[AsyncStateMachine(typeof(<ApplyMagPreset>d__278))]
	public Task ApplyMagPreset(MagPreset preset, IReadOnlyCollection magazines) { }

	private void BindItem(Item item, EBoundItem bindIndex) { }

	public bool CanShowUnloadItemsWindow() { }

	private void CheckCompatibleItems() { }

	public void CheckMagazine(Magazine magazine) { }

	public virtual void Close() { }

	public void CloseAllWindows() { }

	private void CloseNextWindowHandler() { }

	public void CloseSelectItemMenu() { }

	private void CloseTooltips() { }

	private void CloseWindows() { }

	private Dictionary CollectCompatibleAmmo(Func compatible) { }

	private static int CompareAmmoForLoad(Ammo left, Ammo right) { }

	public void Configure(InventoryController inventoryController, Profile profile, IClientSession backEndSession, EItemUiContextType contextType, ECursorResult contextCursor) { }

	public void Configure(ItemController itemController, Profile profile, IEftSession backEndSession, InsuranceCompany insurance, Trader trader, IHealthController healthController, CompoundItem[] rightPanelItems, EItemUiContextType contextType, ECursorResult contextCursor = 2, CompoundItem leftPanelItem = null, InventoryEquipment equipment = null, QuestController questController = null, RepairController repairController = null) { }

	public ItemView CreateItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, bool slotView, bool canSelect) { }

	public ItemView CreateSlotItemView(Item item, ItemContext sourceContext, ItemController itemController, IItemOwner itemOwner, SkillManager skills) { }

	[AsyncStateMachine(typeof(<Disassemble>d__328))]
	public Task Disassemble(ItemContext itemContext) { }

	private List DisassembleOperationsList(ItemContext itemContext, bool simulate) { }

	public void EditTag(ItemContext itemContext, TagComponent tagComponent) { }

	public void EditWeaponBuild(Weapon weapon) { }

	[AsyncStateMachine(typeof(<EquipItem>d__318))]
	public Task EquipItem(Item item) { }

	public void Examine(Item item, Action callback = null) { }

	public void ExternalRagfairSearch(RagfairSearch ragfairSearch) { }

	public Dictionary FindCompatibleAmmo(Magazine magazine) { }

	public Dictionary FindCompatibleAmmo(Weapon weapon) { }

	private Magazine FindSuitableMagazine(Slot magazineSlot, IEnumerable collections) { }

	public void FoldItem(Item item) { }

	public AchievementGlobalProgressTooltip get_AchievementGlobalProgressTooltip() { }

	public BrowserWindow get_BrowserWindow() { }

	[CompilerGenerated]
	public IClientSession get_ClientSession() { }

	public CompoundTooltip get_CompoundTooltip() { }

	[CompilerGenerated]
	public ItemContextInteractionsSwitcher get_ContextInteractionsSwitcher() { }

	public SimpleContextMenu get_ContextMenu() { }

	public RectTransform get_ContextMenuArea() { }

	[CompilerGenerated]
	public EItemUiContextType get_ContextType() { }

	[CompilerGenerated]
	private ItemContext get_CurrentItemContext() { }

	public IBindable get_CurrentPriorityGridWindowContext() { }

	private GridWindowContext get_CurrentPriorityGridWindowContextValue() { }

	private EPriorityWindowMode get_CurrentPriorityGridWindowMode() { }

	public CustomizationOfferTooltip get_CustomizationOfferTooltip() { }

	public ExpansionsTooltip get_ExtensionsTooltip() { }

	private Handbook get_Handbook() { }

	public HandoverExchangeableItemsWindow get_HandoverItemsWindow() { }

	public HandoverQuestItemsWindow get_HandoverQuestItemsWindow() { }

	public HandoverRagfairMoneyWindow get_HandoverRagfairMoneyWindow() { }

	[CompilerGenerated]
	public static ItemUiContext get_Instance() { }

	public ItemsListWindow get_ItemsListWindow() { }

	public ItemTooltip get_ItemTooltip() { }

	public LocationBlockedForPlayersTooltip get_LocationBlockedForPlayersTooltip() { }

	public MasteringTooltip get_MasteringTooltip() { }

	public bool get_MessageWindowActive() { }

	public MultiLineTooltip get_MultiLineTooltip() { }

	private CompoundItem[] get_PlayerCollections() { }

	private CompoundItem[] get_PlayerStash() { }

	public PriceTooltip get_PriceTooltip() { }

	public QuestController get_QuestController() { }

	public RagfairFilterWindow get_RagfairFilterWindow() { }

	public PlayerRecorderController get_RecorderController() { }

	public RenewOfferWindow get_RenewOfferWindow() { }

	private bool get_ScrolledMessageWindowActive() { }

	[CompilerGenerated]
	public IEftSession get_Session() { }

	private SettingsManager get_SettingsManager() { }

	public SkillTooltip get_SkillTooltip() { }

	public bool get_SortAvailable() { }

	public SplitDialog get_SplitDialog() { }

	public SubtitlesAuthorityController get_SubtitlesController() { }

	public TaskConditionsTooltip get_TaskConditionsTooltip() { }

	public TaskRewardsTooltip get_TaskRewardsTooltip() { }

	public SimpleTooltip get_Tooltip() { }

	public TradingOfferTooltip get_TradingOfferTooltip() { }

	public bool get_UseLobbyLogicForRecorder() { }

	public WeaponPreviewPool get_WeaponPreviewPool() { }

	public WishlistManager get_WishlistManager() { }

	public ContextInteractions GetItemContextInteractions(ItemContext itemContext) { }

	public DraggedItemView GetOrCreateDraggedItemView() { }

	public bool HasRequiredTradingOfferLoyalty(QuestReward reward) { }

	public bool HasSourcesForTopUp(Item targetItem) { }

	public void HealAll(Meds meds) { }

	private OneAndList HealPriority(Item item) { }

	private void HealthEffectsChangeHandler(IHealthEffect effect) { }

	public static void Init(ItemUiContext instance) { }

	public void InitSpecificationPanel(ItemSpecificationPanel panel, ItemContext itemContext, ContextInteractions contextInteractions) { }

	public void Inspect(ItemContext itemContext, ContextInteractions contextInteractions) { }

	[AsyncStateMachine(typeof(<InstallMod>d__326))]
	public Task InstallMod(ItemContext itemContext, CompoundItem[] collections) { }

	public void Insure(InsuredItem item) { }

	private void InventoryLockedHandler(bool locked) { }

	private bool IsAvailable(Item ammo) { }

	public bool IsInFavoritesList(Item item) { }

	[AsyncStateMachine(typeof(<LoadAmmoByType>d__286))]
	public Task LoadAmmoByType(Magazine magazine, string ammoTemplateId, Action callback = null) { }

	[AsyncStateMachine(typeof(<LoadAmmoFromContainers>d__288))]
	private Task LoadAmmoFromContainers(string ammoTemplateId, Func loadStacks, Action callback) { }

	[AsyncStateMachine(typeof(<LoadBarrelByType>d__287))]
	public Task LoadBarrelByType(Weapon weapon, string ammoTemplateId, Action callback = null) { }

	[AsyncStateMachine(typeof(<LoadWeapon>d__325))]
	public Task LoadWeapon(Weapon weapon, CompoundItem[] collections) { }

	public void ModWeapon(Item item) { }

	public void OpenHideoutArea(EAreaType areaType) { }

	public void OpenInsuranceWindow(ItemContext itemContext) { }

	public void OpenItem(CompoundItem item, ItemContext itemContext) { }

	public void OpenRepairWindow(RepairController repairController, ItemContext itemContext) { }

	private void OpenWindow(ItemContext itemContext, TWindow template, Func show) { }

	public static void PlayOperationSound(Item item, IOperationResult operationResult) { }

	public void PlayTape(TapeItem tape, RecorderItem recorder = null) { }

	public OperationResult QuickFindAppropriatePlace(ItemContext itemContext, ItemController controller, bool forcePutInStash = false, bool displayWarnings = true, bool simulate = true) { }

	[AsyncStateMachine(typeof(<QuickMoveFromSortingTable>d__333))]
	public Task QuickMoveFromSortingTable(BackEndInventoryController controller) { }

	public OperationResult QuickMoveToSortingTable(ItemContext itemContext, ItemController controller, bool simulate = true) { }

	public void ReadNote(NoteItem note, ItemContext itemContext) { }

	public void RecodeItem(Item item) { }

	private void RecorderPlayButtonPressHandler(TapeItem tape) { }

	private void RecorderStopButtonPressHandler() { }

	private void RegisterBrowserInputNode() { }

	public void RegisterCaptchaWindow(CaptchaWindow captchaWindow, DialogWindowContext captchaWindowContext) { }

	public void RegisterCurrentItemContext(ItemContext itemContext) { }

	public void RegisterView(ItemContext itemContext) { }

	private TContext RegisterWindow(Window window, TContext windowContext) { }

	public void ReloadWeapon(Weapon weapon, IEnumerable collections) { }

	[CompilerGenerated]
	public void remove_OnEffectsChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnInventoryLocked(Action value) { }

	[CompilerGenerated]
	public void remove_OnOpenHideoutCrafts(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowWeaponBuilds(Action value) { }

	public void RemoveFromFavorites(Item item, Action callback) { }

	public void RemoveFromWishList(MongoID templateId) { }

	public void ResetCurrentPriorityWindow() { }

	public void ResetTag(TagComponent tagComponent) { }

	[AsyncStateMachine(typeof(<RunWithSound>d__330))]
	private static Task RunWithSound(ItemController itemController, Item item, OperationResult operationResult, Callback callback = null) { }

	public Task SelectHandoverExchangeableItemsAsync(EExchangeableWindowType windowType, Dictionary goods, bool displayInputField, Profile profile, InventoryController controller, Predicate allowedItemPredicate = null) { }

	[AsyncStateMachine(typeof(<SelectItem>d__263))]
	public Task SelectItem(IEnumerable availableItems, Func getDetails, bool showEmptyCell, SelectingItemView itemTemplate, RectTransform elementPosition, Vector2 offset, EContextPriorDirection direction = 0) { }

	[CompilerGenerated]
	private void set_ClientSession(IClientSession value) { }

	[CompilerGenerated]
	private void set_ContextInteractionsSwitcher(ItemContextInteractionsSwitcher value) { }

	[CompilerGenerated]
	private void set_ContextType(EItemUiContextType value) { }

	[CompilerGenerated]
	private void set_CurrentItemContext(ItemContext value) { }

	[CompilerGenerated]
	private static void set_Instance(ItemUiContext value) { }

	[CompilerGenerated]
	private void set_Session(IEftSession value) { }

	private void SetAsTopWindow(WindowData data) { }

	public void SetGridWindowSelectedAsTarget(GridWindowContext context, ItemContext itemContext, bool active) { }

	[AsyncStateMachine(typeof(<SetPinLockState>d__305))]
	public Task SetPinLockState(Item item, EItemPinLockState state) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public DialogWindowContext ShowAddOfferWindow(Item itemToSelect = null) { }

	public BattlePassExchangeWindowContext ShowBattlePassExchangeWindow(BattlePass battlePass, BattlePassController controller, IImageLoader imageLoader) { }

	public BattlePassUniversalDocumentsHandoverWindowContext ShowBattlePassUniversalDocumentsHandoverWindow(BattlePassRewardHandover handover, BattlePassController controller, IImageLoader imageLoader) { }

	public void ShowBrowserScreen(string url, bool navigationEnabled = false, IEftSession session = null, EBrowserType browserType = 0) { }

	public CaptchaHandler ShowCaptchaHandler() { }

	public DialogWindowContext ShowChangeQuestConfirm(AcceptQuestChangeArgs arguments) { }

	public DialogWindowContext ShowClothingConfirmation(FullOffer offer, Profile profile, TraderInfo trader, QuestBook quests, AchievementsBook achievements, OfferRequirements requirements, Stash stashGrid, Sprite clothingSprite) { }

	public WindowContext ShowClothingInspectWindow(CustomizationSuite suite, EClothingViewType viewType) { }

	public void ShowContextMenu(ItemContext itemContext, Vector2 position) { }

	public void ShowDelayTypeWindow(string title, string message, string imageUrl = null, float time = 0) { }

	public EditBuildNameWindowContext ShowEditBuildNameWindow(string savedName, string caption, string placeholderText) { }

	public WindowContext ShowEquipItemWindow(Slot slot, Vector3 position) { }

	public void ShowHandbookScreen(string showAtCategory = null, string showAtItem = null) { }

	public DialogWindowContext ShowHandoverExchangeableItemsWindow(EExchangeableWindowType windowType, Dictionary goods, bool displayInputField, Profile profile, InventoryController controller, Action acceptAction, bool canShowCloseButton, Predicate allowedItemPredicate = null) { }

	public DialogWindowContext ShowHandoverQuestItemsWindow(Condition condition, double currentValue, Item[] items, Profile profile, ItemController controller, Action acceptAction, bool canShowCloseButton = true, bool allowPartialHandover = true) { }

	public DialogWindowContext ShowInviteInGroupWindow(GroupInvite groupInvite) { }

	public DialogWindowContext ShowInviteInRaidWindow(IMatchmakerSession session, RaidSettings raidSettings, OfflineInventoryController inventoryController, GroupPlayer player) { }

	public WindowContext ShowMagPresetsWindow(InventorySelectableItemContext itemContext, Nullable presetId = null) { }

	public Task ShowMessageWindow(out DialogWindowContext windowContext, string description, string caption = null, bool forceShow = false, bool exitActsAsAccept = false) { }

	private DialogWindowContext ShowMessageWindow(MessageWindow windowTemplate, string description, Action acceptAction, Action cancelAction = null, string caption = null, float time = 0, bool forceShow = false, bool showCursor = false, bool exitActsAsAccept = false) { }

	public DialogWindowContext ShowMessageWindow(string description, Action acceptAction, Action cancelAction = null, string caption = null, float time = 0, bool forceShow = false, TextAlignmentOptions alignment = 514, bool showCursor = false, bool exitActsAsAccept = false) { }

	public WindowContext ShowMissingItemsWindow(IReadOnlyCollection outOfCollectionItems, IReadOnlyCollection itemsInBuild, bool canUseAllItems, Action onIgnoreClicked, Action onBuyClicked) { }

	private void ShowNextWindow() { }

	public PlayerEquipmentWindowContext ShowPlayerEquipmentWindow(GroupPlayer groupPlayer, Profile profile) { }

	[AsyncStateMachine(typeof(<ShowPlayerProfileScreen>d__279))]
	public Task ShowPlayerProfileScreen(string accId, EItemViewType viewType = 25, bool isInRaid = false, Nullable token = null) { }

	public WindowContext ShowPlayersInviteWindow(string profileId, BindableList friendsList, IMatchmakerController matchmakerPlayersController, float offsetX, float offsetY) { }

	private WindowContext ShowReadNoteWindow(NoteItem note, ItemContext itemContext) { }

	public Task ShowScrolledMessageWindow(out DialogWindowContext windowContext, string description, string caption = null, bool forceShow = false, bool exitActsAsAccept = false) { }

	public DialogWindowContext ShowScrolledMessageWindow(string description, Action acceptAction, Action cancelAction = null, string caption = null, float time = 0, bool forceShow = false, bool exitActsAsAccept = false) { }

	public DialogWindowContext ShowSeasonalPersonalPerksConfirmationWindow(string title, string description, IReadOnlyCollection selectedPerks, IImageLoader imageLoader) { }

	public SortingTableWindowContext ShowSortingTable(ItemContext itemContext, SortingTable sortingTable) { }

	private void ShowSplitMenuDialog(IHealthController healthController, FoodDrink foodDrink) { }

	public WindowContext ShowStashSearchWindow(ItemContext itemContext, InventoryEquipment equipment) { }

	public DialogWindowContext ShowTraderDialogConfirmationWindow(string selectionKey) { }

	public void ShowTradingOfferTooltip(QuestReward reward) { }

	public void StopRecorder(bool immediate = false) { }

	[AsyncStateMachine(typeof(<ThrowItem>d__308))]
	public Task ThrowItem(Item item) { }

	public Task ToggleItem(TogglableComponent togglable) { }

	[AsyncStateMachine(typeof(<TopUpItem>d__290))]
	public void TopUpItem(Item targetItem) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryExamineMalfunction(Weapon weapon) { }

	public bool TryShowUnloadItemsWindow(out DialogWindowContext context) { }

	public void Uncover(InsuredItem item) { }

	[AsyncStateMachine(typeof(<Uninstall>d__316))]
	public Task Uninstall(ItemContext itemContext, bool putInStash = false) { }

	[AsyncStateMachine(typeof(<UnloadAmmo>d__327))]
	public Task UnloadAmmo(ItemContext itemContext) { }

	[AsyncStateMachine(typeof(<UnloadWeapon>d__323))]
	public Task UnloadWeapon(Weapon weapon) { }

	[AsyncStateMachine(typeof(<UnpackItem>d__291))]
	public Task UnpackItem(Item targetItem) { }

	internal void UnregisterBrowserInputNode() { }

	public void UnregisterCurrentItemContext(ItemContext itemContext) { }

	public void UnregisterView(ItemContext itemContext) { }

	[UsedImplicitly]
	private void Update() { }

	public void UseAll(Item item) { }

	public void UseItem(Item item) { }

}

