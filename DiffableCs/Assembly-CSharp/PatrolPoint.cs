//Type is in global namespace

public class PatrolPoint : MonoBehaviour, IPositionPoint, IAICorePointLink
{
	[SerializeField]
	private int _corePointId; //Field offset: 0x20
	public int Id; //Field offset: 0x24
	public bool CanUseByBoss; //Field offset: 0x28
	public PatrolWay PatrolWay; //Field offset: 0x30
	public bool ShallSit; //Field offset: 0x38
	public PatrolPointType PatrolPointType; //Field offset: 0x3C
	public AReserveWayAction ActionData; //Field offset: 0x40
	public PointWithLookSides PointWithLookSides; //Field offset: 0x48
	public bool SubManual; //Field offset: 0x50
	[SerializeField]
	private List subPoints; //Field offset: 0x58
	private bool _errorPrinted; //Field offset: 0x60
	[CompilerGenerated]
	private BotOwner <Owner>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private AICorePoint <CorePointInGame>k__BackingField; //Field offset: 0x70

	public int CorePointId
	{
		 get { } //Length: 4
	}

	public private override AICorePoint CorePointInGame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveLookSide
	{
		 get { } //Length: 21
	}

	public int IdPoint
	{
		 get { } //Length: 4
	}

	public int LookIndexes
	{
		 get { } //Length: 261
	}

	public private BotOwner Owner
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Vector3 position
	{
		 get { } //Length: 204
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public int SubPointsCount
	{
		 get { } //Length: 65
	}

	public PatrolPoint() { }

	private void Awake() { }

	public void CheckData(PatrolWay way) { }

	private void CheckDeprecatedLookDirections() { }

	private bool CreateSubAtPos(Vector3 pos, float offset, float yOffset, float sampleOffset, bool checkDdist) { }

	public void CreateSubPoints(PatrolWay way) { }

	private void CreatSubs(float offset, float yOffset = 0) { }

	private void DrawSelf() { }

	public int get_CorePointId() { }

	[CompilerGenerated]
	public override AICorePoint get_CorePointInGame() { }

	public bool get_HaveLookSide() { }

	public int get_IdPoint() { }

	public int get_LookIndexes() { }

	[CompilerGenerated]
	public BotOwner get_Owner() { }

	public Vector3 get_position() { }

	public override Vector3 get_Position() { }

	public int get_SubPointsCount() { }

	public Nullable GetLookDirection(int index, bool wasCutted) { }

	public int GetOwnerId() { }

	public PatrolPoint GetSubPoint(int index) { }

	private void InGameDraw() { }

	private void InnerDraw() { }

	public bool IsFreeFor(IBotOwner botOwner = null) { }

	private bool IsGoodEnoughPositionForSubPoint(Vector3 from, float y, out NavMeshHit hit) { }

	public Vector3 LookDir(int index) { }

	protected override void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public Vector3 PositionForTest() { }

	private List RefreshData() { }

	public void Restore(AICorePointHolder holder) { }

	[CompilerGenerated]
	private void set_CorePointInGame(AICorePoint value) { }

	[CompilerGenerated]
	private void set_Owner(BotOwner value) { }

	public void SetCorePoint(AICorePoint point) { }

	public void SetOwner(BotOwner owner) { }

	public void SetWay(PatrolWay patrolWay) { }

	private void ShowSubPoints() { }

	public void TryAutoFixActionData() { }

}

