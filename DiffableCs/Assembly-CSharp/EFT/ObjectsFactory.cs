namespace EFT;

public sealed class ObjectsFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_0; //Field offset: 0x8
		public static Func <>9__31_0; //Field offset: 0x10
		public static Func <>9__31_2; //Field offset: 0x18
		public static Predicate <>9__31_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal CancellationToken <get_PoolsCancellationToken>b__23_0(KeyValuePair kvp) { }

		internal InitLevelProgress <LoadBundlesAndCreatePools>b__31_0(float bp) { }

		internal bool <LoadBundlesAndCreatePools>b__31_2(PoolResourceInfo x) { }

		internal bool <LoadBundlesAndCreatePools>b__31_3(PoolResourceInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public List poolsToCreate; //Field offset: 0x10
		public Pools pools; //Field offset: 0x18
		public ObjectsFactory <>4__this; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal InitLevelProgress <LoadBundlesAndCreatePools>b__4(int x) { }

		internal void <LoadBundlesAndCreatePools>b__5(PoolResourceInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public GameObject modPrefab; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal void <AttachMods>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public GameObject itemGameObject; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal void <CreateItemAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <AssembleMods>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Transform weaponHierarchy; //Field offset: 0x20
		public IPlayer player; //Field offset: 0x28
		public GameObject itemGameObject; //Field offset: 0x30
		public AssetPoolObject poolObject; //Field offset: 0x38
		public ObjectsFactory <>4__this; //Field offset: 0x40
		public ContainerCollection collection; //Field offset: 0x48
		public ECameraType cameraType; //Field offset: 0x50
		public bool isAnimated; //Field offset: 0x54
		public CancellationToken ct; //Field offset: 0x58
		public YieldDelegate yield; //Field offset: 0x60
		public bool isHandsItem; //Field offset: 0x68
		private bool <hasAnimatedParts>5__2; //Field offset: 0x69
		private ContainerCollectionView <collectionView>5__3; //Field offset: 0x70
		private TaskAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AttachMods>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken ct; //Field offset: 0x20
		public ContainerCollection containerCollection; //Field offset: 0x28
		public ContainerCollectionView collectionView; //Field offset: 0x30
		public ObjectsFactory <>4__this; //Field offset: 0x38
		public ECameraType cameraType; //Field offset: 0x40
		public IPlayer player; //Field offset: 0x48
		public bool isAnimated; //Field offset: 0x50
		public YieldDelegate yield; //Field offset: 0x58
		private <>c__DisplayClass43_0 <>8__1; //Field offset: 0x60
		private IEnumerator <>7__wrap1; //Field offset: 0x68
		private SlotView <slotView>5__3; //Field offset: 0x70
		private Item <modItem>5__4; //Field offset: 0x78
		private TaskAwaiter <>u__1; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateCleanLootPrefabAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObjectsFactory <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		public IPlayer player; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateItemAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObjectsFactory <>4__this; //Field offset: 0x20
		public CancellationToken ct; //Field offset: 0x28
		public Item item; //Field offset: 0x30
		public YieldDelegate yield; //Field offset: 0x38
		private <>c__DisplayClass49_0 <>8__1; //Field offset: 0x40
		public ECameraType cameraType; //Field offset: 0x48
		public IPlayer player; //Field offset: 0x50
		public bool isAnimated; //Field offset: 0x58
		private CancellationTokenRegistration <registration>5__2; //Field offset: 0x60
		private AssetPoolObject <poolObject>5__3; //Field offset: 0x78
		private Transform <weaponHierarchy>5__4; //Field offset: 0x80
		private bool <isHandsItem>5__5; //Field offset: 0x88
		private object <>u__1; //Field offset: 0x90
		private TaskAwaiter <>u__2; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBundlesAndCreatePools>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Pools pools; //Field offset: 0x20
		public ObjectsFactory <>4__this; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		public List resources; //Field offset: 0x38
		public CancellationToken ct; //Field offset: 0x40
		private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x48
		public AssemblyType assemblyType; //Field offset: 0x50
		public YieldDelegate yield; //Field offset: 0x58
		private Dictionary <bundlesPaths>5__2; //Field offset: 0x60
		private Task <tokenContainer>5__3; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegisterLoadBundlesAndCreatePools>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PoolsCategory poolsCategory; //Field offset: 0x20
		public ObjectsFactory <>4__this; //Field offset: 0x28
		public Transform parentTransform; //Field offset: 0x30
		public ObjectsFactoryConfig config; //Field offset: 0x38
		public AssemblyType assemblyType; //Field offset: 0x40
		public ResourceKey[] resources; //Field offset: 0x48
		public YieldDelegate yield; //Field offset: 0x50
		public IProgress progress; //Field offset: 0x58
		public CancellationToken ct; //Field offset: 0x60
		private Pools <pools>5__2; //Field offset: 0x68
		private int <desiredPlayers>5__3; //Field offset: 0x70
		private TaskAwaiter <>u__1; //Field offset: 0x78
		private Enumerator <>7__wrap3; //Field offset: 0x80
		private Pools <>7__wrap4; //Field offset: 0x98
		private TaskAwaiter <>u__2; //Field offset: 0xA0
		private TaskAwaiter <>u__3; //Field offset: 0xA8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum AssemblyType
	{
		Local = 0,
		Online = 1,
		Nevermind = 2,
	}

	internal enum EClearPoolType
	{
		Default = 0,
		Quick = 1,
		NoDispose = 2,
	}

	internal class PoolLogger : AbstractLogger
	{
		private static PoolLogger _instance; //Field offset: 0x0

		public static PoolLogger Instance
		{
			 get { } //Length: 311
		}

		private PoolLogger() { }

		public void ErrorObjectIsAlreadyInPool(TAssetPoolObject poolObject) { }

		public static PoolLogger get_Instance() { }

		public virtual void Log(LogLevel logLevel, string format, object[] args) { }

		[Conditional("UNITY_EDITOR")]
		public void TracePop(TAssetPoolObject poolObject, AbstractAssetsPool abstractAssetsPool) { }

		[Conditional("UNITY_EDITOR")]
		public void TracePush(TAssetPoolObject poolObject, AbstractAssetsPool abstractAssetsPool) { }

	}

	internal struct PoolResourceInfo
	{
		public ResourceKey ResourceKey; //Field offset: 0x0
		public bool CreatePool; //Field offset: 0x8
		public int PoolSize; //Field offset: 0xC
		public ResourceTypeInfo ResourceType; //Field offset: 0x10

	}

	private class Pools : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action <>9__25_0; //Field offset: 0x8
			public static Action <>9__26_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal void <Dispose>b__25_0(IAssetPool assetPool) { }

			internal void <QuickDispose>b__26_0(IAssetPool assetPool) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			private struct <<InitAndFillPools>g__ReportOnComplete|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public Task task; //Field offset: 0x20
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public IProgress progress; //Field offset: 0x10
			public int completed; //Field offset: 0x18

			public <>c__DisplayClass13_0() { }

			[AsyncStateMachine(typeof(<<InitAndFillPools>g__ReportOnComplete|0>d))]
			internal Task <InitAndFillPools>g__ReportOnComplete|0(Task task) { }

		}

		[CompilerGenerated]
		private struct <ExpandPoolSafe>d__15 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Pools <>4__this; //Field offset: 0x20
			public PoolResourceInfo resourceKey; //Field offset: 0x28
			public YieldDelegate yield; //Field offset: 0x48
			public CancellationToken cancellationToken; //Field offset: 0x50
			private TaskAwaiter <>u__1; //Field offset: 0x58

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <InitAndFillPools>d__13 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IProgress progress; //Field offset: 0x20
			public CancellationToken cancellationToken; //Field offset: 0x28
			public IList resourceInfo; //Field offset: 0x30
			public Pools <>4__this; //Field offset: 0x38
			public AssemblyType assemblyType; //Field offset: 0x40
			public YieldDelegate yield; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <InitializeAssetsPool>d__16 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Pools <>4__this; //Field offset: 0x20
			public PoolResourceInfo resourceKey; //Field offset: 0x28
			public AssemblyType assemblyType; //Field offset: 0x48
			public YieldDelegate yield; //Field offset: 0x50
			private TaskAwaiter <>u__1; //Field offset: 0x58

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <InitializeAssetsPoolSafe>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Pools <>4__this; //Field offset: 0x20
			public PoolResourceInfo resourceKey; //Field offset: 0x28
			public AssemblyType assemblyType; //Field offset: 0x48
			public YieldDelegate yield; //Field offset: 0x50
			private TaskAwaiter <>u__1; //Field offset: 0x58

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal class AssetPoolData
		{
			public TaskCompletionSource Source; //Field offset: 0x10
			public int RequestCount; //Field offset: 0x18
			public CancellationTokenSource CancellationSource; //Field offset: 0x20
			public Token BundleToken; //Field offset: 0x28
			public bool DontDestroy; //Field offset: 0x30
			public int LastRaidUseNumber; //Field offset: 0x34

			public AssetPoolData() { }

			public void RemovePool(bool quick) { }

		}

		private readonly IEasyAssets _easyAssets; //Field offset: 0x10
		public readonly Transform ParentTransform; //Field offset: 0x18
		private Transform _dontDestroyParent; //Field offset: 0x20
		public Transform UnloadableParent; //Field offset: 0x28
		public readonly ObjectsFactoryConfig Config; //Field offset: 0x30
		public readonly Dictionary PoolsDictionary; //Field offset: 0x38
		private readonly AssemblyType _defaultAssemblyType; //Field offset: 0x40
		public AssetsPool PlayerAssetPool; //Field offset: 0x48
		public AssetsPool PlayerZombieAssetPool; //Field offset: 0x50
		private CancellationTokenSource _poolCancellationSource; //Field offset: 0x58

		public Pools(IEasyAssets easyAssets, Transform parentTransform, ObjectsFactoryConfig config, AssemblyType defaultAssemblyType, out CancellationToken cancellationToken) { }

		[CompilerGenerated]
		private void <UnloadPools>b__22_0(ResourceKey x) { }

		[CompilerGenerated]
		private void <UnloadUselessPools>b__21_0(ResourceKey x) { }

		public void AddToken(ResourceKey key, Token token) { }

		public List ConvertResourceInfo(ICollection resources) { }

		private PoolResourceInfo ConvertResourceInfo(ResourceKey resource) { }

		private void Dispose(Action disposeMethod) { }

		public override void Dispose() { }

		[AsyncStateMachine(typeof(<ExpandPoolSafe>d__15))]
		private Task ExpandPoolSafe(PoolResourceInfo resourceKey, YieldDelegate yield, CancellationToken cancellationToken) { }

		[AsyncStateMachine(typeof(<InitAndFillPools>d__13))]
		public Task InitAndFillPools(IList resourceInfo, AssemblyType assemblyType, YieldDelegate yield, IProgress progress = null, CancellationToken cancellationToken = null) { }

		[AsyncStateMachine(typeof(<InitializeAssetsPool>d__16))]
		private Task InitializeAssetsPool(PoolResourceInfo resourceKey, AssemblyType assemblyType, YieldDelegate yield) { }

		[AsyncStateMachine(typeof(<InitializeAssetsPoolSafe>d__14))]
		private Task InitializeAssetsPoolSafe(PoolResourceInfo resourceKey, AssemblyType assemblyType, YieldDelegate yield, CancellationToken cancellationToken) { }

		private void MaintainMinPoolSize(IAssetPool assetPool) { }

		public GameObject PopOrCreate(ResourceKey resourceKey, bool canInitializeAssetPool = false) { }

		public void QuickDispose() { }

		private void RemovePool(ResourceKey key, bool quickDispose) { }

		private void RemovePool(IAssetPool pool, bool quickDispose) { }

		public void UnloadPools() { }

		public void UnloadUselessPools(int currentRaidNumber, int diff) { }

	}

	internal enum PoolsCategory
	{
		Raid = 0,
	}

	internal class ResourceTypeComparer : IEqualityComparer
	{

		public ResourceTypeComparer() { }

		public override bool Equals(ResourceType x, ResourceType y) { }

		public override int GetHashCode(ResourceType obj) { }

	}

	private static CancellationTokenSource _defaultCancellationSource; //Field offset: 0x0
	private Dictionary _poolsDontDestroyConfig; //Field offset: 0x10
	public bool IgnorePools; //Field offset: 0x18
	public readonly IEasyAssets EasyAssets; //Field offset: 0x20
	private readonly IRaidCounter _raidCounter; //Field offset: 0x28
	private readonly Dictionary _pools; //Field offset: 0x30
	private readonly Dictionary _cancellationTokens; //Field offset: 0x38
	private Dictionary _loadedBundles; //Field offset: 0x40
	private Dictionary _loadedBundlesPaths; //Field offset: 0x48

	private static ItemTemplates CurrentItemTemplates
	{
		private get { } //Length: 61
	}

	private int CurrentRaidNum
	{
		private get { } //Length: 81
	}

	public static CancellationToken DefaultCancellationToken
	{
		 get { } //Length: 99
	}

	public static PoolLogger Logger
	{
		 get { } //Length: 311
	}

	public CancellationToken PoolsCancellationToken
	{
		 get { } //Length: 791
	}

	private static ObjectsFactory() { }

	public ObjectsFactory(IEasyAssets easyAssets, ItemTemplates itemTemplates, IRaidCounter raidCounter) { }

	[CompilerGenerated]
	internal static void <LoadBundlesAndCreatePools>g__FillLoadedBundles|31_1(List bundlesList, Dictionary loadedBundles, TokenContainer container) { }

	[AsyncStateMachine(typeof(<AssembleMods>d__50))]
	private Task AssembleMods(ContainerCollection collection, bool isHandsItem, ECameraType cameraType, IPlayer player, bool isAnimated, GameObject itemGameObject, AssetPoolObject poolObject, Transform weaponHierarchy, CancellationToken ct, YieldDelegate yield) { }

	[AsyncStateMachine(typeof(<AttachMods>d__43))]
	private Task AttachMods(ContainerCollection containerCollection, ContainerCollectionView collectionView, ECameraType cameraType, IPlayer player, bool isAnimated, CancellationToken ct, YieldDelegate yield) { }

	public void ClearPools(PoolsCategory poolsCategory, EClearPoolType clearPoolType) { }

	public GameObject CreateCleanLootPrefab(Item item, ECameraType cameraType, IPlayer player = null) { }

	[AsyncStateMachine(typeof(<CreateCleanLootPrefabAsync>d__52))]
	public Task CreateCleanLootPrefabAsync(Item item, IPlayer player = null) { }

	public T CreateFromPool(ResourceKey resourceKey) { }

	public GameObject CreateItem(Item item, ECameraType cameraType, IPlayer player, bool isAnimated) { }

	public GameObject CreateItem(Item item, bool isAnimated) { }

	[AsyncStateMachine(typeof(<CreateItemAsync>d__49))]
	public Task CreateItemAsync(Item item, ECameraType cameraType, IPlayer player, bool isAnimated, YieldDelegate yield, CancellationToken ct = null) { }

	[CanBeNull]
	public GameObject CreateItemUsablePrefab(Item item, IPlayer player) { }

	public Task CreateItemUsablePrefabAsync(Item item, IPlayer player) { }

	public GameObject CreateLootPrefab(Item item, ECameraType cameraType, IPlayer player = null) { }

	public GameObject CreatePlayerObject(ResourceKey assetName) { }

	private void EnableLootCollider(Collider collider, AssetPoolObject asset) { }

	private static ItemTemplates get_CurrentItemTemplates() { }

	private int get_CurrentRaidNum() { }

	public static CancellationToken get_DefaultCancellationToken() { }

	public static PoolLogger get_Logger() { }

	public CancellationToken get_PoolsCancellationToken() { }

	public bool GetPoolDontDestroy(ResourceType type) { }

	private Pools GetPools(PoolsCategory category) { }

	public int GetPoolsCount(PoolsCategory category) { }

	private static GameObject InstantiateWithoutPool(IEasyAssets easyAssets, ResourceKey resourceKey) { }

	private static GameObject InstantiateWithoutPool(IEasyAssets easyAssets, ResourceKey resourceKey, ResourceTypeInfo resourceType) { }

	public bool IsPoolReady(PoolsCategory category) { }

	public Task LoadBundlesAndCreatePools(PoolsCategory poolsCategory, AssemblyType assemblyType, ICollection resources, YieldDelegate yield, IProgress progress = null, CancellationToken ct = null) { }

	[AsyncStateMachine(typeof(<LoadBundlesAndCreatePools>d__31))]
	private Task LoadBundlesAndCreatePools(Pools pools, List resources, AssemblyType assemblyType, YieldDelegate yield, IProgress progress = null, CancellationToken ct = null) { }

	protected GameObject PopOrCreate(ResourceKey resourceKey, PoolsCategory poolCategory) { }

	[AsyncStateMachine(typeof(<RegisterLoadBundlesAndCreatePools>d__33))]
	public Task RegisterLoadBundlesAndCreatePools(PoolsCategory poolsCategory, Transform parentTransform, ObjectsFactoryConfig config, AssemblyType assemblyType, ResourceKey[] resources, YieldDelegate yield, IProgress progress = null, CancellationToken ct = null) { }

	public void RegisterPools(PoolsCategory poolsCategory, Transform parentTransform, ObjectsFactoryConfig config, AssemblyType defaultAssemblyType = 2) { }

	public static void SetupGameObjectWithoutPool(ResourceTypeInfo resourceType, GameObject gameObject) { }

	public void UnloadBundles() { }

	public void UnloadTemporaryPools(bool cleanUselessPools) { }

	public void UnloadTemporaryPoolsForTransit() { }

}

