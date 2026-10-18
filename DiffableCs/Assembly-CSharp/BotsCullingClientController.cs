//Type is in global namespace

public class BotsCullingClientController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <WaitForSync>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BotsCullingClientController <>4__this; //Field offset: 0x20

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
		public <WaitForSync>d__5(int <>1__state) { }

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

	private Action _unsubscribeFromEvent; //Field offset: 0x20
	private HashSet _lastForceHidden; //Field offset: 0x28

	private BotsCulling Sync
	{
		private get { } //Length: 64
	}

	public BotsCullingClientController() { }

	private void Apply(HashSet actualForceHidden) { }

	private static void Apply(int playerId, bool forcedHidden) { }

	private BotsCulling get_Sync() { }

	private void OnDestroy() { }

	private void OnSetModeEvent(BotCullingStateSyncEvent syncEvent) { }

	public static void Reapply() { }

	private void Start() { }

	[IteratorStateMachine(typeof(<WaitForSync>d__5))]
	private IEnumerator WaitForSync() { }

}

