namespace EFT.Hideout;

public sealed class InventoryEquipmentStashLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__15_0; //Field offset: 0x8
		public static Func <>9__17_1; //Field offset: 0x10
		public static Func <>9__17_2; //Field offset: 0x18
		public static Func <>9__17_4; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <Load>b__15_0(GameObject go) { }

		internal bool <LoadBundles>b__17_1(ResourceKey x) { }

		internal string <LoadBundles>b__17_2(ResourceKey x) { }

		internal bool <LoadBundles>b__17_4(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public CustomizationSolver solver; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal ResourceKey <LoadBundles>b__0(CustomizationSuite x) { }

		internal string <LoadBundles>b__3(CustomizationSuite x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string savedMannequinLowerSuitItemId; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <GetSelectedLowerSuit>b__0(CustomizationSuite s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Nullable selectedPoseItemId; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <GetSelectedMannequinPose>b__0(CustomizationHideoutMannequinPose availablePose) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public string itemId; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <UpdateMannequinSuit>b__0(CustomizationSuite s) { }

		internal bool <UpdateMannequinSuit>b__1(CustomizationSuite s) { }

	}

	[CompilerGenerated]
	private struct <Load>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryEquipmentStashLoader <>4__this; //Field offset: 0x20
		public Dictionary mannequinPoses; //Field offset: 0x28
		public InventoryController inventoryController; //Field offset: 0x30
		public CancellationTokenSource cts; //Field offset: 0x38
		public InventoryEquipment equipment; //Field offset: 0x40
		public Dictionary stashObjectsSpawnPoints; //Field offset: 0x48
		private Dictionary <alternativeBones>5__2; //Field offset: 0x50
		private PlayerModelLoader <playerModelLoader>5__3; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBundles>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List suits; //Field offset: 0x20
		private Token <bundles>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreloadBundles>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryEquipmentStashLoader <>4__this; //Field offset: 0x20
		public CancellationTokenSource cts; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAnimator>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryEquipmentStashLoader <>4__this; //Field offset: 0x20
		public CancellationTokenSource cts; //Field offset: 0x28
		public Item item; //Field offset: 0x30
		private ResourceRequest <animatorRequest>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMannequinSuit>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string itemId; //Field offset: 0x20
		public InventoryEquipmentStashLoader <>4__this; //Field offset: 0x28
		public Item equipment; //Field offset: 0x30
		private <>c__DisplayClass27_0 <>8__1; //Field offset: 0x38
		private PlayerModelLoader <playerModelLoader>5__2; //Field offset: 0x40
		private List <currentAvailableLowerSuits>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string MANNEQUIN_LOWER_SUIT_ID = "6644d32235d958070c02642e"; //Field offset: 0x0
	private const string MANNEQUIN_BODY_SUIT_ID = "6644d2ffd85107e63500a61c"; //Field offset: 0x0
	private const string MANNEQUIN_HEAD_SUIT_ID = "6644d2da35d958070c02642c"; //Field offset: 0x0
	private const string MANNEQUIN_POSE_DEFAULT_ITEM_ID = "67600aa8e9db590d5601665f"; //Field offset: 0x0
	private const string MANNEQUIN_ANIMATOR_PATH = "Hideout/EquipmentPresetsStand/Mannequin_animator_controller"; //Field offset: 0x0
	private RuntimeAnimatorController _mannequinAnimatorController; //Field offset: 0x10
	private Token _preloadedBundles; //Field offset: 0x18
	private List _availableLowerSuits; //Field offset: 0x20
	private CancellationTokenSource _bundlesLoadingCts; //Field offset: 0x28
	private EPlayerSide _playerSide; //Field offset: 0x30
	private string _profileVersion; //Field offset: 0x38
	private Dictionary _mannequinPoses; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Dictionary <LoadedPlayerModels>k__BackingField; //Field offset: 0x48

	public Dictionary LoadedPlayerModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public InventoryEquipmentStashLoader() { }

	private PlayerVisualRepresentation CreatePlayerVisualRepresentation(InventoryEquipment equipment) { }

	public void Dispose() { }

	[CompilerGenerated]
	public Dictionary get_LoadedPlayerModels() { }

	private Dictionary GetAlternativeSpawnPositions(Item item, Dictionary stashObjectsSpawnPoints) { }

	public static List GetLowerSuits(EPlayerSide playerSide, string profileVersion) { }

	public static List GetMannequinPoses(bool onlyAvailable) { }

	public static CustomizationSuite GetSelectedLowerSuit(string mannequinId, List lowerSuites) { }

	public static CustomizationHideoutMannequinPose GetSelectedMannequinPose(Nullable selectedPoseItemId) { }

	public void InitMannequinSuit(Item equipment) { }

	[AsyncStateMachine(typeof(<Load>d__15))]
	public Task Load(InventoryEquipment equipment, InventoryController inventoryController, Dictionary stashObjectsSpawnPoints, Dictionary mannequinPoses, CancellationTokenSource cts) { }

	[AsyncStateMachine(typeof(<LoadBundles>d__17))]
	private Task LoadBundles(List suits) { }

	[AsyncStateMachine(typeof(<PreloadBundles>d__16))]
	private Task PreloadBundles(CancellationTokenSource cts) { }

	private void SetPositionTuner(Dictionary alternativeBones, PlayerModelLoader playerModelLoader) { }

	[AsyncStateMachine(typeof(<UpdateAnimator>d__23))]
	public Task UpdateAnimator(Item item, CancellationTokenSource cts) { }

	public void UpdateMannequinPose(Item equipment, string poseAnimationClipName) { }

	[AsyncStateMachine(typeof(<UpdateMannequinSuit>d__27))]
	public Task UpdateMannequinSuit(Item equipment, string itemId) { }

}

