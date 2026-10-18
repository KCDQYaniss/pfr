//Type is in global namespace

public class AICoreController
{
	private static readonly Stopwatch _agentUpdateMeasureSw; //Field offset: 0x0
	private bool _enable; //Field offset: 0x10
	private int _errorsPrinted; //Field offset: 0x14
	private readonly HashSet _listAgents; //Field offset: 0x18
	private readonly HashSet _listToDel; //Field offset: 0x20
	private readonly HashSet _listOfErrors; //Field offset: 0x28

	private static AICoreController() { }

	public AICoreController() { }

	public void Activate() { }

	public void AddNodeController(AICoreAgentBase aiCoreAgentM) { }

	private void Clear() { }

	public HashSet ListAgents() { }

	private void OnDrawGizmos() { }

	public void RemoveNodeController(AICoreAgentBase nodesController) { }

	public void Stop() { }

	public void Update() { }

}

