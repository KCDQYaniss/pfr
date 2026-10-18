namespace EFT.Interactive;

public sealed class CardReader : WorldInteractiveObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public KeyComponent key; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <UnlockOperation>b__0(KeyTriggerPair p) { }

		internal bool <UnlockOperation>b__1(KeyTriggerPair p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string oldId; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <TryRenameId>b__0(KeyTriggerPair triggerPair) { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CardReader <>4__this; //Field offset: 0x28
		private KeyTriggerPair[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

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
		public <get_OutputTriggerIds>d__16(int <>1__state) { }

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
	private sealed class <PlayResultSound>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool success; //Field offset: 0x20
		public CardReader <>4__this; //Field offset: 0x28

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
		public <PlayResultSound>d__14(int <>1__state) { }

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

	private struct KeyTriggerPair
	{
		public string KeyId; //Field offset: 0x0
		public string TriggerId; //Field offset: 0x8
		public bool Success; //Field offset: 0x10

	}

	[SerializeField]
	private KeyTriggerPair[] _keyMap; //Field offset: 0x178
	[SerializeField]
	private string _defaultTriggerId; //Field offset: 0x180
	[SerializeField]
	private bool _takeKeyUsage; //Field offset: 0x188
	[Header("Audio")]
	public AudioClip DeniedBeep; //Field offset: 0x190
	public AudioClip GrantedBeep; //Field offset: 0x198
	[Header("Proxy")]
	public InteractiveProxy[] Proxies; //Field offset: 0x1A0
	private GripPose _lastGrip; //Field offset: 0x1A8

	public virtual IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__16))]
		 get { } //Length: 175
	}

	public CardReader() { }

	[CompilerGenerated]
	private bool <GetHandle>b__10_0(InteractiveProxy x) { }

	[CompilerGenerated]
	private bool <GetInteractionParameters>b__9_0(InteractiveProxy p) { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__16))]
	public virtual IEnumerable get_OutputTriggerIds() { }

	public DoorHandle GetHandle() { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public virtual void Interact(InteractionResult interactionResult) { }

	public virtual void OnEnable() { }

	[IteratorStateMachine(typeof(<PlayResultSound>d__14))]
	private IEnumerator PlayResultSound(bool success) { }

	private ValueTuple ResolveReaction(KeyComponent key) { }

	public virtual bool TryRenameId(string oldId, string newId) { }

	public virtual Option UnlockOperation(KeyComponent key, Player player, WorldInteractiveObject wio) { }

}

