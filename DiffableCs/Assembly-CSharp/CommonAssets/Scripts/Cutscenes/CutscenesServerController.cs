namespace CommonAssets.Scripts.Cutscenes;

public class CutscenesServerController : IDisposable
{
	[CompilerGenerated]
	private struct <Init>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CutscenesServerController <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MAX_POOLED_PROCESS_ID_BUFFERS = 4; //Field offset: 0x0
	private MapTimelinesBank _timelinesMapBank; //Field offset: 0x10
	private Dictionary _actions; //Field offset: 0x18
	private CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0x20
	private Action _unsubscribeOnDestroy; //Field offset: 0x28
	private bool _offlineMode; //Field offset: 0x30
	private Dictionary _cutsceneProcesses; //Field offset: 0x38
	private Dictionary _skipIntentionsByProcess; //Field offset: 0x40
	private readonly Stack _processIdBuffersPool; //Field offset: 0x48
	private int _nextProcessId; //Field offset: 0x50
	private float _lagTimeCompensation; //Field offset: 0x54
	private float _syncProcessTime; //Field offset: 0x58

	public CutscenesServerController() { }

	private void BroadcastSkipIntentions(CutsceneProcess process) { }

	public bool CheckPlayerInCutscene(IPlayer player, out CutsceneProcess cutsceneProcess) { }

	private void ClearSkipIntentions(int processId) { }

	private void DeinitAllActions() { }

	public override void Dispose() { }

	private void EndCutscene(string cutsceneId, int cutsceneProcessId, CutsceneProcess process, List playersId, bool skip = false) { }

	private void EndCutscenes(List processIds) { }

	private void FindMapTimelinesBank() { }

	private void ForceEndCutscenesIfPlayersInProcess(List playersId) { }

	public void ImmediateEndAllCutscenes() { }

	[AsyncStateMachine(typeof(<Init>d__13))]
	private Task Init(CancellationToken cancellationToken) { }

	private void InitAction(string actionId, List playersId = null, string cutsceneId = "") { }

	private void InitActions(string[] actionsId, List playersId, string cutsceneId) { }

	private void OnUpdate(float deltaTime) { }

	public void PlayerViewCutsceneComplete(string cutsceneId, int cutsceneProcessId, int playerID) { }

	public void RegisterCutSceneAction(CutsceneBaseAction action) { }

	private void RemoveSkipIntention(CutsceneProcess process, int playerId) { }

	private List RentProcessIdBuffer() { }

	private void ReturnProcessIdBuffer(List buffer) { }

	public void SkipCutscene(int playerId) { }

	public CutsceneProcess StartCutscene(string cutsceneId, List playersId, bool fixedTime = false, bool forceMode = false, float initTime = 0) { }

	public void StartCutsceneWithTime(string cutsceneId, List playersId, bool fixedTime = false, bool forceMode = false) { }

	private void TrimSkipIntentions(CutsceneProcess process) { }

	private bool TryFindTimelineData(string cutsceneId, out MapTimelineData timelineData) { }

}

