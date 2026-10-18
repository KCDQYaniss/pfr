//Type is in global namespace

public class PlantedMineAIInfo
{
	[CompilerGenerated]
	private Action OnDisposed; //Field offset: 0x10
	[CompilerGenerated]
	private readonly TripwireSynchronizableObject <MineObject>k__BackingField; //Field offset: 0x18
	public readonly int Id; //Field offset: 0x20
	public readonly Vector3 MidPosition; //Field offset: 0x24
	public readonly Vector3 FromPosition; //Field offset: 0x30
	public readonly Vector3 ToPosition; //Field offset: 0x3C
	public readonly bool OnNavmesh; //Field offset: 0x48
	private List _connectedVoxeles; //Field offset: 0x50
	private bool _isDisposed; //Field offset: 0x58
	private int _deactivatingBotId; //Field offset: 0x5C
	private float _deactivatingTimeEnd; //Field offset: 0x60
	private bool _isDeactivating; //Field offset: 0x64
	private Vector3 _cachedClosestPoint; //Field offset: 0x68
	private float _cachedClosestPointTime; //Field offset: 0x74

	public event Action OnDisposed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsActive
	{
		 get { } //Length: 233
	}

	public TripwireSynchronizableObject MineObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PlantedMineAIInfo(TripwireSynchronizableObject tripwire, Vector3 midPosition) { }

	[CompilerGenerated]
	public void add_OnDisposed(Action value) { }

	public bool CanTakeToDeactivate(int botId) { }

	public void Deativate() { }

	public void Dispose() { }

	public bool get_IsActive() { }

	[CompilerGenerated]
	public TripwireSynchronizableObject get_MineObject() { }

	public Vector3 GetCachedClosestPoint(Vector3 target) { }

	public void Init(List allNearVoxeles) { }

	private bool IsDeactivatingNow() { }

	private void OnDestroyed(TripwireSynchronizableObject obj) { }

	[CompilerGenerated]
	public void remove_OnDisposed(Action value) { }

	public void SetDeactivate(int botId) { }

}

