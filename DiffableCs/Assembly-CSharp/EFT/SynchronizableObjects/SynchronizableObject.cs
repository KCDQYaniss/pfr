namespace EFT.SynchronizableObjects;

public class SynchronizableObject : SerializedMonoBehaviour
{
	private ISynchronizableLogic _syncLogic; //Field offset: 0x60
	public SynchronizableObjectType Type; //Field offset: 0x68
	public int ObjectId; //Field offset: 0x6C
	public int UniqueId; //Field offset: 0x70
	public bool IsActive; //Field offset: 0x74
	public bool IsInited; //Field offset: 0x75
	public bool IsStatic; //Field offset: 0x76
	[CompilerGenerated]
	private Nullable <ObjectState>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnUpdateRequired; //Field offset: 0x80

	public event Action OnUpdateRequired
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public ISynchronizableLogic Logic
	{
		 get { } //Length: 5
	}

	public Nullable ObjectState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SynchronizableObject() { }

	[CompilerGenerated]
	public void add_OnUpdateRequired(Action value) { }

	public void CollisionEnter(Collider colliderComponent) { }

	public override void Deserialize(NetworkReader reader) { }

	public ISynchronizableLogic get_Logic() { }

	[CompilerGenerated]
	public Nullable get_ObjectState() { }

	public void Init(int objectId, Vector3 position, Vector3 rotation) { }

	public void InitStaticObject() { }

	public void ManualUpdate(float deltaTime) { }

	[CompilerGenerated]
	public void remove_OnUpdateRequired(Action value) { }

	public void ReturnToPool() { }

	[CompilerGenerated]
	public void set_ObjectState(Nullable value) { }

	public void SetLogic(ISynchronizableLogic synchronizableLogic) { }

	public void TakeFromPool() { }

	protected void UpdateRequired() { }

	public void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

