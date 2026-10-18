namespace EFT.Character;

public class ObservedPlayerAudioSourceLimiter : IDisposable
{
	[CompilerGenerated]
	private sealed class <WorkCoroutine>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedPlayerAudioSourceLimiter <>4__this; //Field offset: 0x20

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
		public <WorkCoroutine>d__28(int <>1__state) { }

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

	private const int MAX_PLAYERS_LIMIT = 20; //Field offset: 0x0
	private const int MIN_PLAYERS_LIMIT = 10; //Field offset: 0x0
	private readonly Transform _listenerTransform; //Field offset: 0x10
	private readonly SpatialAudioSystem _spatialSystem; //Field offset: 0x18
	private readonly int _framesToProcess; //Field offset: 0x20
	private int _playersLimit; //Field offset: 0x24
	private float _sqrSourceCullingDistance; //Field offset: 0x28
	private bool _isWorked; //Field offset: 0x2C
	private int _currentIndex; //Field offset: 0x30
	private int _objectsPerFrame; //Field offset: 0x34
	private readonly Dictionary _audioContainersByPlayerID; //Field offset: 0x38
	private readonly List _registeredContainers; //Field offset: 0x40
	private readonly Dictionary _activeContainersByID; //Field offset: 0x48
	private Coroutine _workCoroutine; //Field offset: 0x50

	private bool IsLimitExceed
	{
		private get { } //Length: 74
	}

	public int RegisteredContainersCount
	{
		 get { } //Length: 65
	}

	public ObservedPlayerAudioSourceLimiter(SpatialAudioSystem spatialSystem, Transform listenerTransform, float maxDistance = 100, int framesToProcess = 30) { }

	private void CheckSourcesLimit(AudioSourceContainer checkedContainer, bool isOutOfHearingRange) { }

	public override void Dispose() { }

	private bool get_IsLimitExceed() { }

	public int get_RegisteredContainersCount() { }

	private float GetSqrDistanceToListener(AudioSourceContainer container) { }

	private void PlayerDeadOrUnspawnHandler(IPlayer player) { }

	private void RecalculateObjectsPerFrame() { }

	public void RegisterContainer(int playerID, AudioSourceContainer container, bool forceActivate = true) { }

	public void RegisterPlayer(IPlayer observer, bool forceActivate = true) { }

	public void StartWork() { }

	public void StopWork() { }

	private void SwitchSoundOcclusionCulling(AudioSourceContainer container, bool isOutOfHearingRange) { }

	public void UnregisterContainer(int playerID) { }

	public void UnregisterPlayer(IPlayer player) { }

	private void UpdateLimitedSource(AudioSourceContainer container, bool enabled) { }

	private void UpdatePlayersLimit() { }

	[IteratorStateMachine(typeof(<WorkCoroutine>d__28))]
	private IEnumerator WorkCoroutine() { }

}

