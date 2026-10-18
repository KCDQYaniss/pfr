namespace EFT.Interactive;

public class KeycardDoor : Door
{
	[CompilerGenerated]
	private sealed class <PlayResultSound>d__13 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool success; //Field offset: 0x20
		public KeycardDoor <>4__this; //Field offset: 0x28

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
		public <PlayResultSound>d__13(int <>1__state) { }

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
	private sealed class <SmoothDoorOpenCoroutine>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public KeycardDoor <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public bool isLocalInteraction; //Field offset: 0x29
		public float speed; //Field offset: 0x2C

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
		public <SmoothDoorOpenCoroutine>d__11(int <>1__state) { }

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
	private sealed class <UnlockCoroutine>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public KeycardDoor <>4__this; //Field offset: 0x20

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
		public <UnlockCoroutine>d__12(int <>1__state) { }

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
	private sealed class <UnlockFail>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public KeycardDoor <>4__this; //Field offset: 0x20

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
		public <UnlockFail>d__10(int <>1__state) { }

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
	private string[] _additionalKeys; //Field offset: 0x238
	[SerializeField]
	private bool _openOnUnlock; //Field offset: 0x240
	[SerializeField]
	private bool _lockOperationsAfterOpen; //Field offset: 0x241
	[SerializeField]
	private bool _lockOnShut; //Field offset: 0x242
	public AudioClip DeniedBeep; //Field offset: 0x248
	public AudioClip GrantedBeep; //Field offset: 0x250
	public AudioClip UnlockSound; //Field offset: 0x258
	private GripPose _lastGrip; //Field offset: 0x260
	private bool _playedUnlockForObservers; //Field offset: 0x268
	public InteractiveProxy[] Proxies; //Field offset: 0x270

	public KeycardDoor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(EDoorState state, bool isLocalInteraction, float speed) { }

	[CompilerGenerated]
	private bool <GetHandle>b__15_0(InteractiveProxy x) { }

	private GripPose GetClosesGripFromProxy(InteractiveProxy proxy, Vector3 playerPosition) { }

	private InteractiveProxy GetClosesProxy(Vector3 playerPosition) { }

	public DoorHandle GetHandle() { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public virtual void Interact(InteractionResult interactionResult) { }

	public virtual void OnEnable() { }

	[IteratorStateMachine(typeof(<PlayResultSound>d__13))]
	private IEnumerator PlayResultSound(bool success) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__11))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

	public virtual void SyncInteractState(InteractiveObjectStatusInfo info) { }

	private void TryPlayObservedUnlockSound(EDoorState prevState) { }

	[IteratorStateMachine(typeof(<UnlockCoroutine>d__12))]
	protected virtual IEnumerator UnlockCoroutine() { }

	[IteratorStateMachine(typeof(<UnlockFail>d__10))]
	private IEnumerator UnlockFail() { }

	public virtual Option UnlockOperation(KeyComponent key, Player player, WorldInteractiveObject wio) { }

}

