//Type is in global namespace

public class SpatialAudioRoom : MonoBehaviour, ISpatialAudioRoom, ISpatialRoom
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__62_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <IsRoomValid>b__62_0(BaseSpatialAudioPortal connectingPortal) { }

	}

	internal class RoomConnection
	{
		public SpatialAudioRoom connectedRoom; //Field offset: 0x10
		public BaseSpatialAudioPortal[] connectingPortals; //Field offset: 0x18

		public RoomConnection() { }

	}

	private const short INVALID_ID = -1; //Field offset: 0x0
	private readonly SpatialAudioRoomLogger _logger; //Field offset: 0x20
	[HideInInspector]
	public int priority; //Field offset: 0x28
	[Range(0, 1)]
	public float WallOcclusion; //Field offset: 0x2C
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x30
	public List Areas; //Field offset: 0x38
	[SerializeField]
	private bool Outdoor; //Field offset: 0x40
	[SerializeField]
	private bool Isolated; //Field offset: 0x41
	[SerializeField]
	private EAudioRoomTypeMask _type; //Field offset: 0x44
	[Tooltip("experimental options to fit room in scene geometry")]
	public bool FitToGeometry; //Field offset: 0x48
	public List roomConnections; //Field offset: 0x50
	public List allPortals; //Field offset: 0x58
	[SerializeField]
	private short _iD; //Field offset: 0x60
	[HideInInspector]
	[SerializeField]
	private float _roomSize; //Field offset: 0x64
	[HideInInspector]
	[SerializeField]
	private Bounds _bounds; //Field offset: 0x68
	[HideInInspector]
	[SerializeField]
	private AudioRoomAreaColliderCache[] _colliderCache; //Field offset: 0x80
	public RoomAmbientData AmbientData; //Field offset: 0x88
	private readonly Dictionary _playersEnteredAreasCount; //Field offset: 0x90
	private ISoundPlayer _roomAmbientSoundPlayer; //Field offset: 0x98
	private HashSet _connectedRoomsIDs; //Field offset: 0xA0
	[CompilerGenerated]
	private BoxCollider[] <Colliders>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0xB0
	public bool OnlyWired; //Field offset: 0xB1

	public override Bounds Bounds
	{
		 get { } //Length: 21
	}

	public override AudioRoomAreaColliderCache[] ColliderCache
	{
		 get { } //Length: 8
	}

	public private override BoxCollider[] Colliders
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override short ID
	{
		 get { } //Length: 5
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool IsIsolated
	{
		 get { } //Length: 5
	}

	public override bool IsOutdoor
	{
		 get { } //Length: 5
	}

	public override bool IsValid
	{
		 get { } //Length: 18
	}

	public private override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Vector3 Position
	{
		 get { } //Length: 30
	}

	public override RoomAmbientData RoomAmbientData
	{
		 get { } //Length: 8
	}

	public override float RoomSize
	{
		 get { } //Length: 6
	}

	public override EAudioRoomTypeMask Type
	{
		 get { } //Length: 4
	}

	public SpatialAudioRoom() { }

	private void AddAllPortals() { }

	private void AppendRoomToPortal() { }

	private void AudioTriggerAreaEventArgsHandle(object sender, AudioTriggerAreaEventArgs eventArgs) { }

	protected override void Awake() { }

	private float CalculateSize() { }

	public override bool CheckIsolationRelation(ISpatialAudioRoom roomToCheck) { }

	private void CollectConnectedRoomsIds() { }

	public override Bounds get_Bounds() { }

	public override AudioRoomAreaColliderCache[] get_ColliderCache() { }

	[CompilerGenerated]
	public override BoxCollider[] get_Colliders() { }

	public override short get_ID() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public override bool get_IsIsolated() { }

	public override bool get_IsOutdoor() { }

	public override bool get_IsValid() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public Vector3 get_Position() { }

	public override RoomAmbientData get_RoomAmbientData() { }

	public override float get_RoomSize() { }

	public override EAudioRoomTypeMask get_Type() { }

	private void GetAreaColliders() { }

	public override List GetPortals() { }

	private Bounds GetRoomBounds() { }

	public void Initialize() { }

	public bool IsConnected(int targetRoomID) { }

	public bool IsRoomConnected(short roomID) { }

	private bool IsRoomValid() { }

	private void OnDestroy() { }

	protected override void OnTriggerEvent(AudioTriggerAreaEventArgs eventArgs) { }

	public override void PlayRoomToneSound() { }

	[CompilerGenerated]
	private void set_Colliders(BoxCollider[] value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	private void SetRoomName() { }

	public override void StopRoomToneSound() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

