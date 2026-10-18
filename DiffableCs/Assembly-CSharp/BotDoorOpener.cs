//Type is in global namespace

public class BotDoorOpener
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public BotDoorOpener <>4__this; //Field offset: 0x10
		public Vector3 pointLookForward; //Field offset: 0x18
		public Vector3 pointAfterDoor; //Field offset: 0x24
		public Vector3 firstLookDirection; //Field offset: 0x30
		public float magnitude; //Field offset: 0x3C
		public Vector3 secondLookDirection; //Field offset: 0x40
		public Action <>9__3; //Field offset: 0x50
		public Action <>9__2; //Field offset: 0x58
		public Action <>9__1; //Field offset: 0x60

		public <>c__DisplayClass57_0() { }

		internal void <RunEnteringDoorSequence>b__0() { }

		internal void <RunEnteringDoorSequence>b__1() { }

		internal void <RunEnteringDoorSequence>b__2() { }

		internal void <RunEnteringDoorSequence>b__3() { }

	}

	public const float DIR_SIDE_MAX_SQRT = 4; //Field offset: 0x0
	public const float MAX_DIST_SQR = 4; //Field offset: 0x0
	private const float CHECK_RUN_DIST_SQR = 27.039997; //Field offset: 0x0
	private const float INTERACT_PERIOD_BREACH = 2.7; //Field offset: 0x0
	private const float OPEN_DIST_SQR = 16; //Field offset: 0x0
	private const float PERIOD_DOOR_OPEN = 3; //Field offset: 0x0
	private const float PERIOD_FOR_DOOR_FORCED_STAY_OPENED_AFTER_OPEN_BY_BOT = 15; //Field offset: 0x0
	private const float STOP_SPRINT_DIST_SQR = 27.039997; //Field offset: 0x0
	private const float STOP_SPRINT_PERIOD = 4; //Field offset: 0x0
	private const float DIST_TO_INTERACT = 0.3; //Field offset: 0x0
	private const float DIST_SQR_TO_INTERACT = 0.09; //Field offset: 0x0
	public bool NearDoor; //Field offset: 0x10
	public DoorInteractionStatus _lastFrameDoorInteractionStatus; //Field offset: 0x14
	private NavMeshDoorLink _currentDoorLink; //Field offset: 0x18
	private readonly BotOwner _owner; //Field offset: 0x20
	private float _traversingEnd; //Field offset: 0x28
	private float _searchCloseDoorTime; //Field offset: 0x2C
	private float _comeToDoorLast; //Field offset: 0x30
	private float _nextWaitInteractedDoor; //Field offset: 0x34
	private bool _shallStartInteract; //Field offset: 0x38
	private float _nextStartStop; //Field offset: 0x3C
	private float _refreshWayPeriod; //Field offset: 0x40
	private bool _doBreach; //Field offset: 0x44
	private bool _breachRolledForCurrentDoor; //Field offset: 0x45
	private Vector3 _interactPosition; //Field offset: 0x48
	private bool _enteringDoorSequence; //Field offset: 0x54
	[CompilerGenerated]
	private Action OnEndInteract; //Field offset: 0x58
	[CompilerGenerated]
	private bool <Interacting>k__BackingField; //Field offset: 0x60
	private Door _lastInteractingDoor; //Field offset: 0x68
	private EDoorState _lastInteractingDoorState; //Field offset: 0x70
	private float _prevFrameSDistToDoorInteractionPoint; //Field offset: 0x74
	private float _lastSDistToDoorInteractPointUpdateTime; //Field offset: 0x78
	private float _nextWantPassCheck; //Field offset: 0x7C

	public event Action OnEndInteract
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool HaveDoorToOpen
	{
		 get { } //Length: 203
	}

	public private bool Interacting
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private float InteractPeriodStandart
	{
		private get { } //Length: 55
	}

	public Vector3 LookPoint
	{
		 get { } //Length: 739
	}

	public BotDoorOpener(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnEndInteract(Action value) { }

	private bool CheckCanRun(NavMeshDoorLink link) { }

	public bool DogFightHaveNearestDoor() { }

	private List FindCurrentDoorLinks() { }

	private bool ForcedNotClose(NavMeshDoorLink infoStruct) { }

	public bool get_HaveDoorToOpen() { }

	[CompilerGenerated]
	public bool get_Interacting() { }

	private float get_InteractPeriodStandart() { }

	public Vector3 get_LookPoint() { }

	private NavMeshDoorLink GetClosestLink(List list, NavMeshDoorLink exclude) { }

	private float GetSDistToDoor(NavMeshDoorLink doorLink) { }

	public void Interact(Door door, EInteractionType Etype) { }

	private void InteractionWithDoor() { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	public void remove_OnEndInteract(Action value) { }

	private void RunEnteringDoorSequence() { }

	private bool SearchCloseDoor(List cellDoorLinks, out bool wantPass) { }

	[CompilerGenerated]
	private void set_Interacting(bool value) { }

	public void TraverseDoorLink() { }

	private bool TryPassCurrentDoor() { }

	public DoorInteractionStatus UpdateDoorInteractionStatus() { }

	private void WaitForDoorOpen() { }

	private bool WantPassTheDoor(Vector3 goTo, NavMeshDoorLink infoStruct) { }

}

