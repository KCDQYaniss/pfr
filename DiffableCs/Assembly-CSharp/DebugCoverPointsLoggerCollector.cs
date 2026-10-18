//Type is in global namespace

public class DebugCoverPointsLoggerCollector
{
	private readonly Dictionary _lists; //Field offset: 0x10
	private int _index; //Field offset: 0x18
	private ActiveSet _activeSet; //Field offset: 0x20
	private string _botInfo; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Vector3 <StartPos>k__BackingField; //Field offset: 0x30

	public Vector3 StartPos
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public DebugCoverPointsLoggerCollector(ICoverSearchBot bot, Vector3 startPos) { }

	public void AddGroupsAtStep(HashSet nearGroups, int level) { }

	public void AddKeyInfo(string info, Func getRad) { }

	[CompilerGenerated]
	public Vector3 get_StartPos() { }

	private bool IsEnable() { }

	public void LeaveRecursive(string coverFound) { }

	public void StepRecursiveState() { }

	public void TryPrint(CustomNavigationPoint point, PointsArrayType arrayType, Nullable pointToBeClose, CoverSearchData data, bool logAsError) { }

}

