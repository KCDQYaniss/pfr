//Type is in global namespace

public class EnvironmentManagerBase : MonoBehaviour
{
	[CompilerGenerated]
	private struct <IE_CheckTriggers>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EnvironmentManagerBase <>4__this; //Field offset: 0x20
		private List <allPlayers>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private int <i>5__3; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal interface IAABB
	{

		public IndoorTrigger Check(Vector3 pos) { }

		public void Reinit() { }

	}

	protected static EnvironmentManagerBase _instance; //Field offset: 0x0
	protected Dictionary _cachedPlayerTrigger; //Field offset: 0x20
	protected TriggerGroup _rootTriggerGroup; //Field offset: 0x28
	private bool _haveRoot; //Field offset: 0x30
	private bool _working; //Field offset: 0x31
	private CancellationTokenSource _checkTriggersCancelationToken; //Field offset: 0x38

	public static EnvironmentManagerBase Instance
	{
		 get { } //Length: 59
	}

	public EnvironmentManagerBase() { }

	private void Awake() { }

	public static EnvironmentManagerBase get_Instance() { }

	[AsyncStateMachine(typeof(<IE_CheckTriggers>d__13))]
	private Task IE_CheckTriggers() { }

	protected override void Init() { }

	protected void InitIndoors() { }

	protected override void OnDestroy() { }

	protected override void SetTriggerForPlayer(IPlayer player, IndoorTrigger trigger) { }

	public void Stop() { }

	public int TryFindEnvironmentIdByPos(Vector3 pos) { }

	[CanBeNull]
	public IndoorTrigger TryFindTriggerByPos(Vector3 pos) { }

}

