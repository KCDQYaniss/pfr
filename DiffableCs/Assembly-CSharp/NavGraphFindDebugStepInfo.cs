//Type is in global namespace

public class NavGraphFindDebugStepInfo
{
	public int _step; //Field offset: 0x10
	public float Rad; //Field offset: 0x14
	public List DebugPointInfos; //Field offset: 0x18
	public List usedPathId; //Field offset: 0x20

	public NavGraphFindDebugStepInfo(int step, float rad) { }

	public void Add(NavGraphFindDebugPointInfo info) { }

	public void AddUsedPath(int info) { }

	public void DrawGizmos(NavGraphContainer container, int coverSelectId) { }

	public StringBuilder GetInfo() { }

}

