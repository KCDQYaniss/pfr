//Type is in global namespace

[RequireComponent(typeof(NavMeshObstacle))]
public class TrainNavMeshCutter : MonoBehaviour
{
	public ETravelState CarvingOn; //Field offset: 0x20
	public ETravelState CarvingOff; //Field offset: 0x24
	private GlobalEventDispatcher eventDispatcher; //Field offset: 0x28
	private NavMeshObstacle _obstacle; //Field offset: 0x30

	public TrainNavMeshCutter() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnTrainCome(ETravelState obj) { }

	private void Start() { }

}

