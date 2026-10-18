namespace Audio.AudioCulling;

public abstract class AudioCullingManager`2 : BaseAudioCulling
{
	[CompilerGenerated]
	private sealed class <Work>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public AudioCullingManager <>4__this; //Field offset: 0x0

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
		public <Work>d__14(int <>1__state) { }

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

	private int _currentMaxUpdatesPerFrame; //Field offset: 0x0
	private readonly List _objects; //Field offset: 0x0
	private readonly HashSet _objectsInstanceID; //Field offset: 0x0
	private readonly Dictionary _instanceIDToIndex; //Field offset: 0x0
	[CompilerGenerated]
	private THandler <Handler>k__BackingField; //Field offset: 0x0

	protected private THandler Handler
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AudioCullingManager`2() { }

	protected virtual void Awake() { }

	public void CleanRegisteredObjects() { }

	protected abstract THandler CreateHandler(AudioSourcePriorityCalculator priorityCalculator) { }

	[CompilerGenerated]
	protected THandler get_Handler() { }

	protected override void OnAfterRegister(T obj, bool wasAlreadyRegistered) { }

	protected virtual void OnDestroy() { }

	public void Register(T obj, bool restartSource = false) { }

	public void Remove(T obj) { }

	[CompilerGenerated]
	private void set_Handler(THandler value) { }

	[IteratorStateMachine(typeof(<Work>d__14))]
	protected virtual IEnumerator Work() { }

}

