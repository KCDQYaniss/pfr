//Type is in global namespace

public sealed class PhysicsCustomOverlapBoxSystem : MonoBehaviour
{
	[DefaultExecutionOrder(-5000)]
	private sealed class PhysicsCustomOverlapBoxSystemHandleResult : MonoBehaviour
	{
		private PhysicsCustomOverlapBoxSystem _owner; //Field offset: 0x20

		public PhysicsCustomOverlapBoxSystemHandleResult() { }

		private void Awake() { }

		private void Update() { }

	}

	[DefaultExecutionOrder(5000)]
	private sealed class PhysicsCustomOverlapBoxSystemScheduler : MonoBehaviour
	{
		private PhysicsCustomOverlapBoxSystem _owner; //Field offset: 0x20

		public PhysicsCustomOverlapBoxSystemScheduler() { }

		private void Awake() { }

		private void LateUpdate() { }

	}

	private const int SEARCHER_CAPACITY = 16; //Field offset: 0x0
	private static PhysicsCustomOverlapBoxSystem _instance; //Field offset: 0x0
	private ScheduledExecute[] _scheduled; //Field offset: 0x20
	private List _searchers; //Field offset: 0x28
	private List _toCleanSearchers; //Field offset: 0x30
	[Header("Debug")]
	public int SearcherCount; //Field offset: 0x38
	public int TotalTriggersCount; //Field offset: 0x3C

	public static PhysicsCustomOverlapBoxSystem Instance
	{
		 get { } //Length: 610
	}

	public PhysicsCustomOverlapBoxSystem() { }

	private void Awake() { }

	public static PhysicsCustomOverlapBoxSystem get_Instance() { }

	private void OnDestroy() { }

	private void ProcessClean() { }

	private void ProcessHandleResult() { }

	private void ProcessSchedule() { }

	public void RegisterSearcher(OverlapBoxSearcher searcher) { }

	public void UnregisterSearcher(OverlapBoxSearcher searcher) { }

}

