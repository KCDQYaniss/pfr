namespace EFT.Interactive;

public class Corpse : LootItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal MongoID <LoadCustomizationResources>b__31_1(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public List customizationsData; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal ResourceKey[] <LoadCustomizationResources>b__0() { }

	}

	[CompilerGenerated]
	private struct <InitBody>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BodyCustomization customization; //Field offset: 0x20
		public Corpse <>4__this; //Field offset: 0x28
		public InventoryEquipment equipment; //Field offset: 0x30
		public EPlayerSide playerSide; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCustomizationResources>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List customizationsData; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float MAX_TIME = 15; //Field offset: 0x0
	private RigidbodySpawner[] _rigidbodySpawners; //Field offset: 0x118
	private CharacterJointSpawner[] _jointSpawners; //Field offset: 0x120
	private List _rigidbodySleepHierarchy; //Field offset: 0x128
	protected Action _itemInHandsLooted; //Field offset: 0x130
	public bool UnlootableCorpseOnDeath; //Field offset: 0x138
	[CompilerGenerated]
	private BodyCustomization <Customization>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private EPlayerSide <Side>k__BackingField; //Field offset: 0x148
	private TransformSync[] _transformSyncs; //Field offset: 0x150
	protected Transform _pelvis; //Field offset: 0x158
	private Vector3 _velocity; //Field offset: 0x160
	[CompilerGenerated]
	private bool <HasRagdoll>k__BackingField; //Field offset: 0x16C
	protected PlayerBody PlayerBody; //Field offset: 0x170
	public BindableState ItemInHands; //Field offset: 0x178
	public CorpseRagdoll Ragdoll; //Field offset: 0x180
	public string PlayerProfileID; //Field offset: 0x188

	protected override CollisionDetectionMode CollisionDetectionMode
	{
		 get { } //Length: 3
	}

	public private BodyCustomization Customization
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HasRagdoll
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private EPlayerSide Side
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual Transform TrackableTransform
	{
		 get { } //Length: 8
	}

	public TransformSync[] TransformSyncs
	{
		 get { } //Length: 122
	}

	public TransformSync[] TransformSyncsRelativeToPlatform
	{
		 get { } //Length: 1422
	}

	public Corpse() { }

	protected override void ApplyTransformSync(TransformSync[] transformSyncs) { }

	private void Awake() { }

	protected virtual void CacheComponents() { }

	protected override bool CheckCorpseIsStill(bool sleeping, float timePass) { }

	public static T CreateCorpse(GameObject gameObject, string playerProfileID, InventoryEquipment equipment, BodyCustomization customization, bool reinitBody, GameWorld gameWorld, EPlayerSide side, Vector3 velocity, Transform pelvis, BindableState itemInHands, bool foreStillCorpse, ContainerCollectionView containerCollectionView, MongoID firstID = null) { }

	public static T CreateStillCorpse(GameWorld gameWorld, JsonCorpse corpseJson, MovingPlatform platform) { }

	protected override CollisionDetectionMode get_CollisionDetectionMode() { }

	[CompilerGenerated]
	public BodyCustomization get_Customization() { }

	[CompilerGenerated]
	public bool get_HasRagdoll() { }

	[CompilerGenerated]
	public EPlayerSide get_Side() { }

	public virtual Transform get_TrackableTransform() { }

	public TransformSync[] get_TransformSyncs() { }

	public TransformSync[] get_TransformSyncsRelativeToPlatform() { }

	private TransformSync[] GetTransformSync() { }

	private void Init(string playerProfileID, InventoryEquipment equipment, BodyCustomization customization, bool reinitBody, GameWorld gameWorld, EPlayerSide side, Vector3 velocity, Transform pelvis, bool ragdollEnabled, BindableState itemInHands, bool foreStillCorpse, ContainerCollectionView containerCollectionView = null, MongoID firstId = null) { }

	[AsyncStateMachine(typeof(<InitBody>d__35))]
	private Task InitBody(BodyCustomization customization, InventoryEquipment equipment, int layer, EPlayerSide playerSide, string playerProfileID = "") { }

	public virtual void Kill() { }

	[AsyncStateMachine(typeof(<LoadCustomizationResources>d__31))]
	private Task LoadCustomizationResources(List customizationsData) { }

	private void PlayCorpseDropSound() { }

	protected virtual void RemoveLootItem(RemoveItemEventArgs args) { }

	[CompilerGenerated]
	private void set_Customization(BodyCustomization value) { }

	[CompilerGenerated]
	private void set_HasRagdoll(bool value) { }

	[CompilerGenerated]
	private void set_Side(EPlayerSide value) { }

	public void SetItemInHandsLootedCallback(Action itemInHandsLooted) { }

	private void TryToCreateRagdoll(bool forceStill = false) { }

}

