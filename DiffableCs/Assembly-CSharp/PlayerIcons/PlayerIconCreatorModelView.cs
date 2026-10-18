namespace PlayerIcons;

public class PlayerIconCreatorModelView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_2; //Field offset: 0x8
		public static Func <>9__20_5; //Field offset: 0x10
		public static Func <>9__22_0; //Field offset: 0x18
		public static Func <>9__22_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal Item <GetWeaponFirst>b__22_0(Slot x) { }

		internal bool <GetWeaponFirst>b__22_1(Item x) { }

		internal string <LoadBundles>b__20_2(ResourceKey x) { }

		internal string <LoadBundles>b__20_5(Item x) { }

	}

	[CompilerGenerated]
	private struct <LoadBundles>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconCreatorModelView <>4__this; //Field offset: 0x20
		public InventoryEquipment equipment; //Field offset: 0x28
		private string[] <bundleKeys>5__2; //Field offset: 0x30
		private Token <bundleToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconCreatorModelView <>4__this; //Field offset: 0x20
		public PlayerIconRequest playerIconRequest; //Field offset: 0x28
		private InventoryEquipment <equipment>5__2; //Field offset: 0x30
		private Item <weapon>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int EMPTY_HANDS = -1; //Field offset: 0x0
	private const int TWO_HANDED_FIREARM = 0; //Field offset: 0x0
	private const int ONE_HANDED_FIREARM = 1; //Field offset: 0x0
	private const int THROWABLE_WEAPON = 2; //Field offset: 0x0
	private const int MELEE_WEAPON = 3; //Field offset: 0x0
	private WeaponPrefab _weaponPrefab; //Field offset: 0x10
	private IAnimator _weaponAnimator; //Field offset: 0x18
	private ICustomizationFilter _filter; //Field offset: 0x20
	private MenuPlayerPoser _modelPlayerPoser; //Field offset: 0x28
	private PlayerBody _playerBody; //Field offset: 0x30
	private GameObject _playerObject; //Field offset: 0x38
	private CustomizationSolver _solver; //Field offset: 0x40
	private IEasyAssets _easyAssets; //Field offset: 0x48
	private BodyCustomization _filteredCustomization; //Field offset: 0x50
	private ObjectsFactory _objectFactory; //Field offset: 0x58
	private Animator _animator; //Field offset: 0x60
	private readonly HashSet _bundlekeys; //Field offset: 0x68
	private readonly List _bundleTokens; //Field offset: 0x70

	public PlayerIconCreatorModelView() { }

	[CompilerGenerated]
	private ResourceKey <LoadBundles>b__20_0(MongoID x) { }

	[CompilerGenerated]
	private bool <LoadBundles>b__20_1(ResourceKey x) { }

	[CompilerGenerated]
	private string <LoadBundles>b__20_3(KeyValuePair x) { }

	[CompilerGenerated]
	private bool <LoadBundles>b__20_4(string x) { }

	[CompilerGenerated]
	private bool <LoadBundles>b__20_6(string x) { }

	private void CreateBody() { }

	public void DisposeBody() { }

	private Item GetWeaponFirst(InventoryEquipment equipment) { }

	[AsyncStateMachine(typeof(<LoadBundles>d__20))]
	private Task LoadBundles(InventoryEquipment equipment) { }

	[AsyncStateMachine(typeof(<Show>d__19))]
	public Task Show(PlayerIconRequest playerIconRequest) { }

}

