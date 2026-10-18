//Type is in global namespace

public class NavMeshDoorLink : MonoBehaviour
{
	private const float COEF_AFFECTED = 9999; //Field offset: 0x0
	public int Id; //Field offset: 0x20
	public string DoorId; //Field offset: 0x28
	public BotOwner Opening; //Field offset: 0x30
	public Vector3 Close1; //Field offset: 0x38
	public Vector3 Close2_Normal; //Field offset: 0x44
	public Vector3 Close2_Breach; //Field offset: 0x50
	public Vector3 FarestClosePoint; //Field offset: 0x5C
	public Vector3 Open1; //Field offset: 0x68
	public Vector3 Open2; //Field offset: 0x74
	public float BottomY; //Field offset: 0x80
	public Vector3 MidOpen; //Field offset: 0x84
	public Vector3 MidClose; //Field offset: 0x90
	public NavMeshObstacle Carver_Opened; //Field offset: 0xA0
	public NavMeshObstacle Carver_Breached; //Field offset: 0xA8
	public NavMeshObstacle Carver_Closed; //Field offset: 0xB0
	public bool ShallTryInteract; //Field offset: 0xB8
	public int ConnectedNavGraphPathOpenStateId; //Field offset: 0xBC
	public int ConnectedNavGraphPathCloseStateId; //Field offset: 0xC0
	public NavGraphEditorPath ConnectedNavGraphOpenStatePath; //Field offset: 0xC8
	public NavGraphEditorPath ConnectedNavGraphCloseStatePath; //Field offset: 0xD0
	private SegmentPoints segmentOpen; //Field offset: 0xD8
	private SegmentPoints segmentClose; //Field offset: 0xE0
	private BotsController _botsController; //Field offset: 0xE8
	private bool _wantCarve; //Field offset: 0xF0
	private float _nextPosibleCarveTime; //Field offset: 0xF4
	private bool _isAffectedByPlayer; //Field offset: 0xF8
	[CompilerGenerated]
	private float <LastOpenByBotTime>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private float <LastInteractByBotTime>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Door <Door>k__BackingField; //Field offset: 0x108

	public private Door Door
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float LastInteractByBotTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float LastOpenByBotTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public SegmentPoints SegmentClose
	{
		 get { } //Length: 240
	}

	public SegmentPoints SegmentOpen
	{
		 get { } //Length: 240
	}

	public NavMeshDoorLink() { }

	private void Awake() { }

	private void Carve() { }

	public void CarveOff() { }

	public void CheckAfterCreatedCarver() { }

	public void DropCoef() { }

	[CompilerGenerated]
	public Door get_Door() { }

	[CompilerGenerated]
	public float get_LastInteractByBotTime() { }

	[CompilerGenerated]
	public float get_LastOpenByBotTime() { }

	public SegmentPoints get_SegmentClose() { }

	public SegmentPoints get_SegmentOpen() { }

	public void Init(BotsController bc) { }

	public void ManualUpdate() { }

	private void OnDoorStateChanged(WorldInteractiveObject obj, EDoorState prevstate, EDoorState nextstate) { }

	private void OnDrawGizmosSelected() { }

	[CompilerGenerated]
	private void set_Door(Door value) { }

	[CompilerGenerated]
	public void set_LastInteractByBotTime(float value) { }

	[CompilerGenerated]
	public void set_LastOpenByBotTime(float value) { }

	public void SetAllCarvers(bool val) { }

	public void SetCoef() { }

	public void SetDoor(Door door, bool withSubscribe) { }

	public bool ShallInteract() { }

	private void TryCarve() { }

	public void TryCreateCrave() { }

}

