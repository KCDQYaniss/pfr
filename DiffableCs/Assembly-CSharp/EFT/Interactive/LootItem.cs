namespace EFT.Interactive;

public class LootItem : InteractableObject, IPlatformTransportee
{
	[CompilerGenerated]
	private sealed class <MakeVisibleTimer>d__97 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public LootItem <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <MakeVisibleTimer>d__97(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <PhysicsStopWorker>d__77 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LootItem <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <PhysicsStopWorker>d__77(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected const float _maxPhysicsTime = 15; //Field offset: 0x0
	private const int _preallocatedRendersSize = 8; //Field offset: 0x0
	protected const float DELAY_NEXT_CHECK_COLLISION = 0.5; //Field offset: 0x0
	[ClassStateStorageIgnore]
	private static Collider[] _castColliders; //Field offset: 0x0
	protected const float _maxPhysicsTimeForContinuousDetectionMode = 7.5; //Field offset: 0x0
	protected const float _sqrSpeedToStopContinuousDetectionMode = 0.008; //Field offset: 0x0
	[ClassStateStorageIgnore]
	private static Collider[] _castCollidersTempBuffer; //Field offset: 0x8
	public Vector3 Shift; //Field offset: 0x48
	public ItemController ItemOwner; //Field offset: 0x58
	[CompilerGenerated]
	private MovingPlatform <Platform>k__BackingField; //Field offset: 0x60
	public string Name; //Field offset: 0x68
	public string StaticId; //Field offset: 0x70
	public string ItemId; //Field offset: 0x78
	public string TemplateId; //Field offset: 0x80
	public bool RandomRotation; //Field offset: 0x88
	public MongoID[] ValidProfiles; //Field offset: 0x90
	[CompilerGenerated]
	private IPlayer <LastOwner>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private bool <PerformPickUpValidation>k__BackingField; //Field offset: 0xA0
	protected Rigidbody _rigidBody; //Field offset: 0xA8
	protected float _currentPhysicsTime; //Field offset: 0xB0
	protected float _cullingRegisterRadius; //Field offset: 0xB4
	protected ESurfaceSound _currentSurface; //Field offset: 0xB8
	[ClassStateStorageIgnore]
	[SerializeField]
	private List _renderers; //Field offset: 0xC0
	[ClassStateStorageIgnore]
	[SerializeField]
	private List _lodGroups; //Field offset: 0xC8
	[ClassStateStorageIgnore]
	[SerializeField]
	private List _renderersShadowCastingMode; //Field offset: 0xD0
	[ClassStateStorageIgnore]
	[SerializeField]
	private BoxCollider _boundCollider; //Field offset: 0xD8
	public DisablerCullingObject CullingObject; //Field offset: 0xE0
	private float _nextSurfaceCheck; //Field offset: 0xE8
	private Item _item; //Field offset: 0xF0
	private bool _isWorkCollisionEnter; //Field offset: 0xF8
	private IEnumerator _physicsStopWorker; //Field offset: 0x100
	private bool _startPhysicsOnEnable; //Field offset: 0x108
	private Vector3 _startPosition; //Field offset: 0x10C

	private LayerMask _surfaceCollisionLayerMask
	{
		private get { } //Length: 83
	}

	public BoxCollider BoundCollider
	{
		 get { } //Length: 8
	}

	public bool IsPhysicsOn
	{
		 get { } //Length: 12
	}

	public bool IsVisibilityEnabled
	{
		 get { } //Length: 173
	}

	public Item Item
	{
		 get { } //Length: 8
	}

	public IPlayer LastOwner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private bool PerformPickUpValidation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override float PhysicsQuality
	{
		 get { } //Length: 4
	}

	public MovingPlatform Platform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Rigidbody RigidBody
	{
		 get { } //Length: 8
	}

	private static LootItem() { }

	public LootItem() { }

	protected void AddCacheComponents(IEnumerable renderers, IEnumerable lodGroups) { }

	public override void Board(MovingPlatform platform) { }

	protected override void CacheComponents() { }

	public void CacheParameters() { }

	private bool CheckSurface(Collision collision, float delayToNextCheck = 1) { }

	private bool CheckSurfaceImmediately(Vector3 center) { }

	protected bool CheckSurfaceRayCast(Vector3 center, float delayToNextCheck = 1) { }

	private static T CreateLoot(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, MongoID[] validProfiles, string staticId = null, bool performPickUpValidation = true) { }

	public static void CreateLootContainer(LootableContainer lc, Item item, string name, GameWorld gameWorld, string staticId = null) { }

	public static T CreateLootWithRigidbody(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, MongoID[] validProfiles, out BoxCollider collider, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0) { }

	public static T CreateStaticLoot(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, MongoID[] validProfiles, string staticId = null, bool performPickUpValidation = true, Vector3 shift = null) { }

	public static void CreateStationaryWeapon(StationaryWeapon stationaryWeapon, Item item, string name, GameWorld gameWorld, string staticId = null) { }

	private void DisableShadow(IEnumerable renderers) { }

	private LayerMask get__surfaceCollisionLayerMask() { }

	public BoxCollider get_BoundCollider() { }

	public bool get_IsPhysicsOn() { }

	public bool get_IsVisibilityEnabled() { }

	public Item get_Item() { }

	[CompilerGenerated]
	public IPlayer get_LastOwner() { }

	[CompilerGenerated]
	public bool get_PerformPickUpValidation() { }

	public override float get_PhysicsQuality() { }

	[CompilerGenerated]
	public MovingPlatform get_Platform() { }

	public Rigidbody get_RigidBody() { }

	public int GetNetId() { }

	public override void GetOff(MovingPlatform platform) { }

	protected override ObjectVisibility GetVisibilityChecker() { }

	protected LootItem Init(Item item, string itemName, GameWorld gameWorld, bool randomRotation, MongoID[] validProfiles, string staticId = null, bool performPickUpValidation = true) { }

	protected override void Init() { }

	protected override bool IsRigidbodyDone() { }

	public bool IsValidForProfile(string profileId) { }

	public virtual void Kill() { }

	private void MakeVisible(bool isVisible) { }

	[IteratorStateMachine(typeof(<MakeVisibleTimer>d__97))]
	private IEnumerator MakeVisibleTimer(float delay) { }

	private void OnCollisionEnter(Collision collision) { }

	public virtual void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject) { }

	private void OnEnable() { }

	public virtual void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	protected override void OnRigidbodyStarted() { }

	protected override void OnRigidbodyStopped() { }

	[IteratorStateMachine(typeof(<PhysicsStopWorker>d__77))]
	private IEnumerator PhysicsStopWorker() { }

	protected void PlayDropSound() { }

	private void RegisterInCullingObject() { }

	protected void RegisterInCullingObject(IEnumerable renderers, IEnumerable lodGroups) { }

	protected void RemoveCacheComponents(IEnumerable renderers, IEnumerable lodGroups) { }

	protected override void RemoveLootItem(RemoveItemEventArgs args) { }

	private void ResetShift() { }

	private void RestoreShadows() { }

	protected void RestoreShadows(IEnumerable renderers) { }

	[CompilerGenerated]
	public void set_LastOwner(IPlayer value) { }

	[CompilerGenerated]
	private void set_PerformPickUpValidation(bool value) { }

	[CompilerGenerated]
	public void set_Platform(MovingPlatform value) { }

	public void SetItemAndRigidbody(Item item, Rigidbody rigidbody) { }

	private void SetShift(Vector3 shift) { }

	private static Bounds SetupBoundingCollider(GameObject lootItemGameobject, IEnumerable colliders, BoxCollider resultCollider) { }

	private void StartPhysics() { }

	protected void StopPhysics() { }

	public virtual string ToString() { }

	protected void TryDisableShadow(IEnumerable renderers) { }

	private void TryDisableShadow() { }

	protected void UnregisterFromCullingObject(IEnumerable renderers, IEnumerable lodGroups) { }

	private void UnregisterFromCullingObject() { }

}

