//Type is in global namespace

public class NavGraphFindDebug
{
	public Vector3 CenterPosition; //Field offset: 0x10
	public int StartPoint; //Field offset: 0x1C
	public CoverShootType ShootType; //Field offset: 0x20
	public int BotId; //Field offset: 0x24
	public List StepsInfo; //Field offset: 0x28
	public string EndInfo; //Field offset: 0x30
	public string ZoneName; //Field offset: 0x38
	public NavGraphEditorPoint[] ResultWay; //Field offset: 0x40
	public int[] ResultWayIds; //Field offset: 0x48
	private int _step; //Field offset: 0x50
	private readonly HashSet _collectedSteps; //Field offset: 0x58
	private NavGraphFindDebugStepInfo _cur; //Field offset: 0x60

	public NavGraphFindDebug(int botId, string zoneName, CoverShootType shootType) { }

	public void AddInfo(int id, ENavGraphFindRemoveCause cause) { }

	public void AddPath(int nextWayPathId) { }

	public void AddResult(NavGraphEditorPoint[] way) { }

	public void BadSearch(string whileEnd) { }

	public void DrawGizmos(int stepConstrain, float radiusConstrain, NavGraphContainer container, int coverSelectId) { }

	public void PrintLogs() { }

	public void Step(float rad, int step) { }

	public bool TryRefreshIdsToPoints(out NavGraphContainer container) { }

}

