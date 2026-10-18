namespace EFT.GameTriggers;

[Obfuscation(Exclude = True)]
public class HandlerPlayQueueSound : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public QueuedSoundConfig captured; //Field offset: 0x10
		public HandlerPlayQueueSound <>4__this; //Field offset: 0x28

		public <>c__DisplayClass8_0() { }

		internal void <Start>b__0(TriggerEvent _) { }

	}

	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__15 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlayQueueSound <>4__this; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_InputTriggerIds>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__17 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_OutputTriggerIds>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct QueuedSoundConfig
	{
		public AudioClip Clip; //Field offset: 0x0
		[Range(0, 100)]
		public float Weight; //Field offset: 0x8
		public bool NeedSubtitles; //Field offset: 0xC
		public string SubtitlesId; //Field offset: 0x10

	}

	[SerializeField]
	private string _inputTriggerId; //Field offset: 0x20
	[SerializeField]
	private QueuedSoundConfig[] _sounds; //Field offset: 0x28
	[SerializeField]
	private QueuePlayer _queuePlayer; //Field offset: 0x30

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__15))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__17))]
		 get { } //Length: 80
	}

	public HandlerPlayQueueSound() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__15))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__17))]
	public override IEnumerable get_OutputTriggerIds() { }

	private string GetPlayTriggerId(int index) { }

	private static bool IsPickable(in QueuedSoundConfig config) { }

	private void OnInputTrigger(TriggerEvent triggerEvent) { }

	private void OnPlayClip(QueuedSoundConfig config) { }

	private static void PlaySubtitles(QueuedSoundConfig config) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

