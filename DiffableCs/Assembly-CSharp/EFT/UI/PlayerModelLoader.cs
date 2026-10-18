namespace EFT.UI;

public sealed class PlayerModelLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__22_0; //Field offset: 0x8
		public static Func <>9__22_1; //Field offset: 0x10
		public static Func <>9__25_0; //Field offset: 0x18
		public static Func <>9__25_1; //Field offset: 0x20
		public static Func <>9__25_3; //Field offset: 0x28
		public static Func <>9__25_4; //Field offset: 0x30
		public static Func <>9__25_5; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal Item <GetItemInHands>b__22_0(Slot x) { }

		internal bool <GetItemInHands>b__22_1(Item x) { }

		internal bool <LoadBundles>b__25_0(ResourceKey x) { }

		internal string <LoadBundles>b__25_1(ResourceKey x) { }

		internal bool <LoadBundles>b__25_3(string x) { }

		internal string <LoadBundles>b__25_4(Item x) { }

		internal bool <LoadBundles>b__25_5(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public CustomizationSolver solver; //Field offset: 0x10
		public ProgressSpinner progressSpinner; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal string <LoadBundles>b__2(KeyValuePair x) { }

		internal void <LoadBundles>b__6(float p) { }

	}

	[CompilerGenerated]
	private struct <CreatePlayerBody>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerModelLoader <>4__this; //Field offset: 0x20
		public bool enableBottomShadow; //Field offset: 0x28
		public BodyCustomization filteredCustomization; //Field offset: 0x30
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x38
		public Item weapon; //Field offset: 0x40
		public int layer; //Field offset: 0x48
		public Dictionary alternativeBones; //Field offset: 0x50
		public Transform parent; //Field offset: 0x58
		public Vector3 position; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken ct; //Field offset: 0x20
		public bool setWeaponInHands; //Field offset: 0x28
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x30
		public InventoryController inventoryController; //Field offset: 0x38
		public ICustomizationFilter customizationFilter; //Field offset: 0x40
		public ProgressSpinner progressSpinner; //Field offset: 0x48
		public PlayerModelLoader <>4__this; //Field offset: 0x50
		public Transform parent; //Field offset: 0x58
		public Vector3 position; //Field offset: 0x60
		public int layer; //Field offset: 0x6C
		public Dictionary alternativeBones; //Field offset: 0x70
		public bool enableBottomShadow; //Field offset: 0x78
		public float animatorDeltatime; //Field offset: 0x7C
		public bool animateWeapon; //Field offset: 0x80
		private Item <weapon>5__2; //Field offset: 0x88
		private BodyCustomization <filteredCustomization>5__3; //Field offset: 0x90
		private Vector3 <cachedPosition>5__4; //Field offset: 0x98
		private TaskAwaiter <>u__1; //Field offset: 0xA8
		private TaskAwaiter <>u__2; //Field offset: 0xB0
		private YieldAwaiter <>u__3; //Field offset: 0xB8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBundles>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomizationSolver solver; //Field offset: 0x20
		public ProgressSpinner progressSpinner; //Field offset: 0x28
		public BodyCustomization filteredCustomization; //Field offset: 0x30
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x38
		private Token <bundles>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int EMPTY_HANDS = -1; //Field offset: 0x0
	private const int TWO_HANDED_FIREARM = 0; //Field offset: 0x0
	private const int ONE_HANDED_FIREARM = 1; //Field offset: 0x0
	private const int THROWABLE_WEAPON = 2; //Field offset: 0x0
	private const int MELEE_WEAPON = 3; //Field offset: 0x0
	private const int TWO_HANDED_RPG = 5; //Field offset: 0x0
	private const int TWO_HANDED_MG = 6; //Field offset: 0x0
	[CompilerGenerated]
	private MenuPlayerPoser <ModelPlayerPoser>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private PlayerBody <PlayerBody>k__BackingField; //Field offset: 0x18
	private Token _bundles; //Field offset: 0x20
	private WeaponPrefab _weaponPrefab; //Field offset: 0x28
	private IAnimator _weaponAnimator; //Field offset: 0x30
	[CompilerGenerated]
	private Action LoadingCompletedEvent; //Field offset: 0x38

	public event Action LoadingCompletedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private MenuPlayerPoser ModelPlayerPoser
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private PlayerBody PlayerBody
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PlayerModelLoader() { }

	[CompilerGenerated]
	public void add_LoadingCompletedEvent(Action value) { }

	public void Clear() { }

	[AsyncStateMachine(typeof(<CreatePlayerBody>d__24))]
	private Task CreatePlayerBody(PlayerVisualRepresentation playerVisual, BodyCustomization filteredCustomization, Item weapon, Transform parent, Vector3 position, int layer, Dictionary alternativeBones, bool enableBottomShadow) { }

	private void CreateWeapon(float animatorDeltatime, bool animateWeapon, Item weapon, int layer) { }

	public void Fold(IAnimator animator, bool folded) { }

	[CompilerGenerated]
	public MenuPlayerPoser get_ModelPlayerPoser() { }

	[CompilerGenerated]
	public PlayerBody get_PlayerBody() { }

	private static Item GetItemInHands(PlayerVisualRepresentation playerVisual, InventoryController inventoryController) { }

	[AsyncStateMachine(typeof(<Load>d__21))]
	public Task Load(PlayerVisualRepresentation playerVisual, InventoryController inventoryController, float animatorDeltatime, ICustomizationFilter customizationFilter, ProgressSpinner progressSpinner, CancellationToken ct, Vector3 position, Transform parent, int layer, bool animateWeapon, Dictionary alternativeBones = null, bool enableBottomShadow = true, bool setWeaponInHands = true) { }

	[AsyncStateMachine(typeof(<LoadBundles>d__25))]
	private static Task LoadBundles(PlayerVisualRepresentation playerVisual, ProgressSpinner progressSpinner, BodyCustomization filteredCustomization, CustomizationSolver solver) { }

	[CompilerGenerated]
	public void remove_LoadingCompletedEvent(Action value) { }

	[CompilerGenerated]
	private void set_ModelPlayerPoser(MenuPlayerPoser value) { }

	[CompilerGenerated]
	private void set_PlayerBody(PlayerBody value) { }

}

