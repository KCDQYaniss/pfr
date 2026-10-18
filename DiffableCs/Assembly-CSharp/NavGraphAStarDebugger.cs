//Type is in global namespace

public class NavGraphAStarDebugger
{
	private readonly Dictionary _steps; //Field offset: 0x10
	private NavGraphAStarDebuggerStepData _curStep; //Field offset: 0x18
	private readonly int searchId; //Field offset: 0x20

	public NavGraphAStarDebugger(int searchId) { }

	public void AddStep(int step, NavGraphEditorPoint currentNode) { }

	public void Finish() { }

	public string Print() { }

	public void TestNeighbour(int neighbour) { }

	public void TestNeighbourHeuristic(NavGraphEditorPoint neighbour, float heuristic) { }

	public void TestNeighbourVisited(NavGraphEditorPoint neighbour, bool isVisited) { }

}

