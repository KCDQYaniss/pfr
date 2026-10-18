namespace EFT.SynchronizableObjects;

public sealed class BaseTripwire : ISynchronizableLogic
{
	private TripwireSynchronizableObject _tripwireSyncObject; //Field offset: 0x10
	private SynchronizableObjectType _objectType; //Field offset: 0x18
	private bool _lastContactState; //Field offset: 0x1C
	[CompilerGenerated]
	private Nullable <_lastState>k__BackingField; //Field offset: 0x20

	private Nullable _lastState
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private ISyncEnvironment GameWorld
	{
		private get { } //Length: 46
	}

	private Rigidbody SyncObjectRigidbody
	{
		private get { } //Length: 73
	}

	private Transform SyncObjectTransform
	{
		private get { } //Length: 90
	}

	public BaseTripwire() { }

	public override void CollisionEnter(Collider colliderComponent) { }

	[CompilerGenerated]
	private Nullable get__lastState() { }

	private ISyncEnvironment get_GameWorld() { }

	private Rigidbody get_SyncObjectRigidbody() { }

	private Transform get_SyncObjectTransform() { }

	public override void Init(int objectId, Vector3 position, Vector3 rotation) { }

	public override void InitStaticObject() { }

	public override void ManualUpdate(float deltaTime) { }

	private void ProcessSpawnTripwire(string itemId, string templateId, int playerRaidId, Vector3 fromPosition, Vector3 toPosition) { }

	public override void ReturnToPool() { }

	[CompilerGenerated]
	private void set__lastState(Nullable value) { }

	public override void SetSyncObject(SynchronizableObject syncObject) { }

	public override void TakeFromPool() { }

	public void TriggerTripwire() { }

	public override void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

