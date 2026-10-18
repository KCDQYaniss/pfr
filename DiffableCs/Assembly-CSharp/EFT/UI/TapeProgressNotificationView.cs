namespace EFT.UI;

public class TapeProgressNotificationView : BaseNotificationView, INotificationView
{
	[CompilerGenerated]
	private sealed class <StartTimer>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TapeProgressNotificationView <>4__this; //Field offset: 0x20

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
		public <StartTimer>d__15(int <>1__state) { }

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

	private const string TIME_FORMAT = "mm\:ss"; //Field offset: 0x0
	private const string DURATION_KEY = "Tapes/Playback{0}{1}"; //Field offset: 0x0
	private const string BINDING_KEY = "Tapes/StopKey{0}"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _tapeNameLabel; //Field offset: 0xE8
	[SerializeField]
	private TMP_Text _timerLabel; //Field offset: 0xF0
	[SerializeField]
	private TMP_Text _keyLabel; //Field offset: 0xF8
	private string _totalTimeStr; //Field offset: 0x100
	private Coroutine _timerCoroutine; //Field offset: 0x108
	private float _timer; //Field offset: 0x110
	private float _totalTime; //Field offset: 0x114
	private NotificationTapeProgress _source; //Field offset: 0x118

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public TapeProgressNotificationView() { }

	public virtual void Close() { }

	public virtual bool get_ReturnToPool() { }

	protected virtual float GetHeight() { }

	private string GetTimeString(float time) { }

	public override void Init(NotificationTapeProgress notification) { }

	[IteratorStateMachine(typeof(<StartTimer>d__15))]
	private IEnumerator StartTimer() { }

	public void Stop() { }

}

