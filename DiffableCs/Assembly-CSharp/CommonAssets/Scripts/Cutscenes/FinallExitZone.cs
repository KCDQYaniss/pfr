namespace CommonAssets.Scripts.Cutscenes;

public class FinallExitZone : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public HashSet cutsceneStartedProfileIds; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal void <FinalizeEvacuatedPlayers>g__ExitZoneEvent|0(FinalCutsceneStartEvent cutsceneEvent) { }

	}

	[CompilerGenerated]
	private sealed class <FinalizeEvacuatedPlayers>d__46 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FinallExitZone <>4__this; //Field offset: 0x20
		private <>c__DisplayClass46_0 <>8__1; //Field offset: 0x28
		private IGame <game>5__2; //Field offset: 0x30
		private List <pending>5__3; //Field offset: 0x38
		private HashSet <evacuateDoneProfileIds>5__4; //Field offset: 0x40
		private List <removeBuffer>5__5; //Field offset: 0x48
		private TimeSpan <timeout>5__6; //Field offset: 0x50
		private float <startTime>5__7; //Field offset: 0x58
		private Action <unsub>5__8; //Field offset: 0x60

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <FinalizeEvacuatedPlayers>d__46(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <InitCoroutine>d__36 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		private AbstractGame <game>5__2; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InitCoroutine>d__36(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OnFinalExitZoneInitCoroutine>d__57 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FinallExitZone <>4__this; //Field offset: 0x20
		public FinalExitZoneInitEvent finalExitZoneEvent; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OnFinalExitZoneInitCoroutine>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string FINAL_OVER_SEATS_EXIT_MESSAGE_PART1 = "FinalExitOverSeatsMesasgePt1"; //Field offset: 0x0
	private const string FINAL_EXIT_CONDITION_SEATS_PLAYERS = "FinalPlayers"; //Field offset: 0x0
	private const string FINAL_EXIT_CONDITION_SEATS_COUNT = "FinalSeats"; //Field offset: 0x0
	private const string FINAL_EXIT_CONDITION = "FinalShipSeatsCondition"; //Field offset: 0x0
	private const string FINAL_EXIT_DESCRIPTION = "ExitZUBRDescriptions"; //Field offset: 0x0
	private const string FINAL_EXIT_SEATS_DESCRIPTION = "FinalShipSeats"; //Field offset: 0x0
	private const string FINAL_EXIT_NAME = "FinalEvacuateExit"; //Field offset: 0x0
	private const string FINAL_OVER_SEATS_EXIT_MESSAGE_PART2 = "FinalExitOverSeatsMesasgePt2"; //Field offset: 0x0
	private const string FINAL_NO_ITEM_EXIT_MESSAGE = "FinalNoQuestItemMesasge"; //Field offset: 0x0
	public List finalCutscenesVariants; //Field offset: 0x20
	private Dictionary _cutsceneByQuest; //Field offset: 0x28
	public List questItemsRequirements; //Field offset: 0x30
	private Vector2 _playersToEvacuateRandom; //Field offset: 0x38
	private int _minPLayersToEvacuate; //Field offset: 0x40
	private int _playersToEvacuate; //Field offset: 0x44
	private List _playersInZone; //Field offset: 0x48
	private bool _evacuateInitialized; //Field offset: 0x50
	private bool _waitingEvacuateTimeLeft; //Field offset: 0x51
	private bool _showPlayersCounter; //Field offset: 0x52
	private bool _zoneActive; //Field offset: 0x53
	public float evacuateTimer; //Field offset: 0x54
	[SerializeField]
	private float _evacuateTimerElapsed; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x60
	private Action _unsubscribeOnDestroy; //Field offset: 0x68
	private int _alivePLayers; //Field offset: 0x70
	private List _allAlivePlayersList; //Field offset: 0x78
	private bool _isWatchingFinalCutscene; //Field offset: 0x80
	private float _toEndRaidTimeBuffer; //Field offset: 0x84
	public int testALivePlayers; //Field offset: 0x88
	private IEnumerable _playerInRaidItems; //Field offset: 0x90
	private List _playersCompleteQuests; //Field offset: 0x98
	private List _playersSurvived; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0xA8

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public FinallExitZone() { }

	public void ActivateCutsceneForPlayer(Player player, string cutsceneId) { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	private void BuildCutsceneMapping() { }

	private void CalculatePlayersCountToEvacuate() { }

	[IteratorStateMachine(typeof(<FinalizeEvacuatedPlayers>d__46))]
	private IEnumerator FinalizeEvacuatedPlayers() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public float GetEvacuateTimerByEndRaid() { }

	private string GetVariantCutsceneId(Player player) { }

	private void ImmediateBadEndForPlayer(Player player) { }

	[IteratorStateMachine(typeof(<InitCoroutine>d__36))]
	private IEnumerator InitCoroutine() { }

	private void InitEvacuate() { }

	public void InitZoneClient(int playersToEvacuate) { }

	public void InitZoneServer() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private void OnChangeFinalExitStateEvent(ChangeFinalExitStateEvent changeFinalExitStateEvent) { }

	private void OnDestroy() { }

	private void OnFinalCutsceneStartEvent(FinalCutsceneStartEvent incomingEvent) { }

	[IteratorStateMachine(typeof(<OnFinalExitZoneInitCoroutine>d__57))]
	private IEnumerator OnFinalExitZoneInitCoroutine(FinalExitZoneInitEvent finalExitZoneEvent) { }

	private void OnFinalExitZoneInitEvent(FinalExitZoneInitEvent finalExitZoneEvent) { }

	private void OnPlayerConnectedOrReconnected(IPlayer player) { }

	public override void OnTriggerEnter(Collider collider) { }

	public override void OnTriggerExit(Collider collider) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	private void Start() { }

	private void Update() { }

	public void WaitingEvacuateTimeLeft() { }

}

