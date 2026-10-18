//Type is in global namespace

public abstract class AbstractBotPath
{
	protected int _cornerIndex; //Field offset: 0x10
	protected readonly Vector3[] _path; //Field offset: 0x18
	private readonly Vector3 _startPoint; //Field offset: 0x20
	[CompilerGenerated]
	private float <ReachDist>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <LastPathCornerChange>k__BackingField; //Field offset: 0x30
	public Action onPathCornerChanged; //Field offset: 0x38

	public Vector3[] Corners
	{
		 get { } //Length: 5
	}

	public int CurIndex
	{
		 get { } //Length: 164
	}

	public string DebugInfo
	{
		 get { } //Length: 49
	}

	public float LastPathCornerChange
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int Length
	{
		 get { } //Length: 26
	}

	public float ReachDist
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public abstract IPathTargetPoint TargetPoint
	{
		 get { } //Length: 0
	}

	protected AbstractBotPath(Vector3[] path) { }

	public float CalculatePathLength(Vector3 curPos) { }

	public void CheckIsFinished(BotOwner bot) { }

	public abstract void Complete() { }

	public void CurPathChanged() { }

	public Vector3 CurrentCorner() { }

	public abstract void DrawDebugWay(float upCoef) { }

	public abstract void DrawSelectedGizmosWay(float upCoef, Color color) { }

	public Vector3[] get_Corners() { }

	public int get_CurIndex() { }

	public string get_DebugInfo() { }

	[CompilerGenerated]
	public float get_LastPathCornerChange() { }

	public int get_Length() { }

	[CompilerGenerated]
	public float get_ReachDist() { }

	public abstract IPathTargetPoint get_TargetPoint() { }

	public List GetCornersFromIndex(int startIndex) { }

	public Vector3 GetPoint(int index) { }

	public Vector3 GetReturnPoint() { }

	public void IncCornerIndex() { }

	public bool IsLast() { }

	public bool IsPointOnWay(Vector3 p, float distToBeClose) { }

	public abstract bool IsSame(Vector3 target, Vector3 ownerPosition) { }

	public abstract bool IsSame(IAICorePointLink target, Vector3 ownerPosition) { }

	public Vector3 LastCorner() { }

	[CompilerGenerated]
	protected void set_LastPathCornerChange(float value) { }

	[CompilerGenerated]
	protected void set_ReachDist(float value) { }

	public void SetReachDist(float reachDist) { }

}

