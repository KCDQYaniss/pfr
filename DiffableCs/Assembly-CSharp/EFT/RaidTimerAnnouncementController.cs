namespace EFT;

public class RaidTimerAnnouncementController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <TimerCheckCoroutine>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RaidTimerAnnouncementController <>4__this; //Field offset: 0x20

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
		public <TimerCheckCoroutine>d__11(int <>1__state) { }

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

	[SerializeField]
	private float _timePointMS; //Field offset: 0x20
	[SerializeField]
	private string _announcementId; //Field offset: 0x28
	private bool _hasTriggered; //Field offset: 0x30
	private bool _isInitialized; //Field offset: 0x31
	private Coroutine _timerCheckCoroutine; //Field offset: 0x38
	private readonly WaitForSeconds _checkInterval; //Field offset: 0x40

	public RaidTimerAnnouncementController() { }

	private void AfterGameStarted() { }

	private void Awake() { }

	private void CheckTimePoint(float remainingTime) { }

	private void Initialize() { }

	private void MarkPassedTimePoint() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<TimerCheckCoroutine>d__11))]
	private IEnumerator TimerCheckCoroutine() { }

	private void TriggerAnnouncement() { }

	private bool TryGetRemainingTime(out float remainingTime) { }

}

