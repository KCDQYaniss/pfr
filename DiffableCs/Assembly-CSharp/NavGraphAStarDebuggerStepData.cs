//Type is in global namespace

public class NavGraphAStarDebuggerStepData
{
	private readonly int step; //Field offset: 0x10
	private readonly int countNeigh; //Field offset: 0x14
	private readonly bool _isInited; //Field offset: 0x18
	private readonly NavGraphEditorPoint currentNode; //Field offset: 0x20
	private readonly HashSet _simple; //Field offset: 0x28
	private readonly Dictionary _visited; //Field offset: 0x30
	private readonly Dictionary _heuristic; //Field offset: 0x38
	private readonly StringBuilder _idsList; //Field offset: 0x40

	public NavGraphAStarDebuggerStepData(int step, NavGraphEditorPoint currentNode) { }

	public string Print() { }

	public void TestNeighbour(int neighbour) { }

	public void TestNeighbourHeuristic(NavGraphEditorPoint neighbour, float heuristic) { }

	public void TestNeighbourVisited(NavGraphEditorPoint neighbour, bool isVisited) { }

}

