//Type is in global namespace

public class QueuePlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayOneClip>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioClip clip; //Field offset: 0x20
		public QueuePlayer <>4__this; //Field offset: 0x28

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
		public <PlayOneClip>d__10(int <>1__state) { }

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
	private sealed class <ProcessQueue>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public QueuePlayer <>4__this; //Field offset: 0x20

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
		public <ProcessQueue>d__9(int <>1__state) { }

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
	private sealed class <WaitForTailOrNewClip>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public QueuePlayer <>4__this; //Field offset: 0x20

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
		public <WaitForTailOrNewClip>d__11(int <>1__state) { }

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

	public float MinGapBetweenTracks; //Field offset: 0x20
	public float TailPadding; //Field offset: 0x24
	private List _sources; //Field offset: 0x28
	private Coroutine _processing; //Field offset: 0x30
	private double _scheduledEndDspTime; //Field offset: 0x38
	private readonly BindableList _queue; //Field offset: 0x40

	public QueuePlayer() { }

	private void Awake() { }

	private double ComputeStartDsp(double gap) { }

	private void OnDisable() { }

	private void OnItemAdded(AudioClip _) { }

	public void Play(AudioClip clip) { }

	[IteratorStateMachine(typeof(<PlayOneClip>d__10))]
	private IEnumerator PlayOneClip(AudioClip clip) { }

	private void PrefetchNext() { }

	[IteratorStateMachine(typeof(<ProcessQueue>d__9))]
	private IEnumerator ProcessQueue() { }

	private void ScheduleClip(AudioClip clip) { }

	private void ScheduleSilenceTail() { }

	private void SetSourcesActive(bool active) { }

	private void StopProcessing() { }

	private void StopSilenceTail() { }

	[IteratorStateMachine(typeof(<WaitForTailOrNewClip>d__11))]
	private IEnumerator WaitForTailOrNewClip() { }

}

